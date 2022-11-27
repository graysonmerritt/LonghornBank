using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Team4_Final_Project.DAL;
using Team4_Final_Project.Models;


namespace Team4_Final_Project.Controllers
{
    // controller used to manage accounts from superior accounts 
    [Authorize]
    public class ManageController : Controller
    {
        private AppDbContext _context;
        private UserManager<AppUser> _userManager;
        private RoleManager<IdentityRole> _roleManager;
        private SignInManager<AppUser> _signInManager;
        private PasswordValidator<AppUser> _passwordValidator;


        public ManageController(AppDbContext context, UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager, SignInManager<AppUser> signIn)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signIn;
            _passwordValidator = (PasswordValidator<AppUser>)userManager.PasswordValidators.FirstOrDefault();
        }

        public IActionResult Index()
        {
            return View();
        }



        public async Task<IActionResult> ManageAllCustomers()
        {
            List<AppUser> users = new List<AppUser>();
            foreach (AppUser user in _userManager.Users)
            {
                if (await _userManager.IsInRoleAsync(user, "Customer"))
                {
                    users.Add(user);
                }
            }
            return View(users);

        }



        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> ManageAllEmployees()
        {

            List<AppUser> users = new List<AppUser>();
            foreach (AppUser user in _userManager.Users)
            {
                if (await _userManager.IsInRoleAsync(user, "Employee"))
                {
                    users.Add(user);
                }
            }
            return View(users);



        }



        //GET: RoleAdmin/Edit
        public IActionResult EditUser(string Email)
        {

            if (Email == null)
            {
                return View("Error", new String[] { "Please specify the account you wish to edit!" });
            }


            AppUser user = _context.Users.FirstOrDefault(u => u.Email == Email);

            return View(user);
        }

        //POST: RoleAdmin/Edit
        [HttpPost]
        public async Task<IActionResult> EditUser(string Email, AppUser appuser)
        {
            try
            {


                AppUser DBUser = _context.Users.Find(appuser.Id);

                var userId = _context.Users
                    .Where(m => m.Id == appuser.Id)
                    .Select(m => m.Email)
                    .SingleOrDefault();
                var ids = appuser.Id;

                AppUser id = _context.Users.FirstOrDefault(i => i.Email == Email);


                String UserName = Email;
                AppUser user = _context.Users.FirstOrDefault(u => u.UserName == UserName);

                user.FirstName = appuser.FirstName;

                user.LastName = appuser.LastName;
                user.MiddleInitial = appuser.MiddleInitial;
                user.Street = appuser.Street;
                user.City = appuser.City;
                user.State = appuser.State;
                user.Zipcode = appuser.Zipcode;
                user.PhoneNumber = appuser.PhoneNumber;

                _context.Update(user);

                _context.SaveChanges();
                await _context.SaveChangesAsync();

            }

            catch (DbUpdateConcurrencyException)
            {
                if (Email != appuser.Email)
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToAction(nameof(ManageAllCustomers));

        }

        public ActionResult ChangePassword(String Email)
        {

            return View();
        }



        // this method is called when the password only has to be entered in once
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> ChangePassword(ManageChangePasswordViewModel cpvm, String Email)
        {
            //if user forgot a field, send them back to 
            //change password page to try again
            if (ModelState.IsValid == false)
            {
                return View(cpvm);
            }

            //Find the logged in user using the UserManager
            AppUser user = _context.Users.FirstOrDefault(u => u.Email == Email);
            var token = await _userManager.GeneratePasswordResetTokenAsync(user);
            //Attempt to change the password using the UserManager
            var result = await _userManager.ResetPasswordAsync(user, token, cpvm.NewPassword);

            //if the attempt to change the password worked
            if (result.Succeeded)
            {


                //send the user back to the manage page
                return RedirectToAction("Index", "Manage");
            }
            else //attempt to change the password didn't work
            {
                //Add all the errors from the result to the model state
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

                //send the user back to the change password page to try again
                return View(cpvm);
            }
        }
    }
}
