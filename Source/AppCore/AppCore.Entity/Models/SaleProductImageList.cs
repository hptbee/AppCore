using System.Collections.Generic;

namespace AppCore.Entity.Models
{
    public partial class SaleProductImageList
    {
        public SaleProductImageList()
        {
            SaleWareHouses = new HashSet<SaleWareHouses>();
        }

        public long Id { get; set; }
        public long ProductId { get; set; }
        public string Name { get; set; }

        public SaleProducts Product { get; set; }
        public ICollection<SaleWareHouses> SaleWareHouses { get; set; }
    }
}
