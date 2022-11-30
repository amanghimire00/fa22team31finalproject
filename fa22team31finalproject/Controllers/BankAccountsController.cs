using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using fa22team31finalproject.DAL;
using fa22team31finalproject.Models;
using Microsoft.AspNetCore.Authorization;
using System.Data;
using Microsoft.AspNetCore.Identity;

namespace fa22team31finalproject.Controllers
{
    public class BankAccountsController : Controller
    {
        private readonly AppDbContext _context;

        public BankAccountsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: BankAccounts
        public async Task<IActionResult> Index()
        {
              return View(await _context.Accounts.ToListAsync());
        }

        // GET: BankAccounts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Accounts == null)
            {
                return NotFound();
            }

            var bankAccount = await _context.Accounts
                .FirstOrDefaultAsync(m => m.BankAccountID == id);
            if (bankAccount == null)
            {
                return NotFound();
            }

            return View(bankAccount);
        }

        // GET: BankAccounts/Create
        [Authorize(Roles = "Customer")]
        public IActionResult Create()
        {
            ViewBag.BankAccounts = GetBankAccountSelectList();
            ViewBag.BankAccounts = GetBankAccountStatusSelectList();
            return View();
        }

        // POST: BankAccounts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Create([Bind("BankAccountID,AccountNumber,AccountName,Balance,AccountType,AccountStatus")] BankAccount bankAccount)
        {
            if (ModelState.IsValid)
            {
                ViewBag.BankAccounts = GetBankAccountSelectList();
                ViewBag.BankAccounts = GetBankAccountStatusSelectList();
                _context.Add(bankAccount);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bankAccount);
        }

        // GET: BankAccounts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Accounts == null)
            {
                return NotFound();
            }

            var bankAccount = await _context.Accounts.FindAsync(id);
            if (bankAccount == null)
            {
                return NotFound();
            }

            ViewBag.BankAccounts = GetBankAccountSelectList();
            ViewBag.BankAccounts = GetBankAccountStatusSelectList();
            return View(bankAccount);

        }

        // POST: BankAccounts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BankAccountID,AccountNumber,AccountName,Balance,AccountType,AccountStatus")] BankAccount bankAccount)
        {
            if (id != bankAccount.BankAccountID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    ViewBag.BankAccounts = GetBankAccountSelectList();
                    ViewBag.BankAccounts = GetBankAccountStatusSelectList();
                    _context.Update(bankAccount);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BankAccountExists(bankAccount.BankAccountID))
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

            return View(bankAccount);
        }

        // GET: BankAccounts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Accounts == null)
            {
                return NotFound();
            }

            var bankAccount = await _context.Accounts
                .FirstOrDefaultAsync(m => m.BankAccountID == id);
            if (bankAccount == null)
            {
                return NotFound();
            }

            ViewBag.BankAccounts = GetBankAccountSelectList();
            return View(bankAccount);
        }

        // POST: BankAccounts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Accounts == null)
            {
                return Problem("Entity set 'AppDbContext.Accounts'  is null.");
            }
            var bankAccount = await _context.Accounts.FindAsync(id);
            if (bankAccount != null)
            {
                _context.Accounts.Remove(bankAccount);
            }

            ViewBag.BankAccounts = GetBankAccountSelectList();
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BankAccountExists(int id)
        {
          return _context.Accounts.Any(e => e.BankAccountID == id);
        }
        //this is for account types
        private MultiSelectList GetBankAccountSelectList()
        {
            
            List<BankAccount> allAccounts = _context.Accounts.ToList();          
            MultiSelectList mslAll = new MultiSelectList(allAccounts.OrderBy(d => d.AccountType), "Checking", "Saving", "IRA");

            //return the MultiSelectList
            return mslAll;
        }
        //this is for account status
        private MultiSelectList GetBankAccountStatusSelectList()
        {
            List<BankAccount> allAccounts = _context.Accounts.ToList();
            MultiSelectList mslAll = new MultiSelectList(allAccounts.OrderBy(d => d.AccountStatus), "Active", "Inactive");

            //return the MultiSelectList
            return mslAll;
        }


    }
}
