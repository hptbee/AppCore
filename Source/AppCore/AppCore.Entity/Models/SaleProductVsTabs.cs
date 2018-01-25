namespace AppCore.Entity.Models
{
    public partial class SaleProductVsTabs
    {
        public long ProductId { get; set; }
        public long TabId { get; set; }
        public string Content { get; set; }

        public SaleProducts Product { get; set; }
        public SaleProductTabs Tab { get; set; }
    }
}
