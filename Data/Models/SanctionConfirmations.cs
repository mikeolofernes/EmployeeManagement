using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Data.Models
{
    public class SanctionConfirmations
    {

        #region Constructor
        public SanctionConfirmations()
        {

        }
        #endregion

        #region Properties

        [Key]
        [Required]
        public int SanctionId { get; set; }

        public Int64 EmployeeId { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string PersonalId { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string Alias { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        public string PassportName { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        public string ChineseName { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string UnitNumber { get; set; }        
        public int SanctionTypeId { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal PenaltyAmount { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string Status { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string Remarks { get; set; }       
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime UpdateDate { get; set; }
        #endregion

        #region Navigation Properties

        //public virtual SanctionTypes SanctionTypes { get; set; }
        #endregion

    }
}
