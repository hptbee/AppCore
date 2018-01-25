namespace AppCore.Entity.Models
{
    public partial class SaleRefProductCategoriesImageList
    {
        public long Id { get; set; }
        public long LanguageId { get; set; }
        public long RefProductCategoryId { get; set; }
        public string Name { get; set; }

        public SaleRefProductsCatetories SaleRefProductsCatetories { get; set; }
    }
}
