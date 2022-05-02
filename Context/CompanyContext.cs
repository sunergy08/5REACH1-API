namespace _5REACH1_API.Context
{
    using Microsoft.EntityFrameworkCore;
    using _5REACH1_API.Models;
    using _5REACH1_API.Models.WebApiCoreWithEF.Models;

    public class CompanyContext
        : DbContext
    {
        public CompanyContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
    }
}
