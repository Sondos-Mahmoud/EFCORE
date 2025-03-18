using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo;
using Microsoft.EntityFrameworkCore;

namespace COMPANY
{
    class CompanyDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Server= . ; Database= Company2; Trusted_Connection=True; Encrypt=False");
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer("Server= . ; Database= Company2; Trusted_Connection=True; Encrypt=False");

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //// Configure Employee entity
            //modelBuilder.Entity<Employee>()
            //    .Property(e => e.Address)
            //    .HasDefaultValueSql("'Cairo'"); // Default value for Address

            //// Configure Department entity
            //modelBuilder.Entity<Department>(d =>
            //{
            //    d.ToTable("Departments", "Sales"); // Map to "Departments" table in "Sales" schema
            //    d.HasKey(d => d.DepthId); // Set primary key
            //    d.Property(d => d.DepthId)
            //        .UseIdentityColumn(10, 10); // Configure identity column
            //});
            modelBuilder.Entity<EmployeeDepartment>().ToView("EmployeeDepartmentView");
        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeDepartment> EmployeeDepartment { get; set; }

    }
}