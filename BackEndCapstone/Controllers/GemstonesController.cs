using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BackEndCapstone.Data;
using BackEndCapstone.Models;
using Microsoft.AspNetCore.Identity;
using BackEndCapstone.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace BackEndCapstone.Controllers
{
    public class GemstonesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;


        public GemstonesController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;

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
        public async Task<IActionResult> CreateAsync()
        {
            var viewModel = new GemstoneCreateViewModel();
            var user = await GetCurrentUserAsync();
            ViewData["UserId"] = new SelectList(_context.ApplicationUsers, "Id", "Id");
            return View(viewModel);
        }

        // POST: Gemstones/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,ImagePath,Description, File")] GemstoneCreateViewModel viewModel, IFormFile image)
        {
            ModelState.Remove("User");
            ModelState.Remove("UserId");
            var user = await GetCurrentUserAsync();
            if (ModelState.IsValid)
            {
                var gemstone = new Gemstone()

                {
                    Title = viewModel.Title,
                    Description = viewModel.Description,
                };
                if (viewModel.File != null && viewModel.File.Length > 0)
                {
                    var fileName = Path.GetFileName(viewModel.File.FileName); //getting path of actual file name
                    var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images", fileName); //creating path combining file name w/ www.root\\images directory
                    using (var fileSteam = new FileStream(filePath, FileMode.Create)) //using filestream to get the actual path 
                    {
                        await viewModel.File.CopyToAsync(fileSteam);
                    }
                    gemstone.ImagePath = fileName;
                }
                gemstone.UserId = user.Id;
                _context.Add(gemstone);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserId"] = new SelectList(_context.ApplicationUsers, "Id", "Id", viewModel.UserId);
            return View(viewModel);

            

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
        private Task<ApplicationUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);

    }
}
