using LoanManagementLoanService.Interfaces;
using LoanManagementLoanService.Models;
using static LoanManagementLoanService.Interfaces.ILoanServices;

namespace LoanManagementLoanService.Services
{
    public class LoanService : ILoanServices
    {
        private readonly ILoanRepository _repository;

        public LoanService(ILoanRepository repository)
        {
            _repository = repository;
        }

        public Task<IEnumerable<LoanModel>> GetAllLoansAsync() 
        { 
            return _repository.GetAllAsync(); 
        }
        public Task<LoanModel> GetLoanByIdAsync(int id) 
        {  
            return _repository.GetByIdAsync(id); 
        }
        public Task<LoanModel> CreateLoanAsync(LoanModel loan) 
        { 
            return _repository.CreateAsync(loan); 
        }
        public Task UpdateLoanAsync(LoanModel loan) 
        {  
            return _repository.UpdateAsync(loan); 
        }
        public Task DeleteLoanAsync(int id) 
        { 
            return _repository.DeleteAsync(id); 
        }
    }

}
