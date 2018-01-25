using System.Collections.Generic;

namespace AppCore.Entity.Models
{
    public partial class SaleWebPagePositions
    {
        public SaleWebPagePositions()
        {
            SaleWebImages = new HashSet<SaleWebImages>();
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public string PageCode { get; set; }
        public bool IsActived { get; set; }
        public long? TypeId { get; set; }
        public bool IsMultil { get; set; }
        public string Title { get; set; }
        public string TitleEng { get; set; }
        public string Description { get; set; }
        public string DescriptionEng { get; set; }
        public string ButtonName { get; set; }
        public string ButtonEng { get; set; }
        public string Link { get; set; }

        public SaleWebPages PageCodeNavigation { get; set; }
        public ICollection<SaleWebImages> SaleWebImages { get; set; }
    }
}
