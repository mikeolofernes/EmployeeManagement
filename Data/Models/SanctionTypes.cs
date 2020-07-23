using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Data.Models
{
    public class SanctionTypes
    {

        #region Constructor
        public SanctionTypes()
        {

        }
        #endregion

        #region Properties

        [Key]
        [Required]
        public int SanctionTypeId { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string SanctionType { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal PenaltyAmount { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        public string Description { get; set; }        
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
