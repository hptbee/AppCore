namespace AppCore.Entity.Models
{
    public partial class SaleRecuitmentsVsCategories
    {
        public long CategoryId { get; set; }
        public long RecuitmentId { get; set; }

        public SaleRecuitmentCategories Category { get; set; }
        public SaleRecuitments Recuitment { get; set; }
    }
}
