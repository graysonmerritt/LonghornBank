using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Team4_Final_Project.DAL;
using Team4_Final_Project.Models;

namespace Team4_Final_Project.Controllers
{
    public class TransactionsController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        public TransactionsController(AppDbContext context, UserManager<AppUser> userManger)
        {
            _context = context;
            _userManager = userManger;
        }

        private SelectList GetAllAccounts()
        {
            List<Account> account = _context.Accounts.Where(u => u.AppUser.UserName == User.Identity.Name).ToList();
            SelectList accountSelectList = new SelectList(account.OrderBy(a => a.AccountID), "AccountID", "Nickname");
            return accountSelectList;
        }


        public IActionResult ShowPending()
        {
            List<Transaction> transactions = _context.Transactions.ToList();
            return View(transactions);
        }


        //show the link for detailed search
        public IActionResult DetailedSearch()
        {
            return View();
        }



        // just fill up list with all transactions
        public IActionResult ShowAll()
        {
            List<Transaction> transactions = _context.Transactions.ToList();

            return View("Index", transactions);
        }

        // GET: Transactions
        // use index for quick search??
        // index can filter based on if they navigated from the account details page
        public async Task<IActionResult> Index(int? id)
        {
            List<Transaction> transactions;

            if (!User.IsInRole("Customer"))
            {
                transactions = _context.Transactions.ToList();
            }
            // is a customer and should only see their transactions
            else
            {
                if (id is null)
                {
                    transactions = _context.Transactions.Where(a => a.Account.AppUser.UserName == User.Identity.Name).ToList();

                }
                // actually have an account, so only show those transactions
                else
                {
                    transactions = _context.Transactions.Where(a => a.Account.AccountID == id).ToList();
                }

            }

            return View(transactions);
        }

        // GET: Transactions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Transactions == null)
            {
                return View("Error", new String[] { "Please specify a transaction to view!" });
            }
            // grab disputes and add them to the transaction that was grabbed
            Transaction transaction = await _context.Transactions.Include(a => a.Account).FirstOrDefaultAsync(t => t.TransactionID == id);
            transaction.Disputes = _context.Disputes.Where(t => t.Transaction.TransactionID == id).ToList();

            if (transaction == null)
            {
                return View("Error", new String[] { "This transacion was not found!" });
            }

