using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Team4_Final_Project.DAL;
using Team4_Final_Project.Models;

namespace Team4_Final_Project.Controllers
{
    public class StockPortfoliosController : Controller
    {
        private readonly AppDbContext _context;

        public StockPortfoliosController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Confirmation()
        {
            return View();
        }

        // GET: StockPortfolios
        public async Task<IActionResult> Index()
        {
            List<StockPortfolio> ports = new List<StockPortfolio>();
            if (User.IsInRole("Customer"))
            {

                ports = _context.StockPortfolios.Where(u => u.AppUser.UserName == User.Identity.Name).ToList();
            }
            // employee or admmin, can see all accounts 
            else
            {

                ports = _context.StockPortfolios.ToList();
            }
            return View(ports);
        }

        // GET: StockPortfolios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.StockPortfolios == null)
            {
                return NotFound();
            }

            StockPortfolio stockPortfolio = await _context.StockPortfolios.Include(u=> u.AppUser)
                .FirstOrDefaultAsync(m => m.StockPortfolioID == id);

            if (stockPortfolio == null)
            {
                return NotFound();
            }
            if (User.IsInRole("Customer") && stockPortfolio.AppUser.UserName != User.Identity.Name)
            {
                return View("Error", new String[] { "This is not your stock account!  Don't be such a snoop!" });
            }
            return View(stockPortfolio);
        }

        // GET: StockPortfolios/Create
        [Authorize(Roles = "Customer")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: StockPortfolios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StockPortfolioID,AccountNumber,HiddenAccountNumber,Nickname,Balanced,Gain,AvailableCash,Fee,Bonus,IsActive")] StockPortfolio stockPortfolio)
        {
            stockPortfolio.AppUser = _context.Users.FirstOrDefault(u => u.UserName == User.Identity.Name);
            // make sure they aren't creating another stock account
            var query = from sp in _context.StockPortfolios select sp;
            var count = query.Where(sp => sp.AppUser == stockPortfolio.AppUser).ToList().Count();
            if (count >= 1)
            {
                return View("Error", new String[] { "You can only have one Stock account." });
            }
            // actually set account number so I don't keep breaking my code
            stockPortfolio.AccountNumber = Utilities.GenerateNextAccountNumber.GetNextAccountNumber(_context);
            String s = stockPortfolio.AccountNumber.ToString();
            stockPortfolio.HiddenAccountNumber = s.Substring(s.Length - 4);
            
            stockPortfolio.IsActive = true;
            if (ModelState.IsValid)
            {
                stockPortfolio.Gain = 0m;
                stockPortfolio.Bonus = 0m;
                stockPortfolio.Balanced = true;
                stockPortfolio.IsActive = true;
                stockPortfolio.AvailableCash = 0m;
                stockPortfolio.Balance = 0m;

                _context.Add(stockPortfolio);
                await _context.SaveChangesAsync();
                return RedirectToAction("InitialDeposit", new { id = stockPortfolio.StockPortfolioID });
                _context.Add(stockPortfolio);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(stockPortfolio);
        }

        // GET: StockPortfolios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.StockPortfolios == null)
            {
                return NotFound();
            }

            var stockPortfolio = await _context.StockPortfolios.FindAsync(id);
            if (stockPortfolio == null)
            {
                return NotFound();
            }
            return View(stockPortfolio);
        }

        // POST: StockPortfolios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("StockPortfolioID,AccountNumber,HiddenAccountNumber,Nickname,Balanced,Gain,AvailableCash,Fee,Bonus,IsActive")] StockPortfolio stockPortfolio)
        {
            if (id != stockPortfolio.StockPortfolioID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(stockPortfolio);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StockPortfolioExists(stockPortfolio.StockPortfolioID))
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
            return View(stockPortfolio);
        }

        // GET: StockPortfolios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.StockPortfolios == null)
            {
                return NotFound();
            }

            var stockPortfolio = await _context.StockPortfolios
                .FirstOrDefaultAsync(m => m.StockPortfolioID == id);
            if (stockPortfolio == null)
            {
                return NotFound();
            }

            return View(stockPortfolio);
        }

        // POST: StockPortfolios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.StockPortfolios == null)
            {
                return Problem("Entity set 'AppDbContext.StockPortfolios'  is null.");
            }
            var stockPortfolio = await _context.StockPortfolios.FindAsync(id);
            if (stockPortfolio != null)
            {
                _context.StockPortfolios.Remove(stockPortfolio);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StockPortfolioExists(int id)
        {
          return _context.StockPortfolios.Any(e => e.StockPortfolioID == id);
        }
    }
}
