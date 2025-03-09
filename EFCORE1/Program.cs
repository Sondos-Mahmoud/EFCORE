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



            //CRUD OPERATIONSك
            #region Insert
            //Course c01 = new Course()
            //{
            //    Name = "C#",
            //    Description = "ay haga",
            //    Duration = "2m"
            //};
            //dbContext.Course.Add(c01);
            //dbContext.Entry(c01).State = EntityState.Added;
            //var student = new Student
            //{
            //    F_Name = "John",
            //    L_Name = "Doe",
            //    Address = "123 Main St",
            //    Age = 25
            //};
            //dbContext.Student.Add(student);
            //dbContext.Entry(student).State = EntityState.Added; 

            #endregion
            #region retrive
            var c = dbContext.Course.AsNoTracking().Where(c => c.Name == "C#").FirstOrDefault();
            //Console.WriteLine(c.Name??"null"); 
            #endregion
            #region modify
            if (c != null)
            {
                c.Name = "java";
            }
            #endregion
            #region deleted
            //if (c != null)
            //{
            //    dbContext.Course.Remove(c);
            //} 
            #endregion






            dbContext.SaveChanges();
        }
    }
}