namespace AppCore.Entity.Models
{
    public partial class SaleVideovsNewsCategory
    {
        public long VideoId { get; set; }
        public long NewsCategory { get; set; }

        public SaleNewsCategories NewsCategoryNavigation { get; set; }
        public SaleVideos Video { get; set; }
    }
}
