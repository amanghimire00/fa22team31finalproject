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
            if (User.IsInRole("Admin") || User.IsInRole("Employee"))
            {
                transactions = _context.Transactions.Include(u => u.AppUser).ThenInclude(b => b.BankAccount).ToList();
            }
            else
            {
                transactions = _context.Transactions.Include(u => u.AppUser).ThenInclude(b => b.BankAccount).Where(r => r.AppUser.UserName == User.Identity.Name).ToList();
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

            var transaction = await _context.Transactions.Include(d => d.AppUser).ThenInclude(b => b.BankAccount)
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
                ViewBag.AllAccounts = GetBankAccountSelectList();
                return View(tran);
            }
            else
            {
                ViewBag.UserNames = await GetAllBankAccounts();
                ViewBag.AllAccounts = GetBankAccountSelectList();
                return View("SelectBankAccountForTransaction");
            }

        }

        // POST: Transactions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TransactionID,TransactionNumber,TransactionType,TransactionDate,TransactionComment,TransactionApproved, TransactionAmount")] Transaction transaction, int[] SelectedAccounts)
        {

            if (ModelState.IsValid == false)
            {
                ViewBag.AllAccounts = GetBankAccountSelectList();
                return View(transaction);
            }

            transaction.TransactionNumber = (int)Utilities.GenerateNextTransactionID.GetNextTransactionID(_context);
            transaction.TransactionDate = DateTime.Now;
            //change this if you do extra credit
            //order.User = await _userManager.FindByNameAsync(order.User.UserName);

            transaction.AppUser = await _userManager.FindByNameAsync(User.Identity.Name);


            _context.Add(transaction);
            await _context.SaveChangesAsync();


            return RedirectToAction(nameof(Index), new { transactionNumber = transaction.TransactionNumber, transactionAmount = transaction.TransactionAmount });
        }

        // GET: Transactions/Edit/5
        [Authorize(Roles = "Admin")]
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
        // To protect from overposting attacks, enable the specific properties yo
        // u want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "Admin")]
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
        private MultiSelectList GetBankAccountSelectList()
        {
            //Create a new list of Suppliers and get the list of the suppliers
            //from the database
            List <BankAccount> ba = new List<BankAccount>();

            if (User.IsInRole("Admin") || User.IsInRole("Employee"))
            {
                ba = _context.Accounts.Include(u => u.AppUser).ThenInclude(b => b.BankAccount).ToList();
            }
            else
            {
                ba = _context.Accounts.Include(u => u.AppUser).ThenInclude(b => b.BankAccount).Where(r => r.AppUser.UserName == User.Identity.Name).ToList();
            }

            //Multi-select lists do not require a selection, so you don't need
            //to add a dummy record like you do for select lists

            //use the MultiSelectList constructor method to get a new MultiSelectList
            MultiSelectList mslAllAccounts = new MultiSelectList(ba.OrderBy(d => d.AccountName), "BankAccountID", "AccountName");

            //return the MultiSelectList
            return mslAllAccounts;
        }

        private MultiSelectList GetBankAccountSelectList(Transaction transaction)
        {
            //Create a new list of departments and get the list of the departments
            //from the database
            List<BankAccount> ba = new List<BankAccount>();

            if (User.IsInRole("Admin") || User.IsInRole("Employee"))
            {
                ba = _context.Accounts.Include(u => u.AppUser).ThenInclude(b => b.BankAccount).ToList();
            }
            else
            {
                ba = _context.Accounts.Include(u => u.AppUser).ThenInclude(b => b.BankAccount).Where(r => r.AppUser.UserName == User.Identity.Name).ToList();
            }

            //loop through the list of course departments to find a list of department ids
            //create a list to store the department ids
            List<Int32> selectedAccountsIDs = new List<Int32>();

            //Loop through the list to find the DepartmentIDs
            foreach (BankAccount associatedAccount in transaction.BankAccounts)
            {
                selectedAccountsIDs.Add(associatedAccount.BankAccountID);
            }

            //use the MultiSelectList constructor method to get a new MultiSelectList
            MultiSelectList mslAllAccounts = new MultiSelectList(ba.OrderBy(d => d.AccountName), "BankAccountID", "AccountName", selectedAccountsIDs);

            //return the MultiSelectList
            return mslAllAccounts;
        }


    }
}
