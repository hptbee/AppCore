using System.Collections.Generic;

namespace AppCore.Entity.Models
{
    public partial class SaleProvinces
    {
        public SaleProvinces()
        {
            SaleDistricts = new HashSet<SaleDistricts>();
        }

        public string ProId { get; set; }
        public string ProName { get; set; }
        public string Type { get; set; }

        public ICollection<SaleDistricts> SaleDistricts { get; set; }
    }
}
