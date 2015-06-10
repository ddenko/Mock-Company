using System;

namespace Business.Entities
{
    public class SalesOrderDetail
    {
        public SalesOrderDetail()
        {

        }

        public int SalesOrderID { get; set; }

        public int SalesOrderDetailId { get; set; }

        public string CarrierTrackingNumber { get; set; }

        public short OrderQty { get; set; }

        //public int ProductID { get; set; }
        public Product Product { get; set; }

        public int SpecialOfferID { get; set; }

        public decimal UnitPrice { get; set; }

        public decimal UnitPriceDiscount { get; set; }

        public decimal LineTotal { get; set; }

        public Guid rowguid { get; set; }

        public DateTime ModifiedDate { get; set; }

        public SalesOrderHeader SalesOrderHeader { get; set; }
    }
}
