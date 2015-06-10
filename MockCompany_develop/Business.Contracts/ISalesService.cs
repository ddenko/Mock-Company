using System.Collections.Generic;
using System.ServiceModel;
using Business.Entities;

namespace Business.Contracts
{
    [ServiceContract]
    public interface ISalesService
    {
        [OperationContract]
        IEnumerable<Product> GetProducts();
    }
}
