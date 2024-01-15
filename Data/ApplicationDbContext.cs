using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using EmployeeAndDepartment.Models;

namespace EmployeeAndDepartment.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Employee> Employee { get; set; } = default!;
        public DbSet<Department> Department { get; set; } = default!;
        public DbSet<EmployeeDepartment> EmployeeDepartment { get; set; } = default!;

    }
}
