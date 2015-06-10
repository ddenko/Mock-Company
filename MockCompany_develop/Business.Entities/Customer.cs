using System;
using System.Collections.Generic;

namespace Business.Entities
{
    public class Customer
    {
        public Customer()
        {

        }

        public int CustomerId { get; set; }

        public int? PersonID { get; set; }

        public int? StoreID { get; set; }

        public int? TerritoryID { get; set; }

        public string AccountNumber { get; set; }

        public Guid rowguid { get; set; }

        public DateTime ModifiedDate { get; set; }

        public ICollection<SalesOrderHeader> SalesOrderHeaders { get; set; }
    }
}
