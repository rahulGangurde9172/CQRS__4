using CQRS_4.Model.Entity;
using Microsoft.EntityFrameworkCore;
namespace CQRS_4.Data
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options)
        {
        }

        public DbSet<Employees> Employees { get; set; }
       
    }

}
