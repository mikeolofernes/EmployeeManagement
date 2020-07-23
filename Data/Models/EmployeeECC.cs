using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Data.Models
{
    public class EmployeeECC
    {

        #region Constructor
        public EmployeeECC()
        {

        }
        #endregion

        #region Properties

        [Key]
        [Required]
        public int ECCId { get; set; }

        public Int64 EmployeeId { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string ApplicationInfo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ECCSentDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ECCValidDate { get; set; }       
        public string ECCImage { get; set; }
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
