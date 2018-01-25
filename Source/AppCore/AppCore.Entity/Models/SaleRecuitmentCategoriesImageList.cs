namespace AppCore.Entity.Models
{
    public partial class SaleRecuitmentCategoriesImageList
    {
        public long Id { get; set; }
        public long? CategoryId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string TypeFile { get; set; }

        public SaleRecuitmentCategories Category { get; set; }
    }
}
