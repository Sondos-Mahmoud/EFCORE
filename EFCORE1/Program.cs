using EFCORE1.Context;

namespace EFCORE1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CompanyDbContext dbContext = new CompanyDbContext();
            dbContext.Database.EnsureDeleted();
            dbContext.Database.EnsureCreated();


        }
    }
}