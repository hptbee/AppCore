using System.Collections.Generic;

namespace AppCore.Entity.Models
{
    public partial class SalePartialViews
    {
        public SalePartialViews()
        {
            SaleNewsCategories = new HashSet<SaleNewsCategories>();
            SaleProductCategorys = new HashSet<SaleProductCategorys>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Link { get; set; }
        public int? Type { get; set; }
        public bool IsActive { get; set; }
        public int? ViewId { get; set; }

        public ICollection<SaleNewsCategories> SaleNewsCategories { get; set; }
        public ICollection<SaleProductCategorys> SaleProductCategorys { get; set; }
    }
}
