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
    public class EmployeeInfoesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EmployeeInfoesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: EmployeeInfoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.EmployeeInfo.ToListAsync());
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
        public async Task<IActionResult> AddOrEdit([Bind("EmployeeId,EmployeeNumber,QrCode,EmploymentDate,LocationId,SiteId,CustomerId,EmployeeStatus,EmployeeCategory,LastName,FirstName," +
            "MiddleName,ChineseName,Alias,PHAddress,DomicileAddress,BirthDate,BirthPlace,EducationalAttainment,Height,Weight,Gender,CivilStatus,SpouseLastName,SpouseFirstName,SpouseMidName," +
            "SpouseBirthDate,SpouseAddress,SpouseOccupation,SpouseBirthPlace,Religion,Nationality,CountryCode,EmailAdd,MobileNumber,PersonalIdNumber,RFIDNumber,TinNumber,SSSNumber," +
            "EmployeePicturePath,SignaturePath,RightThumbPrintPath,LeftThumbPrintPath,DateResigned,ExitDate,FatherLastName,FatherFirstName,FatherMidName,MotherLastName,MotherFirstName," +
            "MotherMidName,CreatedBy,UpdatedBy,CreatedDate,UpdateDate")] EmployeeInfo employeeInfo)
        {
            if (ModelState.IsValid)
            {
                if (employeeInfo.EmployeeId == 0)
                    _context.Add(employeeInfo);
                else
                    _context.Update(employeeInfo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(employeeInfo);
        }
        
        // GET: EmployeeInfoes/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employeeInfo = await _context.EmployeeInfo
                .FirstOrDefaultAsync(m => m.EmployeeId == id);
            if (employeeInfo == null)
            {
                return NotFound();
            }

            return View(employeeInfo);
        }

        // POST: EmployeeInfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var employeeInfo = await _context.EmployeeInfo.FindAsync(id);
            _context.EmployeeInfo.Remove(employeeInfo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmployeeInfoExists(long id)
        {
            return _context.EmployeeInfo.Any(e => e.EmployeeId == id);
        }
    }
}
