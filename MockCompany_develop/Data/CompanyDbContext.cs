using System.Data.Entity;
using Business.Entities;

namespace Data
{
    class CompanyDbContext:DbContext
    {
        public CompanyDbContext(): base("MockCompany")
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<SalesOrderDetail> SalesOrderDetails { get; set; }
        public DbSet<SalesOrderHeader> SalesOrderHeaders { get; set; }
        public DbSet<SalesPerson> SalesPersons { get; set; }
    }
}
