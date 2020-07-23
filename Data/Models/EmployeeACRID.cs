using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Data.Models
{
    public class EmployeeACRID
    {

        #region Constructor
        public EmployeeACRID()
        {

        }
        #endregion

        #region Properties

        [Key]
        [Required]
        public int ACRId { get; set; }

        public Int64 EmployeeId { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string ACRNumber { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ACRIssuedDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ACRValidDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ACRCancelledDate { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string ACRStatus { get; set; }
        public string ACRImage { get; set; }
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
