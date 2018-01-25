using System.Collections.Generic;

namespace AppCore.Entity.Models
{
    public partial class SaleModules
    {
        public SaleModules()
        {
            SaleModulevsNewsCategory = new HashSet<SaleModulevsNewsCategory>();
        }

        public int Id { get; set; }
        public long? PageId { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public string ParentId { get; set; }
        public int? PartialId { get; set; }
        public long? NewsCateId { get; set; }
        public long? VideosCateId { get; set; }
        public int? GroupId { get; set; }
        public int? SortOrder { get; set; }
        public int? Lvl { get; set; }

        public SaleNewsCategories NewsCate { get; set; }
        public SalePageNavs Page { get; set; }
        public SaleVideos VideosCate { get; set; }
        public ICollection<SaleModulevsNewsCategory> SaleModulevsNewsCategory { get; set; }
    }
}
