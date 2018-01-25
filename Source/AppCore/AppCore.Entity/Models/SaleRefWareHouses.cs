namespace AppCore.Entity.Models
{
    public partial class SaleRefWareHouses
    {
        public long Id { get; set; }
        public long LanguageId { get; set; }
        public long? ProductImageId { get; set; }

        public SaleWareHouses IdNavigation { get; set; }
        public FlexLanguages Language { get; set; }
        public SaleRefProductImageList ProductImage { get; set; }
    }
}
