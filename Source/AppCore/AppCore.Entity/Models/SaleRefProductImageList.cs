using System.Collections.Generic;

namespace AppCore.Entity.Models
{
    public partial class SaleRefProductImageList
    {
        public SaleRefProductImageList()
        {
            SaleRefWareHouses = new HashSet<SaleRefWareHouses>();
        }

        public long Id { get; set; }
        public long LanguageId { get; set; }
        public long RefProductId { get; set; }
        public string Name { get; set; }

        public SaleRefProducts SaleRefProducts { get; set; }
        public ICollection<SaleRefWareHouses> SaleRefWareHouses { get; set; }
    }
}
