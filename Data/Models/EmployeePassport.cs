using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Data.Models
{
    public class EmployeePassport
    {

        #region Constructor
        public EmployeePassport()
        {

        }
        #endregion

        #region Properties

        [Key]
        [Required]
        public int PassportId { get; set; }

        public Int64 EmployeeId { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string PassportNumber { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ExpiryDate { get; set; }
        public string PlaceOfIssue { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime IssueDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime EntryDate { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string Status { get; set; }
        public string ImagePath { get; set; }
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
