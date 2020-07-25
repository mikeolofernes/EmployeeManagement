using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EmployeeManagementSystem.Data.Models;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Policy;

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
            var tmpEmployee = (from emp in _context.EmployeeInfo
                               join sites in _context.Sites on emp.SiteId equals sites.SiteId into tmpSites
                               from tblSites in tmpSites.DefaultIfEmpty()
                               join localtion in _context.Locations on emp.LocationId equals localtion.LocationId into tmpLoc
                               from tblLocation in tmpLoc.DefaultIfEmpty()

                               select new EmployeeInfo
                               {
                                   EmployeeId = emp.EmployeeId,
                                   EmployeeNumber = emp.EmployeeNumber,
                                   QrCode = emp.QrCode,
                                   EmploymentDate = emp.EmploymentDate,
                                   LocationId = emp.LocationId,
                                   SiteId = emp.SiteId,
                                   CustomerId = emp.CustomerId,
                                   EmployeeStatus = emp.EmployeeStatus,
                                   EmployeeCategory = emp.EmployeeCategory,
                                   LastName = emp.LastName,
                                   FirstName = emp.FirstName,
                                   MiddleName = emp.MiddleName,
                                   ChineseName = emp.ChineseName,
                                   Alias = emp.Alias,
                                   PHAddress = emp.PHAddress,
                                   DomicileAddress = emp.DomicileAddress,
                                   BirthDate = emp.BirthDate,
                                   BirthPlace = emp.BirthPlace,
                                   EducationalAttainment = emp.EducationalAttainment,
                                   Height = emp.Height,
                                   Weight = emp.Weight,
                                   Gender = emp.Gender,
                                   CivilStatus = emp.CivilStatus,
                                   SpouseLastName = emp.SpouseLastName,
                                   SpouseFirstName = emp.SpouseFirstName,
                                   SpouseMidName = emp.SpouseMidName,
                                   SpouseBirthDate = emp.SpouseBirthDate,
                                   SpouseAddress = emp.SpouseAddress,
                                   SpouseOccupation = emp.SpouseOccupation,
                                   SpouseBirthPlace = emp.SpouseBirthPlace,
                                   Religion = emp.Religion,
                                   Nationality = emp.Nationality,
                                   CountryCode = emp.CountryCode,
                                   EmailAdd = emp.EmailAdd,
                                   MobileNumber = emp.MobileNumber,
                                   PersonalIdNumber = emp.PersonalIdNumber,
                                   RFIDNumber = emp.RFIDNumber,
                                   TinNumber = emp.TinNumber,
                                   SSSNumber = emp.SSSNumber,
                                   EmployeePicturePath = emp.EmployeePicturePath,
                                   SignaturePath = emp.SignaturePath,
                                   RightThumbPrintPath = emp.RightThumbPrintPath,
                                   LeftThumbPrintPath = emp.LeftThumbPrintPath,
                                   DateResigned = emp.DateResigned,
                                   ExitDate = emp.ExitDate,
                                   FatherLastName = emp.FatherLastName,
                                   FatherFirstName = emp.FatherFirstName,
                                   FatherMidName = emp.FatherMidName,
                                   MotherLastName = emp.MotherLastName,
                                   MotherFirstName = emp.MotherFirstName,
                                   MotherMidName = emp.MotherMidName,
                                   CreatedBy = emp.CreatedBy,
                                   UpdatedBy = emp.UpdatedBy,
                                   CreatedDate = emp.CreatedDate,
                                   UpdateDate = emp.UpdateDate,

                                   SiteName = tblSites.SiteDescription,
                                   LocationName = tblLocation.LocationDescription
                               }
           ).ToListAsync();

            return View(await tmpEmployee);
        }

        public IActionResult AddOrEdit(Int64 id = 0)
        {
            if (id == 0)
                return View(new EmployeeInfo());
            else
                return View(_context.EmployeeInfo.Find(id));
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
