using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BackEndCapstone.Data;
using BackEndCapstone.Models;

namespace BackEndCapstone.Controllers
{
    public class GemstonesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GemstonesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Gemstones
        public async Task<IActionResult> Index()
        {
            return View(await _context.Gemstone.ToListAsync());
        }

        // GET: Gemstones/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gemstone = await _context.Gemstone
                .FirstOrDefaultAsync(m => m.Id == id);
            if (gemstone == null)
            {
                return NotFound();
            }

            return View(gemstone);
        }

        // GET: Gemstones/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Gemstones/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,ImagePath,Description")] Gemstone gemstone)
        {
            if (ModelState.IsValid)
            {
                _context.Add(gemstone);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(gemstone);
        }

        // GET: Gemstones/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gemstone = await _context.Gemstone.FindAsync(id);
            if (gemstone == null)
            {
                return NotFound();
            }
            return View(gemstone);
        }

        // POST: Gemstones/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,ImagePath,Description")] Gemstone gemstone)
        {
            if (id != gemstone.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(gemstone);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GemstoneExists(gemstone.Id))
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
            return View(gemstone);
        }

        // GET: Gemstones/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gemstone = await _context.Gemstone
                .FirstOrDefaultAsync(m => m.Id == id);
            if (gemstone == null)
            {
                return NotFound();
            }

            return View(gemstone);
        }

        // POST: Gemstones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var gemstone = await _context.Gemstone.FindAsync(id);
            _context.Gemstone.Remove(gemstone);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GemstoneExists(int id)
        {
            return _context.Gemstone.Any(e => e.Id == id);
        }
    }
}
