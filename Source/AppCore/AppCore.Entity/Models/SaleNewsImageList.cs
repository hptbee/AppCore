namespace AppCore.Entity.Models
{
    public partial class SaleNewsImageList
    {
        public long Id { get; set; }
        public long NewsId { get; set; }
        public string Name { get; set; }

        public SaleNews News { get; set; }
    }
}
