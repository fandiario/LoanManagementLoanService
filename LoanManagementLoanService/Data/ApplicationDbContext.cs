using LoanManagementLoanService.Models;
using Microsoft.EntityFrameworkCore;


namespace LoanManagementLoanService.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<LoanModel> Loans { get; set; }
        public DbSet<LoanTypeModel> LoanTypes { get; set; }
    }

}
