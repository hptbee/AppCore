namespace AppCore.Entity.Models
{
    public partial class SaleProductCategoriesImageList
    {
        public long Id { get; set; }
        public long ProductCategoryId { get; set; }
        public string Name { get; set; }

        public SaleProductCategorys ProductCategory { get; set; }
    }
}
