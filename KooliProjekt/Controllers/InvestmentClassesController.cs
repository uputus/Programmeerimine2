using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using KooliProjekt.Data;

namespace KooliProjekt.Controllers
{
    public class InvestmentClassesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public InvestmentClassesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: InvestmentClasses
        public async Task<IActionResult> Index()
        {
            return View(await _context.InvestmentClasses.ToListAsync());
        }

        // GET: InvestmentClasses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var investmentClass = await _context.InvestmentClasses
                .FirstOrDefaultAsync(m => m.ClassID == id);
            if (investmentClass == null)
            {
                return NotFound();
            }

            return View(investmentClass);
        }

        // GET: InvestmentClasses/Create
        public IActionResult Create()
        {
            // Andmete ettevalmistamine dropdown-iks
            ViewData["Assets"] = new SelectList(_context.Assets, "AssetID", "Name");
            ViewData["InvestmentClasses"] = new SelectList(_context.InvestmentClasses, "ClassID", "Name");

            return View();
        }

        // POST: InvestmentClasses/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ClassID,Name,Description")] InvestmentClass investmentClass)
        {
            if (ModelState.IsValid)
            {
                _context.Add(investmentClass);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(investmentClass);
        }

        // GET: InvestmentClasses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var investmentClass = await _context.InvestmentClasses.FindAsync(id);
            if (investmentClass == null)
            {
                return NotFound();
            }

            // Andmete ettevalmistamine dropdown-iks
            ViewData["Assets"] = new SelectList(_context.Assets, "AssetID", "Name");

          
            ViewData["InvestmentClasses"] = new SelectList(_context.InvestmentClasses, "ClassID", "Name");

            return View(investmentClass);
        }

        // POST: InvestmentClasses/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ClassID,Name,Description")] InvestmentClass investmentClass)
        {
            if (id != investmentClass.ClassID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(investmentClass);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InvestmentClassExists(investmentClass.ClassID))
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
            return View(investmentClass);
        }

        // GET: InvestmentClasses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var investmentClass = await _context.InvestmentClasses
                .FirstOrDefaultAsync(m => m.ClassID == id);
            if (investmentClass == null)
            {
                return NotFound();
            }

            return View(investmentClass);
        }

        // POST: InvestmentClasses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var investmentClass = await _context.InvestmentClasses.FindAsync(id);
            if (investmentClass != null)
            {
                _context.InvestmentClasses.Remove(investmentClass);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InvestmentClassExists(int id)
        {
            return _context.InvestmentClasses.Any(e => e.ClassID == id);
        }
    }
}
