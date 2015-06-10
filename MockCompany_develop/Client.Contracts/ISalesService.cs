using System.Collections.Generic;
using System.ServiceModel;
using Client.Entities;

namespace Client.Contracts
{
    [ServiceContract]
    public interface ISalesService
    {
        [OperationContract]
        IEnumerable<Product> GetProducts();
    }
}
