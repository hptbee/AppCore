using System.Collections.Generic;

namespace AppCore.Entity.Models
{
    public partial class SaleTransportFees
    {
        public SaleTransportFees()
        {
            SaleOrders = new HashSet<SaleOrders>();
        }

        public long Id { get; set; }
        public string NameMethod { get; set; }
        public int? KindTransport { get; set; }
        public int? Min { get; set; }
        public int? Max { get; set; }
        public decimal? PriceTransport { get; set; }
        public string Name { get; set; }
        public bool IsActived { get; set; }
        public bool IsUsed { get; set; }

        public ICollection<SaleOrders> SaleOrders { get; set; }
    }
}
