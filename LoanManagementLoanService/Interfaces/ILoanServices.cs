using LoanManagementLoanService.Models;

namespace LoanManagementLoanService.Interfaces
{
    public interface ILoanServices
    {
        Task<IEnumerable<LoanModel>> GetAllLoansAsync();
        Task<LoanModel> GetLoanByIdAsync(int id);
        Task<LoanModel> CreateLoanAsync(LoanModel loan);
        Task UpdateLoanAsync(LoanModel loan);
        Task DeleteLoanAsync(int id);
    }
}
