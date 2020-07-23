using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Data.Models
{
    public class EmployeeAEP
    {

        #region Constructor
        public EmployeeAEP()
        {

        }
        #endregion

        #region Properties

        [Key]
        [Required]
        public int AEPId { get; set; }

        public Int64 EmployeeId { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string AEPType { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string AEPStatus { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string Duration { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime AEPAppliedDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime AEPCancelledDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime AEPExpiryDate { get; set; }
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
