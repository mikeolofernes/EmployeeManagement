using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Data.Models
{
    public class EmployeeMeals
    {

        #region Constructor
        public EmployeeMeals()
        {

        }
        #endregion

        #region Properties

        [Key]
        [Required]
        public int MealId { get; set; }

        public Int64 EmployeeId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime PremiseEntryDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime StartCanteenMeal { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ExitDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime LastCanteenMeal { get; set; }
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
