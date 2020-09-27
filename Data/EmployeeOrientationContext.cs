using Microsoft.EntityFrameworkCore;
using EmployeeOrientation.Models;

namespace EmployeeOrientation.Data
{
    public class EmployeeOrientationContext : DbContext
    {
        public EmployeeOrientationContext(DbContextOptions<EmployeeOrientationContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employee { get; set; }
    }
}
