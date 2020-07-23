using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
namespace EmployeeManagementSystem.Data.Models
{
    public class EmployeeVisa
    {

        #region Constructor
        public EmployeeVisa()
        {

        }
        #endregion

        #region Properties

        [Key]
        [Required]
        public int VisaId { get; set; }

        public Int64 EmployeeId { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string LandedVisaType { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime LandedVisaExpiry { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string LandedVisaNumber { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string UpgradedVisaType { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string UpgradedVisaNumber { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime NewExpiryDate { get; set; }
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
