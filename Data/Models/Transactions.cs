using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Data.Models
{
    public class Transactions
    {

        #region Constructor
        public Transactions()
        {

        }
        #endregion

        #region Properties

        [Key]
        [Required]
        public int TransactionId { get; set; }
        public Int64 EmployeeId { get; set; }
        public string TransactionTypeId { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal TransactionAmount { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        public string Notes { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string Status { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime TransactionDate { get; set; }
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
