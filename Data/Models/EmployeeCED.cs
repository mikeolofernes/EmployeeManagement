using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Data.Models
{
    public class EmployeeCED
    {

        #region Constructor
        public EmployeeCED()
        {

        }
        #endregion

        #region Properties

        [Key]
        [Required]
        public int CEDId { get; set; }

        public Int64 EmployeeId { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string Position { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string NatureOfAssignment { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string PlaceOfAssignment { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string EmployerName { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        public string EmployerAddress { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string BusinessEmailAdd { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string PhoneNumber { get; set; }
        public string NatureOfBusiness { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ContractValidityDate { get; set; }
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
