using System;
using System.Collections.Generic;

namespace AppCore.Entity.Models
{
    public partial class SaleMenus
    {
        public SaleMenus()
        {
            SaleNavigationsChild = new HashSet<SaleNavigations>();
            SaleNavigationsMenu = new HashSet<SaleNavigations>();
            SaleRefMenus = new HashSet<SaleRefMenus>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public bool IsActived { get; set; }
        public long? CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public ICollection<SaleNavigations> SaleNavigationsChild { get; set; }
        public ICollection<SaleNavigations> SaleNavigationsMenu { get; set; }
        public ICollection<SaleRefMenus> SaleRefMenus { get; set; }
    }
}
