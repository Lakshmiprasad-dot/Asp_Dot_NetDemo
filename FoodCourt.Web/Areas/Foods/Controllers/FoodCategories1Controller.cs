using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FoodCourt.Web.Data;
using FoodCourt.Web.Models;

namespace FoodCourt.Web.Areas.Foods.Controllers
{
    [Area("Foods")]
    public class FoodCategories1Controller : Controller
    {
        private readonly ApplicationDbContext _context;

        public FoodCategories1Controller(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Foods/FoodCategories1
        public async Task<IActionResult> Index()
        {
            return View(await _context.FoodCategories.ToListAsync());
        }

        // GET: Foods/FoodCategories1/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var foodCategory = await _context.FoodCategories
                .FirstOrDefaultAsync(m => m.FoodCategoryId == id);
            if (foodCategory == null)
            {
                return NotFound();
            }

            return View(foodCategory);
        }

        // GET: Foods/FoodCategories1/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Foods/FoodCategories1/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FoodCategoryId,FoodCategoryName")] FoodCategory foodCategory)
        {
            if (ModelState.IsValid)
            {
                // Check for Duplicates
                bool isFound = _context.FoodCategories.Any(c => c.FoodCategoryName == foodCategory.FoodCategoryName);
                if (isFound)
                {
                    ModelState.AddModelError("FoodCategoryName", "Duplicate Category Found!");
                }
                else
                {
                    _context.Add(foodCategory);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }
            return View(foodCategory);
        }

        // GET: Foods/FoodCategories1/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var foodCategory = await _context.FoodCategories.FindAsync(id);
            if (foodCategory == null)
            {
                return NotFound();
            }
            return View(foodCategory);
        }

        // POST: Foods/FoodCategories1/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FoodCategoryId,FoodCategoryName")] FoodCategory foodCategory)
        {
            if (id != foodCategory.FoodCategoryId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                // Check for duplicates (against all the remaining records)
                bool isFound = await _context.FoodCategories
                    .AnyAsync(c => c.FoodCategoryId != foodCategory.FoodCategoryId
                                   && c.FoodCategoryName == foodCategory.FoodCategoryName);
                if (isFound)
                {
                    ModelState.AddModelError("FoodCategoryName", "Duplicate Category Found!");
                }
                else
                {
                    try
                    {
                        _context.Update(foodCategory);
                        await _context.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!FoodCategoryExists(foodCategory.FoodCategoryId))
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
            }
            return View(foodCategory);
        }

        // GET: Foods/FoodCategories1/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var foodCategory = await _context.FoodCategories
                .FirstOrDefaultAsync(m => m.FoodCategoryId == id);
            if (foodCategory == null)
            {
                return NotFound();
            }

            return View(foodCategory);
        }

        // POST: Foods/FoodCategories1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var foodCategory = await _context.FoodCategories.FindAsync(id);
            _context.FoodCategories.Remove(foodCategory);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FoodCategoryExists(int id)
        {
            return _context.FoodCategories.Any(e => e.FoodCategoryId == id);
        }
    }
}
