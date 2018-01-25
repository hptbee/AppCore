namespace AppCore.Entity.Models
{
    public partial class SaleOrderDelivereds
    {
        public long Id { get; set; }
        public long OrderId { get; set; }
        public long VariantId { get; set; }
        public long Quantity { get; set; }
        public decimal? Price { get; set; }

        public SaleOrders Order { get; set; }
        public SaleWareHouses Variant { get; set; }
    }
}
