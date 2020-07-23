using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Data.Models
{
    public class RFIDs
    {

        #region Constructor
        public RFIDs()
        {

        }
        #endregion

        #region Properties

        [Key]
        [Required]
        public int RFIDid { get; set; }

        public Int64 EmployeeId { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string PersonalId { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string Alias { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string CardNo { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string PrintedNo { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string FacilityCode { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string CardType { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string UserFlag { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ValidFrom { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ValidTo { get; set; }
        public string CardStatus { get; set; }
        public string GAG { get; set; }
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
