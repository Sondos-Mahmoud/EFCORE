using EFCORE1.Context;
using EFCORE1.Entities;
using Microsoft.EntityFrameworkCore;

namespace EFCORE1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using CompanyDbContext dbContext = new CompanyDbContext();

     

            Course c01 = new Course()
            {
                Name = "C#",
                Description ="ay haga",
                Duration="2m"
            };
            dbContext.Course.Add(c01);
            dbContext.Entry(c01).State = EntityState.Added;
         
            var student = new Student
            {
                F_Name = "John",
                L_Name = "Doe",
                Address = "123 Main St",
                Age = 25
            };
            dbContext.SaveChanges();
        }
    }
}