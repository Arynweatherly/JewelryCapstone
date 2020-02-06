using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BackEndCapstone.Data;
using BackEndCapstone.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using BackEndCapstone.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace BackEndCapstone.Controllers
{
    [Authorize]
    public class TutorialsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        public TutorialsController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;

        }

        // GET: Tutorials
        public async Task<IActionResult> Index()
        {
            var user = await GetCurrentUserAsync();
            return View(await _context.Tutorial.ToListAsync());
        }

        // GET: Tutorials/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tutorial = await _context.Tutorial
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tutorial == null)
            {
                return NotFound();
            }

            return View(tutorial);
        }

        // GET: Tutorials/Create
        public async Task<IActionResult> CreateAsync()
        {
            var viewModel = new TutorialCreateViewModel();
            var user = await GetCurrentUserAsync();
            ViewData["UserId"] = new SelectList(_context.ApplicationUsers, "Id", "Id");
            return View(viewModel);
        }

        // POST: Tutorials/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,VideoPath,Description,DateAdded,ProductId, File")] TutorialCreateViewModel viewModel, IFormFile video)
        {
            ModelState.Remove("User");
            ModelState.Remove("UserId");
            var user = await GetCurrentUserAsync();
            if (ModelState.IsValid)
            {
                var tutorial = new Tutorial()
                {
                    Title = viewModel.Title,
                    Description = viewModel.Description,
                };
                if (viewModel.File != null && viewModel.File.Length > 0)
                {
                    var fileName = Path.GetFileName(viewModel.File.FileName); //getting path of actual file name
                    var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\videos", fileName); //creating path combining file name w/ www.root\\images directory
                    using (var fileSteam = new FileStream(filePath, FileMode.Create)) //using filestream to get the actual path 
                    {
                        await viewModel.File.CopyToAsync(fileSteam);
                    }
                    tutorial.VideoPath = fileName;
                }
                tutorial.UserId = user.Id;
                _context.Add(tutorial);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            ViewData["UserId"] = new SelectList(_context.ApplicationUsers, "Id", "Id", viewModel.UserId);
            return View(viewModel);

        }

        // GET: Tutorials/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tutorial = await _context.Tutorial.FindAsync(id);
            if (tutorial == null)
            {
                return NotFound();
            }
            return View(tutorial);
        }

        // POST: Tutorials/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,VideoPath,Description,DateAdded,ProductId")] Tutorial tutorial)
        {
            if (id != tutorial.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tutorial);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TutorialExists(tutorial.Id))
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
            return View(tutorial);
        }

        // GET: Tutorials/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tutorial = await _context.Tutorial
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tutorial == null)
            {
                return NotFound();
            }

            return View(tutorial);
        }

        // POST: Tutorials/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tutorial = await _context.Tutorial.FindAsync(id);
            _context.Tutorial.Remove(tutorial);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TutorialExists(int id)
        {
            return _context.Tutorial.Any(e => e.Id == id);
        }
        private Task<ApplicationUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);


    }

}
