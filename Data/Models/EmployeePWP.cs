using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Data.Models
{
    public class EmployeePWP
    {

        #region Constructor
        public EmployeePWP()
        {

        }
        #endregion

        #region Properties

        [Key]
        [Required]
        public int PWPId { get; set; }

        public Int64 EmployeeId { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string PWPType { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string PWPStatus { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime PWPAppliedDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime PWPCancelledDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime PWPExpiryDate { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string AEPNumber { get; set; }
        public string AEPImage { get; set; }
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
