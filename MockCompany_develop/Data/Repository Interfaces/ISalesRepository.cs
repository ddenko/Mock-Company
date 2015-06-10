using System.Collections.Generic;
using Business.Entities;

namespace Data.Repository_Interfaces
{
    public interface ISalesRepository
    {
        IEnumerable<Product> GeProducts();
    }
}
