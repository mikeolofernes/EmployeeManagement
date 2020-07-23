using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EmployeeManagementSystem;
using EmployeeManagementSystem.Data.Models;

namespace EmployeeManagement.Controllers
{
    public class SitesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SitesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Sites
        public async Task<IActionResult> Index()
        {
            return View(await _context.Sites.ToListAsync());
        }

        // GET: Sites/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sites = await _context.Sites
                .FirstOrDefaultAsync(m => m.SiteId == id);
            if (sites == null)
            {
                return NotFound();
            }

            return View(sites);
        }

        // GET: Sites/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Sites/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("SiteId,SiteCode,SiteDescription,SiteStatus,CreatedBy,UpdatedBy,CreatedDate,UpdateDate")] Sites sites)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(sites);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(sites);
        //}

        //// GET: Sites/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var sites = await _context.Sites.FindAsync(id);
        //    if (sites == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(sites);
        //}
        // GET: Employee/Create
        public IActionResult AddOrEdit(int id = 0)
        {
            if (id == 0)
                return View(new Sites());
            else
                return View(_context.Sites.Find(id));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit([Bind("SiteId,SiteCode,SiteDescription,SiteStatus,CreatedBy,UpdatedBy,CreatedDate,UpdateDate")] Sites sites)
        {
            if (ModelState.IsValid)
            {
                if (sites.SiteId == 0)
                    _context.Add(sites);
                else
                    _context.Update(sites);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sites);
        }
        // POST: Sites/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SiteId,SiteCode,SiteDescription,SiteStatus,CreatedBy,UpdatedBy,CreatedDate,UpdateDate")] Sites sites)
        {
            if (id != sites.SiteId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sites);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SitesExists(sites.SiteId))
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
            return View(sites);
        }

        // GET: Sites/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sites = await _context.Sites
                .FirstOrDefaultAsync(m => m.SiteId == id);
            if (sites == null)
            {
                return NotFound();
            }

            return View(sites);
        }

        // POST: Sites/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sites = await _context.Sites.FindAsync(id);
            _context.Sites.Remove(sites);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SitesExists(int id)
        {
            return _context.Sites.Any(e => e.SiteId == id);
        }
    }
}
