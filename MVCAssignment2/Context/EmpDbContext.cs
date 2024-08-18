using Microsoft.EntityFrameworkCore;
using MVCAssignment2.Models;

namespace MVCAssignment2.Context
{
    public class EmpDbContext : DbContext
    {
        public EmpDbContext(DbContextOptions<EmpDbContext> options)
        : base(options) { }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
