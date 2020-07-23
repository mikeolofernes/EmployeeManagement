using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace EmployeeManagementSystem.Data.Models
{
    public class Locations
    {

        #region Constructor
        public Locations()
        {

        }
        #endregion

        #region Properties

        [Key]
        [Required]
        public int LocationId { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string LocationCode { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        public string LocationDescription { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string LocationStatus { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime UpdateDate { get; set; }
        #endregion

        #region Navigation Properties

        //public virtual Sites Sites { get; set; }
        #endregion

    }
}
