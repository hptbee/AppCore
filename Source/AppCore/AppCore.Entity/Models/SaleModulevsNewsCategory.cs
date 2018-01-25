namespace AppCore.Entity.Models
{
    public partial class SaleModulevsNewsCategory
    {
        public int ModuleId { get; set; }
        public long CategoryId { get; set; }

        public SaleNewsCategories Category { get; set; }
        public SaleModules Module { get; set; }
    }
}
