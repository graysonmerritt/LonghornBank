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
            List<Account> accounts;

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
                return View("Error", new String[] { "Please specify an account to view!" });
            }

            Account account = await _context.Accounts.Include(u => u.AppUser).Include(t=> t.Transactions).FirstOrDefaultAsync(a => a.AccountID == id);

            if (account == null)
            {
                return View("Error", new String[] { "This account was not found!" });
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
                return View("Error", new String[] { "This account was not found!" });
            }
            return View(account);
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Customer")]
        // can reuse this for transation deposit?
        public async Task<IActionResult> Deposit(int id, [Bind("AccountID,AccountNumber,AccountName,Status, Balance, accountType, Value")] Account account)
        {
            if (id != account.AccountID)
            {
                return View("Error", new String[] { "There was a problem adding a deposit to this account. Try again!" });

            }
            // grab account 
            Account dbAccount = await _context.Accounts
                .Include(u => u.AppUser)
                .FirstOrDefaultAsync(a => a.AccountID == id);

            Transaction transaction = new Transaction();

            // update our new account if deposit is logical
            if (account.Balance <= 0)
            {
                return View("Deposit", account);

            }
            if (account.Balance >= 5000)
            {
                transaction.Status = TransactionStatus.Pending;
            }
            else
            {
                transaction.Status = TransactionStatus.Completed;
                dbAccount.Balance = account.Balance;
            }
            // create transaction and add it to the account
            // TODO: set qualified property?
            transaction.Account = dbAccount;
            transaction.Notes = "Created Account";
            transaction.Number = Utilities.GenerateNextTransactionNumber.GetNextTransactionNumber(_context);
            transaction.Amount = account.Balance;
            transaction.Type = TransactionType.Deposit;
            transaction.Date = DateTime.Today;
            dbAccount.Transactions.Add(transaction);
            if (ModelState.IsValid)
            {
                _context.Update(dbAccount);
                _context.Add(transaction);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Confirm));
            }
            return View(dbAccount);
        }

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
            if (account.Type == AccountType.IRA)
            {
                // check to see if they have an account already made
                if (count >= 1)
                {
                    return View("Error", new String[] { "You can only have one IRA account." });
                }
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
                // deal with depsoit in a different method. Makes things easier with logic and debugging
                return RedirectToAction("Deposit", new { id = account.AccountID });
            }
            return View(account);
        }

        // GET: Accounts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Accounts == null)
            {
                return View("Error", new String[] { "Please specify an account to edit" });
            }

            Account account = await _context.Accounts.Include(u => u.AppUser).FirstOrDefaultAsync(a => a.AccountID == id);
            if (account == null)
            {
                return View("Error", new String[] { "This account was not found in the database!" });
            }

            if (User.IsInRole("Customer") && account.AppUser.UserName != User.Identity.Name)
            {
                return View("Error", new String[] { "This is not your account!  Don't be such a snoop trying to edit!" });
            }
            //account is not active - cannot be edited unless by employees or admin
            if (!account.isActive && User.IsInRole("Customer"))
            {
                return View("Error", new string[] { "This account is inactive and cannot be changed!" });
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
                return View("Error", new String[] { "There was a problem editing this account. Try again!" });
            }

            //if there is something wrong with this order, try again
            if (ModelState.IsValid == false)
            {
                return View(account);
            }
            //if code gets this far, update the record
            try
            {
                //find the record in the database
                Account dbAccount = _context.Accounts.Find(account.AccountID);

                //update the nickname
                dbAccount.Nickname = account.Nickname;
                dbAccount.isActive = account.isActive;
                _context.Update(dbAccount);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return View("Error", new String[] { "There was an error updating this account!", ex.Message });
            }

            //send the user to the Accounts Index page.
            return RedirectToAction(nameof(Index));
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

        public IActionResult Confirm()
        {
            return View();
        }
    }
}
