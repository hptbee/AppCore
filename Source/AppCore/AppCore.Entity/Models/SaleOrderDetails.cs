namespace AppCore.Entity.Models
{
    public partial class SaleOrderDetails
    {
        public long Id { get; set; }
        public long OrderId { get; set; }
        public long? ProductId { get; set; }
        public long? VariantId { get; set; }
        public string Name { get; set; }
        public long? ParentId { get; set; }
        public long Quantity { get; set; }
        public long? QuantityParent { get; set; }
        public decimal? Price { get; set; }
        public decimal? TotalPrice { get; set; }

        public SaleOrders Order { get; set; }
        public SaleWareHouses Variant { get; set; }
    }
}
