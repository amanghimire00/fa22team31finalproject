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

namespace fa22team31finalproject.Controllers
{
    [Authorize]
    public class StockPortfoliosController : Controller
    {
        private readonly AppDbContext _context;

        public StockPortfoliosController(AppDbContext context)
        {
            _context = context;
        }

        // GET: StockPortfolios
        public async Task<IActionResult> Index()
        {
            var query = from u in _context.Users
                        select u;
            List<StockPortfolio> stockPortfolios = new List<StockPortfolio>();
            if (User.IsInRole("Admin") || User.IsInRole("Employee"))
            {
                stockPortfolios = _context.StockPortfolios.Include(u => u.AppUser).ToList();
            }
            else
            {
                stockPortfolios = _context.StockPortfolios.Include(u => u.AppUser).Where(u => u.AppUser.UserName == User.Identity.Name).ToList();
            }
            return View(stockPortfolios);
        }

        // GET: StockPortfolios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            var query = from r in _context.Users
                        select r;
            if (id == null || _context.StockPortfolios == null)
            {
                return NotFound();
            }

            var stockPortfolio = await _context.StockPortfolios.Include(d => d.AppUser)
                .FirstOrDefaultAsync(m => m.StockPortfolioID == id);
            if (stockPortfolio == null)
            {
                return NotFound();
            }

            return View(stockPortfolio);
        }

        // GET: StockPortfolios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: StockPortfolios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StockPortfolioID,AccountNumber,AccountName,CashBalance")] StockPortfolio stockPortfolio)
        {
            if (ModelState.IsValid)
            {
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
        public async Task<IActionResult> Edit(int id, [Bind("StockPortfolioID,AccountNumber,AccountName,CashBalance")] StockPortfolio stockPortfolio)
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
        [Authorize(Roles = "Admin")]
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
        [Authorize(Roles = "Admin")]
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
