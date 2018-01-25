namespace AppCore.Entity.Models
{
    public partial class SaleRecuitmentCategoryVsUser
    {
        public long Id { get; set; }
        public long? UserId { get; set; }
        public long? RecuitmentId { get; set; }

        public SaleRecuitmentCategories Recuitment { get; set; }
    }
}
