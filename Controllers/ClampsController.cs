using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProClamp.Data;
using ProClamp.Models;

namespace ProClamp.Controllers
{
    public class ClampsController : Controller
    {
        private readonly ProClampContext _context;

        public ClampsController(ProClampContext context)
        {
            _context = context;
        }

        // GET: Clamps
        public async Task<IActionResult> Index()
        {
            return View(await _context.Clamp.ToListAsync());
        }

        // GET: Clamps/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clamp = await _context.Clamp
                .FirstOrDefaultAsync(m => m.ID == id);
            if (clamp == null)
            {
                return NotFound();
            }

            return View(clamp);
        }

        // GET: Clamps/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Clamps/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,Date,Type,Material,WeightInLB,Price,JawOpeningInInches,Application")] Clamp clamp)
        {
            if (ModelState.IsValid)
            {
                _context.Add(clamp);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(clamp);
        }

        // GET: Clamps/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clamp = await _context.Clamp.FindAsync(id);
            if (clamp == null)
            {
                return NotFound();
            }
            return View(clamp);
        }

        // POST: Clamps/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,Date,Type,Material,WeightInLB,Price,JawOpeningInInches,Application")] Clamp clamp)
        {
            if (id != clamp.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(clamp);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClampExists(clamp.ID))
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
            return View(clamp);
        }

        // GET: Clamps/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clamp = await _context.Clamp
                .FirstOrDefaultAsync(m => m.ID == id);
            if (clamp == null)
            {
                return NotFound();
            }

            return View(clamp);
        }

        // POST: Clamps/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var clamp = await _context.Clamp.FindAsync(id);
            _context.Clamp.Remove(clamp);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClampExists(int id)
        {
            return _context.Clamp.Any(e => e.ID == id);
        }
    }
}
