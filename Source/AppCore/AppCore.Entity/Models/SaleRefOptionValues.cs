namespace AppCore.Entity.Models
{
    public partial class SaleRefOptionValues
    {
        public long Id { get; set; }
        public long LanguageId { get; set; }
        public string Name { get; set; }

        public SaleOptionValues IdNavigation { get; set; }
        public FlexLanguages Language { get; set; }
    }
}
