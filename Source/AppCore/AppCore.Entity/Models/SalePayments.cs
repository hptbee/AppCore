using System.Collections.Generic;

namespace AppCore.Entity.Models
{
    public partial class SalePayments
    {
        public SalePayments()
        {
            SaleOrders = new HashSet<SaleOrders>();
        }

        public long Id { get; set; }
        public string Icon { get; set; }
        public string Avatar { get; set; }
        public string Name { get; set; }
        public string NameMethod { get; set; }
        public string AccountMerchant { get; set; }
        public string AccessCode { get; set; }
        public string Guige { get; set; }
        public bool IsUsed { get; set; }
        public bool IsActived { get; set; }
        public bool IsDefault { get; set; }
        public string Link { get; set; }

        public ICollection<SaleOrders> SaleOrders { get; set; }
    }
}
