using DbFrist.Data;
using Microsoft.EntityFrameworkCore;

namespace DbFrist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using dbfrist dbContext = new dbfrist();
    
            #region Excute select statement
            // 1. Excute select statement : FromSql[row , FromSqlInterpolated

            // FromSqlRow
            int count = 3;

            var categories = dbContext.Categories.FromSqlRaw("select * from categories");

            // categories = dbContext.Categories.FronSqlRaw("select top((8))* from categories",count);

            // FromSqlInterpolated
            categories = dbContext.Categories.FromSqlInterpolated($"select * from categories");
            categories = dbContext.Categories.FromSqlInterpolated($"select top(fcount)) * from categories");


            #endregion
            #region Execute DML 
            // 2. Execute DML Statement [Insert , update , delete]
            // ExecuteSqlRow
            var Result = dbContext.Database.ExecuteSqlRaw("update categories\r\nset CategoryName = 'Hamada'\r\nwhere CategoryID=6");
            var result = dbContext.Database .ExecuteSqlInterpolated($"update categories\t\nset CategoryName = 'Hanada'\t\nnherp CategoryID = 7");


            Console.WriteLine(Result);
            #endregion

            //var Categories = context.Categories.ToList();

            //foreach (var item in Categories) {
            //    Console.WriteLine(item.CategoryName);
            //}

            #region stored procdure
            //NorthwindContextProcedures procedures = new NorthwindContextProcedures(dbContext);

            //var Products = procedures.SalesByCategoryAsync("Seafood", "1998").Result;

            //foreach (var item in Products)
            //{
            //    Console.WriteLine($"{item.ProductName} :: {item.TotalPurchase}'");
            //    Console.WriteLine(item);
            //}
            #endregion


        }
    }
}
