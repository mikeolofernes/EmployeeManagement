using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Data.Models
{
    public class HomeLeaves
    {

        #region Constructor
        public HomeLeaves()
        {

        }
        #endregion

        #region Properties

        [Key]
        [Required]
        public int HomeLeaveId { get; set; }

        public Int64 EmployeeId { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string PersonalIdNo { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string Alias { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        public string PassportName { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        public string ChineseName { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string UnitNumber { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime StartDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime EndDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime LastDayInOffice { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FirstDayBack { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime UpdateDate { get; set; }
        #endregion

        #region Navigation Properties

        //public virtual EmployeeInfo EmployeeInfo { get; set; }
        #endregion

    }
}
