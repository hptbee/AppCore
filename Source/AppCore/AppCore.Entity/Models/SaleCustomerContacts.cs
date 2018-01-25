namespace AppCore.Entity.Models
{
    public partial class SaleCustomerContacts
    {
        public long Id { get; set; }
        public long CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Province { get; set; }
        public bool IsDefault { get; set; }
        public string District { get; set; }

        public SaleCustomers Customer { get; set; }
    }
}
