using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Channels;
using Client.Contracts;
using Client.Entities;

namespace Client.Sales.Proxies
{
    public class SalesClient:ClientBase<ISalesService>,ISalesService
    {
        public SalesClient()
        {
            
        }

        public SalesClient(string endpointName) : base(endpointName)
        {
            
        }

        public SalesClient(Binding binding, EndpointAddress address)
            : base(binding,address)
        {

        }

        public IEnumerable<Product> GetProducts()
        {
            return Channel.GetProducts();
        }
    }
}
