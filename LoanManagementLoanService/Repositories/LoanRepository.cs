using LoanManagementLoanService.Data;
using LoanManagementLoanService.Interfaces;
using LoanManagementLoanService.Models;
using Microsoft.EntityFrameworkCore;

namespace LoanManagementLoanService.Repositories
{
    public class LoanRepository : ILoanRepository
    {
        private readonly ApplicationDbContext _context;

        public LoanRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<LoanModel>> GetAllAsync() 
        {
            return  await _context.Loans.ToListAsync(); 
        }

        public async Task<LoanModel> GetByIdAsync(int id)
        {
           return await _context.Loans.FindAsync(id);
        }

        public async Task<LoanModel> CreateAsync(LoanModel loan)
        {
            _context.Loans.Add(loan);
            await _context.SaveChangesAsync();
            return loan;
        }

        public async Task UpdateAsync(LoanModel loan)
        {
            _context.Loans.Update(loan);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var loan = await _context.Loans.FindAsync(id);
            if (loan != null)
            {
                _context.Loans.Remove(loan);
                await _context.SaveChangesAsync();
            }
        }
    }

}
