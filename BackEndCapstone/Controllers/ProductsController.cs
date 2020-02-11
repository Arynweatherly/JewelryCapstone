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
using Microsoft.AspNetCore.Authorization;
using BackEndCapstone.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace BackEndCapstone.Controllers
{
    [Authorize]
    public class ProductsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;


        public ProductsController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Products
        public async Task<IActionResult> Index(string searchString) 

        {
            var user = await GetCurrentUserAsync();
            if (searchString == null)
            {
                var model = _context.Product
                    .Include(p => p.ProductType)
                    .Include(prop => prop.User);
                return View(await model.ToListAsync());
            }
            else
            {
                var model = _context.Product
                    .Include(p => p.ProductType)
                    .Include(p => p.User)
                        .Where(p => p.Title.Contains(searchString) || p.ProductType.Category.Contains(searchString) );
                return View(await model.ToListAsync());
            }
         
        }

        // GET: Products/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Product
                   .Include(p => p.ProductType)
                   .Include(p => p.ProductReviews)
                   .Include(p => p.ProductGemstones)
                   .ThenInclude(pg => pg.Gemstone)


                .FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: Products/Create
        public async Task<IActionResult> Create()
        {
            var viewModel = new ProductCreateViewModel();
            var user = await GetCurrentUserAsync();
            ViewData["ProductTypeId"] = new SelectList(_context.ProductType, "ProductTypeId", "Category");
            ViewData["Gemstone"] = new SelectList(_context.Gemstone, "Id", "Title");
            ViewData["ProductGemstone"] = new SelectList(_context.ProductGemstone, "GemstoneId", "Title");



            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,ImagePath,GemstoneIds,Description,DateAdded,UserId,ProductTypeId,File")] ProductCreateViewModel viewModel, IFormFile image)
        {
            ModelState.Remove("User");
            ModelState.Remove("UserId");
            var user = await GetCurrentUserAsync();
            if (ModelState.IsValid)
            {
                var product = new Product()
                {
                    Title = viewModel.Title,
                    ProductTypeId = viewModel.ProductTypeId,
                    Description = viewModel.Description,
                    ProductGemstones = viewModel.ProductGemstones


                };
                if (viewModel.File != null && viewModel.File.Length > 0)
                {
                    var fileName = Path.GetFileName(viewModel.File.FileName); //getting path of actual file name
                    var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images", fileName); //creating path combining file name w/ www.root\\images directory
                    using (var fileSteam = new FileStream(filePath, FileMode.Create)) //using filestream to get the actual path 
                    {
                        await viewModel.File.CopyToAsync(fileSteam);
                    }
                    product.ImagePath = fileName;
                }
                product.UserId = user.Id;
                product.ProductGemstones = viewModel.GemstoneIds.Select(gemstoneId => new ProductGemstone
                {
                    ProductId = product.Id,
                    GemstoneId = gemstoneId
                }).ToList();
                foreach(var gem in product.ProductGemstones)
                {
                    _context.Add(gem);
                }
                _context.Add(product);
                await _context.SaveChangesAsync();
         
                return RedirectToAction(nameof(Index));
            }

            ViewData["ProductTypeId"] = new SelectList(_context.ProductType, "ProductTypeId", "Category", viewModel.ProductTypeId);
            ViewData["ProductGemstone"] = new SelectList(_context.ProductGemstone, "GemstoneId", "Title", viewModel.ProductGemstones);

            ViewData["UserId"] = new SelectList(_context.ApplicationUsers, "Id", "Id", viewModel.UserId);
            return View(viewModel);


        }

        // GET: Products/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Product.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            ViewData["ProductTypeId"] = new SelectList(_context.ProductType, "ProductTypeId", "Category", product.ProductTypeId);
            return View(product);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,ImagePath,Description,DateAdded,UserId,ProductTypeId,File")] Product product, IFormFile file)
        {
            if (id != product.Id)
            {
                return NotFound();
            }
            ModelState.Remove("User");
            ModelState.Remove("UserId");

            if (ModelState.IsValid)
            {
                var user = await GetCurrentUserAsync();
                try
                {
                    if (product.File != null && product.File.Length > 0)
                    {
                        var fileName = Path.GetFileName(product.File.FileName);
                        var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images", fileName);
                        using (var fileSteam = new FileStream(filePath, FileMode.Create)) //using filestream to get the actual path 
                        {
                            await product.File.CopyToAsync(fileSteam);
                        }
                        product.ImagePath = fileName;
                    }
                    else
                    {
                        product.ImagePath = _context.Product.AsNoTracking().Single<Product>(p => p.Id == product.Id).ImagePath;
                    }
                    product.UserId = user.Id;
                    _context.Update(product);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.Id))
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
            ViewData["ProductTypeId"] = new SelectList(_context.ProductType, "ProductTypeId", "Category", product.ProductTypeId);
            ViewData["UserId"] = new SelectList(_context.ApplicationUsers, "Id", "Id", product.UserId);
            return View(product);
        }

        // GET: Products/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Product
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await _context.Product.FindAsync(id);
            _context.Product.Remove(product);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(int id)
        {
            return _context.Product.Any(e => e.Id == id);
        }
        private Task<ApplicationUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);

    }
}
