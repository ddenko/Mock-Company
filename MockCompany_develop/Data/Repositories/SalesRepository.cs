using System.Collections.Generic;
using System.Linq;
using Business.Entities;
using Data.Repository_Interfaces;

namespace Data.Repositories
{
    public class SalesRepository:ISalesRepository
    {
        public IEnumerable<Product> GeProducts()
        {
            using (CompanyDbContext entityContext = new CompanyDbContext())
            {
                return entityContext.Products.Take(100).ToList();
            }
        }
    }
}
