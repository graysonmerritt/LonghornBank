using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public TransactionsController(AppDbContext context)
        {
            _context = context;
        }
        private SelectList GetAllAccounts()
        {
            List<Account> account = _context.Accounts.Where(u => u.AppUser.UserName == User.Identity.Name).ToList();
            SelectList accountSelectList = new SelectList(account.OrderBy(a => a.AccountID), "AccountID", "Nickname");
            return accountSelectList;
        }

        // GET: Transactions
        // use index for quick search
        public async Task<IActionResult> Index()
        {
            List<Transaction> transactions;

            if (!User.IsInRole("Customer"))
            {
                transactions = _context.Transactions.ToList();
            }
            // is a customer and should only see their transactions
            else
            {
                transactions = _context.Transactions.Where(r => r.Account.AppUser.UserName == User.Identity.Name).ToList();

            }

            return View(transactions);
        }

        // GET: Transactions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Transactions == null)
            {
                return NotFound();
            }

            List<Dispute> Disputes = _context.Disputes.Where(t => t.Transaction.TransactionID == id).ToList();
            var transaction = await _context.Transactions
                .Include(a => a.Account)
                .FirstOrDefaultAsync(m => m.TransactionID == id);
            transaction.Disputes = Disputes;
            if (transaction == null)
            {
                return NotFound();
            }

            return View(transaction);
        }

        // GET: Transactions/Create
        public IActionResult Create()
        {
            return View();
        }
        public async Task<IActionResult> Withdrawal(int? id)
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
            account.Balance = (account.Balance - transaction.Amount);
            transaction.Number = Utilities.GenerateNextTransactionNumber.GetNextTransactionNumber(_context);
            // TODO: check if this is needed cuz i'm totally blanking
            transaction.Status = TransactionStatus.Completed;
            //TODO: set a default for date????
            if (ModelState.IsValid)
            {
                _context.Add(transaction);
                await _context.SaveChangesAsync();
                return RedirectToAction("Details", "Transaction", new { id = transaction.TransactionID });
            }
            return View(transaction);
        }
        // POST: Transactions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TransactionID,Number,Amount,Notes,Date,Type,Status,DistributionStatus")] Transaction transaction)
        {
            if (ModelState.IsValid)
            {
                _context.Add(transaction);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(transaction);
        }

        // GET: Transactions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Transactions == null)
            {
                return NotFound();
            }

            var transaction = await _context.Transactions.FindAsync(id);
            if (transaction == null)
            {
                return NotFound();
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
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(transaction);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TransactionExists(transaction.TransactionID))
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
            return View(transaction);
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
