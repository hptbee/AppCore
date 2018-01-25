namespace AppCore.Entity.Models
{
    public partial class SaleNewsCategoriesImageList
    {
        public long Id { get; set; }
        public long? NewsCategoryId { get; set; }
        public string Name { get; set; }

        public SaleNewsCategories NewsCategory { get; set; }
    }
}
