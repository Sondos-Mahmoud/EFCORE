using Demo;
using COMPANY;

using Microsoft.EntityFrameworkCore;


namespace COMPANY
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using CompanyDbContext dbContext = new CompanyDbContext();
            #region 1. Explicit loading
            //var employee = (from E in dbContext.Employees
            //                where E.EmpId == 1
            //                select E).FirstOrDefault();

            //dbContext.Entry(employee).Reference(nameof(employee.Department)).Load();

            //Console.WriteLine($"EmpName : {employee?.Name} , DeptName : {employee?.Departments}");


            //var department = (from D in dbContext.Departments
            //                  where D.Dept_ID == 4
            //                  select D).FirstOrDefault();
            //dbContext.Entry(department).Collection(nameof(department.Employees)).Load();


            //Console.WriteLine($"DeptName : {department?.Name}");

            //foreach (var emp in department?.Employees)
            //{
            //    Console.WriteLine($"EmpName : {emp.Name}");
            //}
            #endregion

            #region 2. Eager loading
            //var employee = (from E in dbContext.Employees.Include(E => E.Department)
            //                where E.EmpId == 1
            //                select E).FirstOrDefault();

            //Console.WriteLine($"EmpName : {employee?.Name}, DeptName : {employee?.Department?.Name}");
            //var department = (from D in dbContext.Departments
            //                  where D.Dept_ID == 4
            //                  select D).FirstOrDefault();
            //dbContext.Entry(department).Collection(nameof(department.Employees)).Include(E => E.Employees);


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

            #region view
            //foreach (var item in DbContext.EmployeeDepartment)
            //{
            //    Console.WriteLine($"Employee: {item.EmpName}, Department: {item.DeptName}");
            //}
            #endregion
            #region Join [Inner join]
            // 1. Query syntax
            var Result = from E in dbContext.Employees
                                    join D in dbContext.Departments
                                    on E.DepartmentId equals D.Dept_ID
                                    where E.Salary >= 5000
                                    select new
                                    {
                                        EmpName = E.Name,
                                        DeptName = D.Name
                                    };
            // 2. Fluent syntax
            var fluentSyntaxResult = dbContext.Employees
                .Join(dbContext.Departments,
                      E => E.DepartmentId,
                      D => D.Dept_ID,
                      (E, D) => new {
                          EmpName = E.Name,
                          DeptName = D.Name,
                          Salary = E.Salary
                      })
                .Where(A => A.Salary >= 5000);
            foreach (var item in Result)
            {
                Console.WriteLine($"Employee: {item.EmpName}, Department: {item.DeptName}");
            }

            #endregion
            #region GroupJoin
                    var result = dbContext.Departments
            .GroupJoin(
                dbContext.Employees,
                D => D.Dept_ID,
                E => E.DepartmentId,
                (D, Employees) => new
                {
                    Department = D,
                    Employees = Employees.DefaultIfEmpty()
                });

                    var result04 = from D in dbContext.Departments
                                 join E in dbContext.Employees
                                 on D.Dept_ID equals E.DepartmentId into Groups
                                 select new
                                 {
                                     Department = D,
                                     Employees = Groups.DefaultIfEmpty() // Ensures a left outer join
                                 };

                    foreach (var item in result)
                    {
                        Console.WriteLine($"DeptName = {item.Department.Name}");
                        Console.WriteLine("**********************");
                        foreach (var employee in item.Employees)
                        {
                    
                                Console.WriteLine($"Employee: {employee.Name}");
                    
                        }
                        Console.WriteLine();
                    }

            #endregion
            #region Example 02
            var result05 = dbContext.Departments
                .GroupJoin(
                    dbContext.Employees,
                    D => D.Dept_ID,
                    E => E.DepartmentId,
                    (Department, Employees) => new
                    {
                        Department = Department,
                        Employees = Employees
                    })
                .Where(A => A.Employees.Count() > 1);

            foreach (var item in result05)
            {
                Console.WriteLine($"Department: {item.Department.Name}");
                Console.WriteLine("**********************");
                foreach (var employee in item.Employees)
                {
                    Console.WriteLine($"Employee: {employee.Name}");
                }
                Console.WriteLine();
            }
            #endregion
            #region Group Join [Right outer join]

            //var Result07 = dbContext.Employees.GroupJoin(dbContext.Departments, E => E.DepartmentId, D => D.Dept_ID,
            //    (E, D) => new
            //    {
            //        Department = D,
            //        Employees = E
            //    });


            //    foreach (var item in Result07)
            //    {
            //    Console.WriteLine(item.Employees.Name);
            //        foreach (var item1 in item.Department)
            //        {
            //        Console.WriteLine(item1.Name);
            //        }
            //        }
            //    }
            #endregion
            #region Cross Join
            var Result08= from E in dbContext.Employees
                         from D in dbContext.Departments
                         select new
                         {
                             E.Name,
                             deptName = D.Name,
                         };
        

          var Result10 = dbContext.Employees.SelectMany(E => dbContext.Departments.Select(D => new
                {
                E.Name,
                deptName = D.Name
                }));


foreach (var item in Result08)
{
    Console.WriteLine(item);
}
#endregion


        }
    }
}
