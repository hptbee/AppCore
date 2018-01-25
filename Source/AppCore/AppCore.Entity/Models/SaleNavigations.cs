using System.Collections.Generic;

namespace AppCore.Entity.Models
{
    public partial class SaleNavigations
    {
        public SaleNavigations()
        {
            SaleRefNavigations = new HashSet<SaleRefNavigations>();
        }

        public long Id { get; set; }
        public long MenuId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public long? PageId { get; set; }
        public long? PageChildId { get; set; }
        public bool IsActived { get; set; }
        public int SortOrder { get; set; }
        public long? ChildId { get; set; }

        public SaleMenus Child { get; set; }
        public SaleMenus Menu { get; set; }
        public ICollection<SaleRefNavigations> SaleRefNavigations { get; set; }
    }
}