            return View(transaction);
        }


        public async Task<IActionResult> Withdrawal()
        {
            ViewBag.GetAllAccounts = GetAllAccounts();

            return View();
        }
        // different from the accounts/depost due to choosing which account we want this time
        public async Task<IActionResult> Deposit()
        {
            ViewBag.GetAllAccounts = GetAllAccounts();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Withdrawal([Bind("TransactionID,Number,Amount,Notes,Date,Type,Status,DistributionStatus")] Transaction transaction, int selectedAccount)
        {
            Account account = _context.Accounts.FirstOrDefault(a => a.AccountID == selectedAccount);
            if (transaction.Amount > account.Balance)
            {
                return View("Error", new String[] { "Can't withdraw more than balance!" });
            }
            if (!account.isActive)
            {
                return View("Error", new String[] { "Inactive Account" });
            }
            // set nav properties
            transaction.Account = account;
            account.Transactions.Add(transaction);
            transaction.Type = TransactionType.Withdrawal;
            // NEEDED TO MAKE ALL KINDS OF LOGIC WORK
            transaction.Amount = -(transaction.Amount);
            account.Balance += transaction.Amount;
            transaction.Number = Utilities.GenerateNextTransactionNumber.GetNextTransactionNumber(_context);
            // TODO: check if this is needed cuz i'm totally blanking
            transaction.Status = TransactionStatus.Completed;
            //TODO: set a default for date????
            if (ModelState.IsValid)
            {
                _context.Add(transaction);
                await _context.SaveChangesAsync();
                return RedirectToAction("Details", "Transactions", new { id = transaction.TransactionID });
            }
            return View(transaction);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Deposit([Bind("TransactionID,Number,Amount,Notes,Date,Type,Status,DistributionStatus")] Transaction transaction, int selectedAccount)
        {
            Account account = _context.Accounts.FirstOrDefault(a => a.AccountID == selectedAccount);
            
            if (transaction.Amount <= 0)
            {
                return View("Error", new String[] { "Can't deposit nothing!" });
            }
            if (!account.isActive)
            {
                return View("Error", new String[] { "Inactive Account" });
            }

            if (transaction.Amount > 5000)
            {
                transaction.Status = TransactionStatus.Pending;
            }
            else
            {
                transaction.Status = TransactionStatus.Completed;

            }

            // check IRA contribution logic
            if (account.Type == AccountType.IRA)
            {
                AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
                Int32 age = Int32.Parse(DateTime.Now.ToString("yyyyMMdd"))
                    - Int32.Parse(user.Birthday.ToString("yyyyMMdd"))/10000;
                if (age>= 70)
                {
                    return View("Error", new String[] { "You cannot contribute to your IRA as you are 70 or older"});
                }
                List<Transaction> transactions = _context.Transactions.Where(a => a.Account.AccountID == selectedAccount).ToList();
                Decimal sum = 0.00m;
                foreach (Transaction i in transactions)
                {
                    sum += i.Amount;
                }
                sum += transaction.Amount;
                if (sum > 5000)
                {
                    // TODO: CREATE THIS VIEW AND WORK ON THIS PART OMG
                    return RedirectToAction("FixIRA", "Transactions", new { id = transaction.TransactionID });
                }
            }

            transaction.Number = Utilities.GenerateNextTransactionNumber.GetNextTransactionNumber(_context);

            // set nav properties
            account.Transactions.Add(transaction);
            transaction.Account = account;

            if (ModelState.IsValid)
            {
                _context.Add(transaction);
                await _context.SaveChangesAsync();
                return RedirectToAction("Details", "Transactions", new { id = transaction.TransactionID });
            }
            return View(transaction);
        }


        // GET: Transactions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Transactions == null)
            {
                return View("Error", new String[] { "Please specify a transaction to edit" });
            }

            Transaction transaction = _context.Transactions.Include(a => a.Account).FirstOrDefault(t => t.TransactionID == id);
            if (transaction == null)
            {
                return View("Error", new String[] { "This transacion was not found in the database!" });
            }
            return View(transaction);
        }

        // POST: Transactions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TransactionID,Number,Amount,Notes,Date,Type,Status,DistributionStatus")] Transaction transaction)
        {
            if (id != transaction.TransactionID)
            {
                return View("Error", new String[] { "There was a problem editing this transaction. Try again!" });
            }

            //if there is something wrong with this order, try again
            if (ModelState.IsValid == false)
            {
                return View(transaction);
            }
            //if code gets this far, update the record
            try
            {
                //find the record in the database
                Transaction dbTransaction = _context.Transactions.Include(a => a.Account).FirstOrDefault(t => t.TransactionID == transaction.TransactionID);
                Account dbAccount = _context.Accounts.FirstOrDefault(ac => ac.AccountID == dbTransaction.Account.AccountID);
                //update the account balance and automatically set status to completed
                dbTransaction.Status = TransactionStatus.Completed;
                dbAccount.Balance += transaction.Amount;

                _context.Update(dbAccount);
                _context.Update(dbTransaction);

                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return View("Error", new String[] { "There was an error updating this transaction!", ex.Message });
            }

            //send the user to the Accounts Index page.
            return RedirectToAction(nameof(Index));
        }

        // GET: Transactions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Transactions == null)
            {
                return NotFound();
            }

            var transaction = await _context.Transactions
                .FirstOrDefaultAsync(m => m.TransactionID == id);
            if (transaction == null)
            {
                return NotFound();
            }

            return View(transaction);
        }

        // POST: Transactions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Transactions == null)
            {
                return Problem("Entity set 'AppDbContext.Transactions'  is null.");
            }
            var transaction = await _context.Transactions.FindAsync(id);
            if (transaction != null)
            {
                _context.Transactions.Remove(transaction);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TransactionExists(int id)
        {
            return _context.Transactions.Any(e => e.TransactionID == id);
        }
    }
}
