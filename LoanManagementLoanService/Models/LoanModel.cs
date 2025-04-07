using System.ComponentModel.DataAnnotations.Schema;

namespace LoanManagementLoanService.Models
{
    [Table("MasterLoan")]
    public class LoanModel
    {
        public int Id { get; set; }
        public int NIKCustomer { get; set; }
        public int IdLoanType { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public DateTime LastUpdatedAt { get; set; }
        public int LastUpdatedBy { get; set; }
        public bool isActive { get; set; }
    }

}
