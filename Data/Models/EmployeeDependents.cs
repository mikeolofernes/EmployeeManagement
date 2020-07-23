using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
namespace EmployeeManagementSystem.Data.Models
{
    public class EmployeeDependents
    {

        #region Constructor
        public EmployeeDependents()
        {

        }
        #endregion

        #region Properties

        [Key]
        [Required]
        public int DependentId { get; set; }

        public Int64 EmployeeId { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string LastName { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string FirstName { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string MiddleName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime BirthDate { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string Relationship { get; set; }
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
