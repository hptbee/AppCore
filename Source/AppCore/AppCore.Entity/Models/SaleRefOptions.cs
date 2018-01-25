namespace AppCore.Entity.Models
{
    public partial class SaleRefOptions
    {
        public long Id { get; set; }
        public long LanguageId { get; set; }
        public string Name { get; set; }

        public SaleOptions IdNavigation { get; set; }
        public FlexLanguages Language { get; set; }
    }
}
