using System.Collections.Generic;

namespace AppCore.Entity.Models
{
    public partial class SaleWebPages
    {
        public SaleWebPages()
        {
            SaleWebImages = new HashSet<SaleWebImages>();
            SaleWebPagePositions = new HashSet<SaleWebPagePositions>();
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public string View { get; set; }
        public bool? IsActived { get; set; }

        public ICollection<SaleWebImages> SaleWebImages { get; set; }
        public ICollection<SaleWebPagePositions> SaleWebPagePositions { get; set; }
    }
}
