using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Contracts;
using Business.Entities;

namespace Business.Managers
{
    public class SalesManager:ISalesService
    {
        public IEnumerable<Product> GetProducts()
        {
            throw new NotImplementedException();
        }
    }
}
