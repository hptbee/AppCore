using System;
using System.Collections.Generic;

namespace AppCore.Entity.Models
{
    public partial class SaleCustomers
    {
        public SaleCustomers()
        {
            SaleCustomerContacts = new HashSet<SaleCustomerContacts>();
            SaleFavouriteProducts = new HashSet<SaleFavouriteProducts>();
            SaleOrders = new HashSet<SaleOrders>();
        }

        public long Id { get; set; }
        public string Email { get; set; }
        public bool? IsAllowAdvertising { get; set; }
        public string Password { get; set; }
        public string Note { get; set; }
        public DateTime? DateCreate { get; set; }

        public ICollection<SaleCustomerContacts> SaleCustomerContacts { get; set; }
        public ICollection<SaleFavouriteProducts> SaleFavouriteProducts { get; set; }
        public ICollection<SaleOrders> SaleOrders { get; set; }
    }
}
