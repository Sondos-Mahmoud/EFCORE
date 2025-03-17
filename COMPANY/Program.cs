using Demo;
using COMPANY;

using Microsoft.EntityFrameworkCore;

namespace COMPANY
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1. Explicit loading
            //var employee = (from E in dbContext.EmpLoyees
            //                where E.EmpId == 1
            //                select E).FirstOrDefault();

            //dbContext.Entry(employee).Reference(nameof(employee.Department)).Load();

            //Console.WriteLine($"EmpName : {Employee?.Name} , DeptName : {Employee?.Departments}");


            //var department = (from D in dbContext.Departments
            //                  where D.DepartmentId == 4
            //                  select D).FirstOrDefault();
            //dbContext.Entry(department).Collection(nameof(department.employee.Department)).Load();


            //Console.WriteLine($"DeptName : {department?.Name}");

            //foreach (var emp in department?.Employees)
            //{
            //    Console.WriteLine($"EmpName : {emp.Name}");
            //}
            #endregion

            #region 2. Eager loading
            //var employee = (from E in dbContext.EmpLoyees.Include(E => E.Department)
            //                where E.EmpId == 1
            //                select E).FirstOrDefault();

            //Console.WriteLine($"EmpName : {employee?.Name}, DeptName : {employee?.Department?.Name}");
            //var department = (from D in dbContext.Departments
            //                  where D.DepartmentId == 4
            //                  select D).FirstOrDefault();
            //dbContext.Entry(department).Collection(nameof(department.employee.Department)).Include(E => E.Employees);


            //Console.WriteLine($"DeptName : {department?.Name}");

            //foreach (var emp in department?.Employees)
            //{
            //    Console.WriteLine($"EmpName : {emp.Name}");
            //}

            #endregion

            #region tracking
            //var employee = (from E in dbContext.Employees
            //                where E.EmpId == 2
            //                select E).AsNoTracking().FirstOrDefault();

            //Console.WriteLine(dbContext.Entry(employee).State);

            //employee.Name = "hamadaaa";
            //Console.WriteLine(dbContext.Entry(employee).State);

            //dbContext.Attach(employee);
            //dbContext.Entry(employee).State = EntityState.Modified;

            //dbContext.SaveChanges(); 
            #endregion
        }
    }
}
