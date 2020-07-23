using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Data.Models
{
    public class EmployeeInfo
    {

        #region Constructor
        public EmployeeInfo()
        {

        }
        #endregion

        #region Properties

        [Key]
        [Required]
        public Int64 EmployeeId { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string EmployeeNumber { get; set; }
        public string QrCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime EmploymentDate { get; set; }
        public int LocationId { get; set; }
        public int SiteId { get; set; }
        public int CustomerId { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string EmployeeStatus { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string EmployeeCategory{ get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string LastName { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string FirstName { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string MiddleName { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        public string ChineseName { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string Alias { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        public string PHAddress { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        public string DomicileAddress { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime BirthDate { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string BirthPlace { get; set; }
        [Column(TypeName = "nvarchar(150)")]
        public string EducationalAttainment { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string Height { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string Weight { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string Gender { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string CivilStatus { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string SpouseLastName { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string SpouseFirstName { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string SpouseMidName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime SpouseBirthDate { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        public string SpouseAddress { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string SpouseOccupation { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string SpouseBirthPlace { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string Religion { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string Nationality { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string CountryCode { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string EmailAdd { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string MobileNumber { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string PersonalIdNumber { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string RFIDNumber { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string TinNumber { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string SSSNumber { get; set; }
        public string EmployeePicturePath { get; set; }
        public string SignaturePath { get; set; }
        public string RightThumbPrintPath { get; set; }
        public string LeftThumbPrintPath { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateResigned { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ExitDate { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string FatherLastName { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string FatherFirstName { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string FatherMidName { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string MotherLastName { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string MotherFirstName { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string MotherMidName { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime UpdateDate { get; set; }
        #endregion

        #region Navigation Properties

        //public virtual List<EmployeePassport> EmployeePassport { get; set; }
        #endregion

    }
}
