using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Data.Models
{
    public class Employee9G
    {

        #region Constructor
        public Employee9G()
        {

        }
        #endregion

        #region Properties

        [Key]
        [Required]
        public int Employee9GId { get; set; }

        public Int64 EmployeeId { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string SSRNumber { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime IssuedDate9G { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ValidDate9G { get; set; }
        public DateTime CancelledDate9G { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string Status9G { get; set; }
        public string Image9G { get; set; }
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
