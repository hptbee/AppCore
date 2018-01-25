namespace AppCore.Entity.Models
{
    public partial class SaleDistricts
    {
        public string DisId { get; set; }
        public string DisName { get; set; }
        public string Type { get; set; }
        public string Location { get; set; }
        public string ProId { get; set; }

        public SaleProvinces Pro { get; set; }
    }
}
