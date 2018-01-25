using System.Collections.Generic;

namespace AppCore.Entity.Models
{
    public partial class SaleProductTabs
    {
        public SaleProductTabs()
        {
            SaleProductVsTabs = new HashSet<SaleProductVsTabs>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsFileUpload { get; set; }

        public ICollection<SaleProductVsTabs> SaleProductVsTabs { get; set; }
    }
}
