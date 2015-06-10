using System.Collections.Generic;
using Business.Contracts;
using Business.Entities;
using Data.Repository_Interfaces;

namespace Business.Managers
{
    public class SalesManager:ISalesService
    {
        private ISalesRepository _salesRepository = null;

        public SalesManager(ISalesRepository salesRepository)
        {
            _salesRepository = salesRepository;
        }

        public IEnumerable<Product> GetProducts()
        {
            return _salesRepository.GeProducts();
        }
    }
}
