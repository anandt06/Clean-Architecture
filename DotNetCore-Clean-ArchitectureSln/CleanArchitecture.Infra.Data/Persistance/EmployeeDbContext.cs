using CleanArchitecture.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Infra.Data.Context
{
    public class EmployeeDbContext : DbContext
    {

        //public EmployeeDbContext() : base("name = VasukiDbConnection")
        //{
        //    Database.SetInitializer<EmployeeDbContext>(new DbInitializer());
        //}

        public EmployeeDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Can add constraint, index, check, data type, and even data seed
        }

        public DbSet<Employee> Employees { get; set; }
    }
}