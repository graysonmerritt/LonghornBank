using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Team4_Final_Project.DAL;
using Team4_Final_Project.Models;

namespace Team4_Final_Project.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {

            List<Account> accounts = _context.Accounts.Where(r => r.AppUser.UserName == User.Identity.Name).ToList();
            Int32 numOfAccounts = accounts.Count();
            ViewBag.CountofAccounts = numOfAccounts;

            if (User.Identity.IsAuthenticated == false)
            {
                RedirectToAction("Login", "Account"); 
            }
            
            if (User.IsInRole("Customer"))
            {
                // TODO: check to see if customer has accounts, then redirect to account management page
                if (numOfAccounts > 0)
                {
                    return RedirectToAction("Index", "Accounts");
                }
                // else, need to create an account
                return RedirectToAction("Create", "Accounts");
            }

            return View();
        }
    }
}