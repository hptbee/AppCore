namespace AppCore.Entity.Models
{
    public partial class SaleProductVsCategories
    {
        public long ProductId { get; set; }
        public long CategoryId { get; set; }

        public SaleProductCategorys Category { get; set; }
        public SaleProducts Product { get; set; }
    }
}
