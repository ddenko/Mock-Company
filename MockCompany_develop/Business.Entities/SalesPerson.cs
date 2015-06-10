using System;
using System.Collections.Generic;

namespace Business.Entities
{
    public class SalesPerson
    {
        public SalesPerson()
        {

        }

        public int SalesPersonId { get; set; }

        public int? TerritoryID { get; set; }

        public decimal? SalesQuota { get; set; }

        public decimal Bonus { get; set; }

        public decimal CommissionPct { get; set; }

        public decimal SalesYTD { get; set; }

        public decimal SalesLastYear { get; set; }

        public Guid rowguid { get; set; }

        public DateTime ModifiedDate { get; set; }

        public ICollection<SalesOrderHeader> SalesOrderHeaders { get; set; }
    }
}
