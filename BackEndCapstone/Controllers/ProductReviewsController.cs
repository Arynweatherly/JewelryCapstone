﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BackEndCapstone.Data;
using BackEndCapstone.Models;
using Microsoft.AspNetCore.Identity;

namespace BackEndCapstone.Controllers
{
    public class ProductReviewsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        public ProductReviewsController(ApplicationDbContext context)

        {
            _context = context;
            

        }

        // GET: ProductReviews
        public async Task<IActionResult> Index()
        {
            var model = _context.ProductReview
                .Include(pr => pr.Product);
            return View(await _context.ProductReview.ToListAsync());
        }

        // GET: ProductReviews/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productReview = await _context.ProductReview
                .Include(pr => pr.Product)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (productReview == null)
            {
                return NotFound();
            }

            return View(productReview);
        }

        // GET: ProductReviews/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ProductReviews/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UserId,ProductId,Comment,DateAdded")] ProductReview productReview)
        {
            if (ModelState.IsValid)
            {
                _context.Add(productReview);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(productReview);
        }

        // GET: ProductReviews/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productReview = await _context.ProductReview.FindAsync(id);
            if (productReview == null)
            {
                return NotFound();
            }
            return View(productReview);
        }

        // POST: ProductReviews/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,UserId,ProductId,Comment,DateAdded")] ProductReview productReview)
        {
            if (id != productReview.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(productReview);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductReviewExists(productReview.Id))
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
            return View(productReview);
        }

        // GET: ProductReviews/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productReview = await _context.ProductReview
                .FirstOrDefaultAsync(m => m.Id == id);
            if (productReview == null)
            {
                return NotFound();
            }

            return View(productReview);
        }

        // POST: ProductReviews/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var productReview = await _context.ProductReview.FindAsync(id);
            _context.ProductReview.Remove(productReview);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductReviewExists(int id)
        {
            return _context.ProductReview.Any(e => e.Id == id);
        }
    }
}
