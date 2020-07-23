using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Data.Models
{
    public class Sites
    {

        #region Constructor
        public Sites()
        {

        }
        #endregion

        #region Properties

        [Key]
        [Required]
        public int SiteId { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string SiteCode { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        public string SiteDescription { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string SiteStatus { get; set; }
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
