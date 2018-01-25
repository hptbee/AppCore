namespace AppCore.Entity.Models
{
    public partial class SaleRefNewsImageList
    {
        public long Id { get; set; }
        public long LanguageId { get; set; }
        public long RefNewsId { get; set; }
        public string Name { get; set; }

        public SaleRefNews SaleRefNews { get; set; }
    }
}
