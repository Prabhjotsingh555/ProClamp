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


        // GET: Movies
        public async Task<IActionResult> Index(string ClampType, string searchString) //make a method for showing the list of Clamps through searching by material or by type
        {
            // Use LINQ to get list of genres.
            IQueryable<string> genreQuery = from m in _context.Clamp  // Using LINQ to get a list of filtered Clamp types for dropdown selection.

                                            orderby m.Type
                                            select m.Type;

            var Clamps = from m in _context.Clamp  //Running a query to get a list of all clamps from the database.
                         select m;

            if (!string.IsNullOrEmpty(searchString))  // If a search string is provided, filters the list of Clamps to showonly those with material containing the search string.
            {
                Clamps = Clamps.Where(s => s.Material.Contains(searchString));
            }

            if (!string.IsNullOrEmpty(ClampType))  // If a clamp type is provided, filters the list of Clamps to show only those with choosed type.
            {
                Clamps = Clamps.Where(x => x.Type == ClampType);
            }

            var ClampTypeVM = new ClampTypeViewModel  // make a ViewModel containing a dropdown list of unique Clamp types and the filtered/unfiltered Clamps.
            {
                Type = new SelectList(await genreQuery.Distinct().ToListAsync()),
                Clamps = await Clamps.ToListAsync()
            };

            return View(ClampTypeVM); // Return the filtered or unfiltered Clamps to the view.
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
