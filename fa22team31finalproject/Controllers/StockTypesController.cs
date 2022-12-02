﻿using System;
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
    [Authorize(Roles = "Admin")]
    public class StockTypesController : Controller
    {
        private readonly AppDbContext _context;

        public StockTypesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: StockTypes
        public async Task<IActionResult> Index()
        {
              return View(await _context.StockTypes.ToListAsync());
        }

        // GET: StockTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.StockTypes == null)
            {
                return NotFound();
            }

            var stockType = await _context.StockTypes
                .FirstOrDefaultAsync(m => m.StockTypeId == id);
            if (stockType == null)
            {
                return NotFound();
            }

            return View(stockType);
        }

        // GET: StockTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: StockTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StockTypeId,StockTypeName")] StockType stockType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(stockType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(stockType);
        }

        // GET: StockTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.StockTypes == null)
            {
                return NotFound();
            }

            var stockType = await _context.StockTypes.FindAsync(id);
            if (stockType == null)
            {
                return NotFound();
            }
            return View(stockType);
        }

        // POST: StockTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("StockTypeId,StockTypeName")] StockType stockType)
        {
            if (id != stockType.StockTypeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(stockType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StockTypeExists(stockType.StockTypeId))
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
            return View(stockType);
        }

        // GET: StockTypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.StockTypes == null)
            {
                return NotFound();
            }

            var stockType = await _context.StockTypes
                .FirstOrDefaultAsync(m => m.StockTypeId == id);
            if (stockType == null)
            {
                return NotFound();
            }

            return View(stockType);
        }

        // POST: StockTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.StockTypes == null)
            {
                return Problem("Entity set 'AppDbContext.StockTypes'  is null.");
            }
            var stockType = await _context.StockTypes.FindAsync(id);
            if (stockType != null)
            {
                _context.StockTypes.Remove(stockType);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StockTypeExists(int id)
        {
          return _context.StockTypes.Any(e => e.StockTypeId == id);
        }
    }
}
