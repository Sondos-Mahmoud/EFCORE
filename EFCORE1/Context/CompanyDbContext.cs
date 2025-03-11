using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFCORE1.Entities;
using Microsoft.EntityFrameworkCore;
namespace EFCORE1.Context
{
    internal class CompanyDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server= . ; Database= Company; Trusted_Connection=True; Encrypt=False");
        }

        public DbSet<Student> Student { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<Instructor> Instructor { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<Topic> Topic { get; set; }
        public DbSet<StudCourse> StudCourse { get; set; }
        public DbSet<CourseInst> CourseInst { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure composite key for StudCourse
            modelBuilder.Entity<StudCourse>()
                .HasKey(sc => new { sc.Stud_ID, sc.Course_ID });

            // Configure composite key for CourseInst
            modelBuilder.Entity<CourseInst>()
                .HasKey(ci => new { ci.Inst_ID, ci.Course_ID });
        }
    }
}
