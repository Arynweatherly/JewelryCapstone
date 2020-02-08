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

namespace BackEndCapstone.Controllers
{
    [Authorize]

    public class TutorialsReviewController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;


        public TutorialsReviewController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
             _userManager = userManager;

        }

        // GET: TutorialsReview
        public async Task<IActionResult> Index()
        {
            return View(await _context.TutorialReview.ToListAsync());
        }

        // GET: TutorialsReview/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tutorialReview = await _context.TutorialReview
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tutorialReview == null)
            {
                return NotFound();
            }

            return View(tutorialReview);
        }

        // GET: TutorialsReview/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TutorialsReview/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UserId,TutorialId,Comment,DateAdded")] TutorialReview tutorialReview)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tutorialReview);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tutorialReview);
        }

        // GET: TutorialsReview/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tutorialReview = await _context.TutorialReview.FindAsync(id);
            if (tutorialReview == null)
            {
                return NotFound();
            }
            return View(tutorialReview);
        }

        // POST: TutorialsReview/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,UserId,TutorialId,Comment,DateAdded")] TutorialReview tutorialReview)
        {
            if (id != tutorialReview.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tutorialReview);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TutorialReviewExists(tutorialReview.Id))
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
            return View(tutorialReview);
        }

        // GET: TutorialsReview/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tutorialReview = await _context.TutorialReview
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tutorialReview == null)
            {
                return NotFound();
            }

            return View(tutorialReview);
        }

        // POST: TutorialsReview/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tutorialReview = await _context.TutorialReview.FindAsync(id);
            _context.TutorialReview.Remove(tutorialReview);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TutorialReviewExists(int id)
        {
            return _context.TutorialReview.Any(e => e.Id == id);
        }
    }
}
