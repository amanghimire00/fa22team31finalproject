using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using fa22team31finalproject.DAL;
using fa22team31finalproject.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using System.Data;

namespace fa22team31finalproject.Controllers
{
    [Authorize]
    public class TransactionsController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        public TransactionsController(AppDbContext context, UserManager<AppUser> userManger)
        {
            _context = context;
            _userManager = userManger;
        }

        // GET: Transactions
        public async Task<IActionResult> Index()
        {
            List<Transaction> transactions = new List<Transaction>();
            if (User.IsInRole("Admin"))
            {
                transactions = _context.Transactions.ToList();
            }
            else
            {
                transactions = _context.Transactions.Where(r => r.AppUser.UserName == User.Identity.Name).ToList();
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

            var transaction = await _context.Transactions.Include(d => d.AppUser)
                .FirstOrDefaultAsync(m => m.TransactionID == id);
            if (transaction == null)
            {
                return NotFound();
            }

            return View(transaction);
        }

        // GET: Transactions/Create
        public async Task<IActionResult> CreateAsync([Bind("TransactionID,TransactionNumber,TransactionType,TransactionAmount,TransactionDate")] Transaction transaction)
        {
            if (User.IsInRole("Customer"))
            {
                Transaction tran = new Transaction();
                tran.AppUser = await _userManager.FindByNameAsync(User.Identity.Name);
                return View(tran);
            }
            else
            {
                ViewBag.UserNames = await GetAllBankAccounts();
                return View("SelectBankAccountForTransaction");
            }

        }

        // POST: Transactions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TransactionID,TransactionNumber,TransactionType,TransactionDate,TransactionComment,TransactionApproved,TransactionAmount")] Transaction transaction)
        {
            transaction.TransactionNumber = (int)Utilities.GenerateNextTransactionID.GetNextTransactionID(_context);
            transaction.TransactionDate = DateTime.Now;
            //change this if you do extra credit
            //order.User = await _userManager.FindByNameAsync(order.User.UserName);

            transaction.AppUser = await _userManager.FindByNameAsync(User.Identity.Name);


            _context.Add(transaction);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index), new { transactionNumber = transaction.TransactionNumber });
        }

        // GET: Transactions/Edit/5
        public async Task<IActionResult> Edit(string id)
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
        public async Task<IActionResult> Edit(int id, [Bind("TransactionID,TransactionNumber,TransactionType,TransactionDate,TransactionComment,TransactionApproved")] Transaction transaction)
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
        [Authorize(Roles = "Admin")]
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
        [Authorize(Roles = "Admin")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
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

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> SelectBankAccountForTransaction(String SelectedBankAccount)
        {
            if (String.IsNullOrEmpty(SelectedBankAccount))
            {
                ViewBag.UserNames = await GetAllBankAccounts();
                return View("SelectBankAccountForTransaction");
            }
            Transaction tran = new Transaction();
            tran.AppUser = await _userManager.FindByNameAsync(SelectedBankAccount);
            return View("Create", tran);
        }

        public async Task<SelectList> GetAllBankAccounts()
        {
            List<AppUser> allBankAccounts = new List<AppUser>();
            foreach (AppUser dbUser in _context.Users)
            {
                if (await _userManager.IsInRoleAsync(dbUser, "Customer") == true)
                {
                    allBankAccounts.Add(dbUser);
                }
            }
            SelectList s1 = new SelectList(allBankAccounts.OrderBy(c => c.Email), nameof(AppUser.UserName), nameof(AppUser.Email));
            return s1;
        }
        private bool TransactionExists(int id)
        {
          return _context.Transactions.Any(e => e.TransactionID == id);
        }

    }
}
