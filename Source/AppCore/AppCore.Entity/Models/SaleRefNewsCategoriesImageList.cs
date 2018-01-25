namespace AppCore.Entity.Models
{
    public partial class SaleRefNewsCategoriesImageList
    {
        public long Id { get; set; }
        public long LanguageId { get; set; }
        public long RefNewsCategoryId { get; set; }
        public string Name { get; set; }

        public SaleRefNewsCategories SaleRefNewsCategories { get; set; }
    }
}
