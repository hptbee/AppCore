using System.Collections.Generic;

namespace AppCore.Entity.Models
{
    public partial class SalePageNavs
    {
        public SalePageNavs()
        {
            SaleModules = new HashSet<SaleModules>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public long? ParentId { get; set; }
        public string Url { get; set; }
        public string ChildSqlQuery { get; set; }
        public bool? IsActived { get; set; }
        public bool IsIndex { get; set; }

        public ICollection<SaleModules> SaleModules { get; set; }
    }
}
