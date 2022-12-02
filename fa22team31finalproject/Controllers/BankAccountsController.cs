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
        private readonly UserManager<AppUser> _userManager;

        public BankAccountsController(AppDbContext context, UserManager<AppUser> userManger)
        {
            _context = context;
            _userManager = userManger;
        }

        // GET: BankAccounts
        public async Task<IActionResult> Index()
        {
            List<BankAccount> bankAccounts = new List<BankAccount>();
            if (User.IsInRole("Admin"))
            {
                bankAccounts = _context.Accounts.ToList();
            }
            else
            {
                bankAccounts = _context.Accounts.Where(r => r.AppUser.UserName == User.Identity.Name).ToList();
            }
            return View(bankAccounts);
            /*List<BankAccount> bankAccounts;
            bankAccounts = _context.Accounts
                                .Where(r => r.AppUser.UserName == User.Identity.Name)
                                .ToList();


            return View(await _context.Accounts.ToListAsync());*/
        }

        // GET: BankAccounts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return View("Error", new String[] { "Please specify a order to view!" });
            }

            BankAccount ba = await _context.Accounts
                //Include(r => r.Transactions)
               // .ThenInclude(r => r.TransactionDetails)
                .Include(r => r.AppUser)
                .FirstOrDefaultAsync(m => m.BankAccountID == id);

            if (ba == null)
            {
                return View("Error", new String[] { "This order was not found!" });
            }

            if (User.IsInRole("Admin") == false && ba.AppUser.UserName != User.Identity.Name)
            {
                return View("Error", new String[] { "This is not your order!" });
            }
            return View(ba);
            /*if (id == null || _context.Accounts == null)
            {
                return NotFound();
            }

            var bankAccount = await _context.Accounts
                .FirstOrDefaultAsync(m => m.BankAccountID == id);
            if (bankAccount == null)
            {
                return NotFound();
            }

            return View(bankAccount);*/
        }

        // GET: BankAccounts/Create
        [Authorize(Roles = "Customer")]
        public IActionResult Create()
        {
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
            bankAccount.AccountNumber = Utilities.GenerateNextAccountID.GetNextAccountID(_context);

            bankAccount.AppUser = await _userManager.FindByNameAsync(User.Identity.Name);

            _context.Add(bankAccount);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index), new { accountNumber = bankAccount.AccountNumber });

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

            try
            {
                BankAccount dbBankAccount = _context.Accounts
                    .FirstOrDefault(c => c.BankAccountID == bankAccount.BankAccountID);


                //update the course's scalar properties
                dbBankAccount.AccountName = bankAccount.AccountName;
                dbBankAccount.AccountStatus = bankAccount.AccountStatus;


                //save the changes
                _context.Accounts.Update(dbBankAccount);
                _context.SaveChanges();
            }

            catch (Exception ex)
            {
                return View("Error", new string[] { "There was an error editing this account.", ex.Message });
            }


            return RedirectToAction(nameof(Index));
        }

        [Authorize(Roles = "Admin")]
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

            return View(bankAccount);
        }
        [Authorize(Roles = "Admin")]
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

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BankAccountExists(int id)
        {
            return _context.Accounts.Any(e => e.BankAccountID == id);
        }
        //this is for account types

       
    }
}
