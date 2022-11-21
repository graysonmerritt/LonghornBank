using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Team4_Final_Project.DAL;
using Team4_Final_Project.Models;

namespace Team4_Final_Project.Controllers
{
    public class AccountsController : Controller
    {
        private readonly AppDbContext _context;

        public AccountsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Accounts
        public async Task<IActionResult> Index()
        {
            List<Account> accounts = new List<Account>();

            if (User.IsInRole("Customer"))
            {

                accounts = _context.Accounts.Where(u => u.AppUser.UserName == User.Identity.Name).ToList();
            }
            // employee or admmin, can see all accounts 
            else
            {

                accounts = _context.Accounts.ToList();
            }
            return View(accounts);
        }

        // GET: Accounts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Accounts == null)
            {
                return NotFound();
            }

            Account account = await _context.Accounts.Include(u => u.AppUser).FirstOrDefaultAsync(m => m.AccountID == id);
            if (account == null)
            {
                return View("Error", new String[] { "Cannot find the account!" });
            }

            if (User.IsInRole("Customer") && account.AppUser.UserName != User.Identity.Name)
            {
                return View("Error", new String[] { "This is not your account!  Don't be such a snoop!" });
            }
            return View(account);
        }


        [Authorize(Roles = "Customer")]
        public IActionResult Deposit(int? id)
        {
            Account account = _context.Accounts.Find(id);
            if (account == null)
            {
                return View("Error", new String[] { "Account could not be found!" });
            }
            return View(account);
        }

        // TODO: ask if we need to have an initial deposit transaction. Otherwise, we may not need this
        //POST
       //[HttpPost]
       //[ValidateAntiForgeryToken]
       //[Authorize(Roles = "Customer")]
       // public async Task<IActionResult> Deposit(int id, [Bind("AccountID,AccountNumber,AccountName,Status, accountType, Value")] Account account)
       // {
       //     if (id != account.AccountID)
       //     {
       //         return NotFound();
       //     }
       //     // grab account 
       //     Account userAccount = await _context.Accounts
       //         .Include(u => u.AppUser)
       //         .FirstOrDefaultAsync(m => m.AccountID == id);
       // }

        // GET: Accounts/Create
        [Authorize(Roles = "Customer")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Accounts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Customer")]
        public async Task<IActionResult> Create([Bind("AccountID,AccountNumber,Nickname,isActive,Type,Balance,AppUser")] Account account)
        {
            account.AppUser = _context.Users.FirstOrDefault(u => u.UserName == User.Identity.Name);
            var query = from a in _context.Accounts select a;
            var count = query.Where(a => a.AppUser == account.AppUser && a.Type == AccountType.IRA).ToList().Count();
            // check to see if they have an account already made
            if (count >= 1)
            {
                return View("Error", new String[] { "You can only have one IRA account." });
            }

            // set default nick names that were said in specs
            if (account.Type == AccountType.Checking)
            {
                if (account.Nickname is null)
                {
                    account.Nickname = "Longhorn Checking";
                }

            }
            if (account.Type == AccountType.Savings)
            {
                if (account.Nickname is null)
                {
                    account.Nickname = "Longhorn Savings";
                }
            }


            // actually set account number so I don't keep breaking my code
            account.AccountNumber = Utilities.GenerateNextAccountNumber.GetNextAccountNumber(_context);
            String s = account.AccountNumber.ToString();
            account.HiddenAccountNumber = s.Substring(s.Length - 4);
            
            account.isActive = true;
            if (ModelState.IsValid)
            {
                _context.Add(account);
                await _context.SaveChangesAsync();
                return RedirectToAction("Deposit", new { id = account.AccountID });
            }
            return View(account);
        }

        // GET: Accounts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Accounts == null)
            {
                return NotFound();
            }

            Account account = await _context.Accounts.Include(u => u.AppUser).FirstOrDefaultAsync(m => m.AccountID == id);
            if (account == null)
            {
                return NotFound();
            }

            if (User.IsInRole("Customer") && account.AppUser.UserName != User.Identity.Name)
            {
                return View("Error", new String[] { "This is not your account!  Don't be such a snoop trying to edit!" });
            }

            return View(account);
        }

        // POST: Accounts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AccountID,AccountNumber,Nickname,isActive,Type,Balance")] Account account)
        {
            if (id != account.AccountID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(account);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AccountExists(account.AccountID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(account);
        }

        // GET: Accounts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Accounts == null)
            {
                return NotFound();
            }

            var account = await _context.Accounts
                .FirstOrDefaultAsync(m => m.AccountID == id);
            if (account == null)
            {
                return NotFound();
            }

            return View(account);
        }

        // POST: Accounts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Accounts == null)
            {
                return Problem("Entity set 'AppDbContext.Accounts'  is null.");
            }
            var account = await _context.Accounts.FindAsync(id);
            if (account != null)
            {
                _context.Accounts.Remove(account);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AccountExists(int id)
        {
            return _context.Accounts.Any(e => e.AccountID == id);
        }

        public IActionResult Confirmation()
        {
            return View();
        }
    }
}
