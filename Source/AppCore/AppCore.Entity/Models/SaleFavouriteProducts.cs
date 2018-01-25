namespace AppCore.Entity.Models
{
    public partial class SaleFavouriteProducts
    {
        public long Id { get; set; }
        public long ProductId { get; set; }
        public long CustomerId { get; set; }

        public SaleCustomers Customer { get; set; }
        public SaleProducts Product { get; set; }
    }
}
