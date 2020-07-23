using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EmployeeManagementSystem.Data.Models;

namespace EmployeeManagement.Controllers
{
    public class LocationsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LocationsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Locations
        public async Task<IActionResult> Index()
        {
            return View(await _context.Locations.ToListAsync());
        }

       
        public IActionResult AddOrEdit(int id = 0)
        {
            if (id == 0)
                return View(new Locations());
            else
                return View(_context.Locations.Find(id));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit([Bind("LocationId,LocationCode,LocationDescription,LocationStatus,CreatedBy,UpdatedBy,CreatedDate,UpdateDate")] Locations locations)
        {
            if (ModelState.IsValid)
            {
                if (locations.LocationId == 0)
                    _context.Add(locations);
                else
                    _context.Update(locations);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(locations);
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var locations = await _context.Locations
                .FirstOrDefaultAsync(m => m.LocationId == id);
            if (locations == null)
            {
                return NotFound();
            }

            return View(locations);
        }

        // POST: Locations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var locations = await _context.Locations.FindAsync(id);
            _context.Locations.Remove(locations);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LocationsExists(int id)
        {
            return _context.Locations.Any(e => e.LocationId == id);
        }
    }
}
