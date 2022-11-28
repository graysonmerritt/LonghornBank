using System;
using System.Collections.Generic;
using System.Data.Common;
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
    public class DisputesController : Controller
    {
        private readonly AppDbContext _context;

        public DisputesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Disputes
        public async Task<IActionResult> Index()
        {
              return View(await _context.Disputes.ToListAsync());
        }

        // GET: Disputes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Disputes == null)
            {
                return View("Error", new String[] { "Please specify a dispute to view!" });
            }

            Dispute dispute = await _context.Disputes
                .FirstOrDefaultAsync(m => m.DisputeID == id);
            if (dispute == null)
            {
                return View("Error", new String[] { "This dispute was not found!" });
            }

            return View(dispute);
        }

        // GET: Disputes/Create
        public IActionResult Create(int? id)
        {
            Dispute dispute = new Dispute();
            dispute.Transaction = _context.Transactions.Find(id);
            return View(dispute);
        }

        // POST: Disputes/Create
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DisputeID,Note,AdminNote,Status,CorrectAmount, Transaction")] Dispute dispute)
        {
            // find transaction, connect to dispute, and submit dispute
            Transaction trans = _context.Transactions.Find(dispute.Transaction.TransactionID);
            dispute.Transaction = trans;
            dispute.Status = DisputeStatus.Submitted;
            
            if (ModelState.IsValid)
            {
                _context.Add(dispute);
                await _context.SaveChangesAsync();
                return RedirectToAction("Confirm", new { id = dispute.DisputeID });
            }
            return View(dispute);
        }

        [Authorize(Roles = "Admin")]
        // GET: Disputes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Disputes == null)
            {
                return View("Error", new String[] { "Please specify a dispute to edit" });
            }
            // include lots of info for edit page, mainly to see account name and make things easy on admin
            Dispute dispute = _context.Disputes
                .Include(t => t.Transaction)
                .ThenInclude(a => a.Account)
                .ThenInclude(u => u.AppUser)
                .FirstOrDefault(d => d.DisputeID == id);
            if (dispute == null)
            {
                return View("Error", new String[] { "This dispute was not found in the database!" });
            }
            return View(dispute);
        }

        // POST: Disputes/Edit/5
        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DisputeID,Note,AdminNote,Status,CorrectAmount")] Dispute dispute)
        {
            if (id != dispute.DisputeID)
            {
                return View("Error", new String[] { "There was a problem editing this dispute. Try again!" });
            }

            //if there is something wrong with this dispute, try again
            if (ModelState.IsValid == false)
            {
                return View(dispute);
            }
            //if code gets this far, update the record
            try
            {
                //find the record in the database
                Dispute dbDispute = _context.Disputes.Find(dispute.DisputeID);

                // grab transaction and account associated with dispute to edit
                Transaction dbTrans = _context.Transactions
                .Include(a => a.Account)
                .FirstOrDefault(t => t.TransactionID == dbDispute.Transaction.TransactionID);
                Account dbAccount = _context.Accounts.Include(u => u.AppUser).FirstOrDefault(b => b.AccountID == dbTrans.Account.AccountID);

                //TODO: add tons of logic to deal with adjusting or accepting disputes
                
                //update all three obejcts we pulled (joy)
                _context.Update(dbAccount);
                _context.Update(dbTrans);
                _context.Update(dbAccount);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return View("Error", new String[] { "There was an error updating this dispute!", ex.Message });
            }

            return RedirectToAction(nameof(DoneConfirm));
        }


        // the confrimation page an admin sees after working with a dispute
        public IActionResult DoneConfirm()
        {
            return View();
        }


        // GET: Disputes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Disputes == null)
            {
                return NotFound();
            }

            var dispute = await _context.Disputes
                .FirstOrDefaultAsync(m => m.DisputeID == id);
            if (dispute == null)
            {
                return NotFound();
            }

            return View(dispute);
        }

        // POST: Disputes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Disputes == null)
            {
                return Problem("Entity set 'AppDbContext.Disputes'  is null.");
            }
            var dispute = await _context.Disputes.FindAsync(id);
            if (dispute != null)
            {
                _context.Disputes.Remove(dispute);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DisputeExists(int id)
        {
          return _context.Disputes.Any(e => e.DisputeID == id);
        }
    }
}
