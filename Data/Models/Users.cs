using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Data.Models
{
    public class Users
    {
        #region Constructor
        public Users()
        {

        }
        #endregion

        #region Properties

        [Key]
        [Required]
        public int UserID { get; set; }
        public Int64 EmployeeId { get; set; }
        public int RoleID { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        public string Password { get; set; } 
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime UpdateDate { get; set; }
        #endregion

        #region Navigation Properties

        //public virtual TransactionTypes TransactionTypes { get; set; }
        #endregion
    }
}
