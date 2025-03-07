using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo;
using Microsoft.EntityFrameworkCore;

namespace COMPANY 
{
    class CompanyDbCOntext : DbContext
    {
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server= . ; Database= Company; Trusted_Connection=True; Encrypt=False");

    }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Employee>()
                .Property(e => e.Address)
                .HasDefaultValue("Cairo");

            //modelBuilder.Entity<Department>(d =>
            //{
            //    d.ToTable("Departments", "Sales"); 
            //    d.HasKey(d => d.DepthId); 
            //    d.Property(d => d.DepthId)
            //        .UseIdentityColumn(10, 10);
            //});
        }
    }
}
