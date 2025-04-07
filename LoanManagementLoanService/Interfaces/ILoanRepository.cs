using LoanManagementLoanService.Models;

namespace LoanManagementLoanService.Interfaces
{
    public interface ILoanRepository
    {
        Task<IEnumerable<LoanModel>> GetAllAsync();
        Task<LoanModel> GetByIdAsync(int id);
        Task<LoanModel> CreateAsync(LoanModel loan);
        Task UpdateAsync(LoanModel loan);
        Task DeleteAsync(int id);
    }
}
