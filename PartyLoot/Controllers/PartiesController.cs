﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PartyLoot.Data;
using PartyLoot.Models;

namespace PartyLoot.Controllers
{
    public class PartiesController : Controller
    {
        private readonly PartyLootContext _context;

        public PartiesController(PartyLootContext context)
        {
            _context = context;
        }

        // GET: Parties
        public async Task<IActionResult> Index()
        {
              return _context.Party != null ? 
                          View(await _context.Party.ToListAsync()) :
                          Problem("Entity set 'PartyLootContext.Party'  is null.");
        }

        // GET: Parties/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Party == null)
            {
                return NotFound();
            }

            var party = await _context.Party
                .FirstOrDefaultAsync(m => m.Id == id);
            if (party == null)
            {
                return NotFound();
            }

            return View(party);
        }

        // GET: Parties/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Parties/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id")] Party party)
        {
            if (ModelState.IsValid)
            {
                _context.Add(party);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(party);
        }

        // GET: Parties/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Party == null)
            {
                return NotFound();
            }

            var party = await _context.Party.FindAsync(id);
            if (party == null)
            {
                return NotFound();
            }
            return View(party);
        }

        // POST: Parties/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id")] Party party)
        {
            if (id != party.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(party);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PartyExists(party.Id))
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
            return View(party);
        }

        // GET: Parties/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Party == null)
            {
                return NotFound();
            }

            var party = await _context.Party
                .FirstOrDefaultAsync(m => m.Id == id);
            if (party == null)
            {
                return NotFound();
            }

            return View(party);
        }

        // POST: Parties/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Party == null)
            {
                return Problem("Entity set 'PartyLootContext.Party'  is null.");
            }
            var party = await _context.Party.FindAsync(id);
            if (party != null)
            {
                _context.Party.Remove(party);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PartyExists(int id)
        {
          return (_context.Party?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
