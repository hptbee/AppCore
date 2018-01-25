using System;
using System.Collections.Generic;

namespace AppCore.Entity.Models
{
    public partial class SaleOrders
    {
        public SaleOrders()
        {
            SaleOrderDelivereds = new HashSet<SaleOrderDelivereds>();
            SaleOrderDetails = new HashSet<SaleOrderDetails>();
            SaleOrderRefunds = new HashSet<SaleOrderRefunds>();
        }

        public long Id { get; set; }
        public string Code { get; set; }
        public DateTime? CreatedDate { get; set; }
        public long CustomerId { get; set; }
        public long? StatusId { get; set; }
        public long? PaymentId { get; set; }
        public long? DeliveryStatusId { get; set; }
        public long? TransportFeeId { get; set; }
        public decimal? TotalPrice { get; set; }

        public SaleCustomers Customer { get; set; }
        public SalePayments Payment { get; set; }
        public SaleTransportFees TransportFee { get; set; }
        public ICollection<SaleOrderDelivereds> SaleOrderDelivereds { get; set; }
        public ICollection<SaleOrderDetails> SaleOrderDetails { get; set; }
        public ICollection<SaleOrderRefunds> SaleOrderRefunds { get; set; }
    }
}
