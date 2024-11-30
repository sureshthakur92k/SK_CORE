using Microsoft.EntityFrameworkCore;

namespace SK_CORE.Models
{
    public class EmployeeDBContext :DbContext
    {
        public EmployeeDBContext(DbContextOptions options):base(options)
        {
            
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Employee1> Employees1 { get; set; }
    }
}
