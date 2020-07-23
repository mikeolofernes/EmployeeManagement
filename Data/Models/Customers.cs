using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Data.Models
{
    public class Customers
    {

        #region Constructor
        public Customers()
        {

        }
        #endregion

        #region Properties

        [Key]
        [Required]
        public int CustomerId { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string CustomerCode { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string CustomerDescription { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string ContactPerson { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string ContactNumber { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string CustomerStatus { get; set; }

        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime UpdateDate { get; set; }
        #endregion

        #region Navigation Properties

        //public virtual List<Locations> Locations { get; set; }
        #endregion

    }
}
