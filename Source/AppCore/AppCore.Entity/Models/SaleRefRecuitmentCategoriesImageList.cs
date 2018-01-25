namespace AppCore.Entity.Models
{
    public partial class SaleRefRecuitmentCategoriesImageList
    {
        public long Id { get; set; }
        public long LanguageId { get; set; }
        public long RefCategoryId { get; set; }
        public string Name { get; set; }

        public SaleRefRecuitmentCategories SaleRefRecuitmentCategories { get; set; }
    }
}
