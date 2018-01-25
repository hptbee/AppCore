namespace AppCore.Entity.Models
{
    public partial class SaleNewsVsCategories
    {
        public long NewsId { get; set; }
        public long CategoryId { get; set; }

        public SaleNewsCategories Category { get; set; }
        public SaleNews News { get; set; }
    }
}
