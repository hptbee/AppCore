namespace AppCore.Entity.Models
{
    public partial class SaleWareHouseDetails
    {
        public long Id { get; set; }
        public long WareHouseId { get; set; }
        public long OptionValueId { get; set; }

        public SaleOptionValues OptionValue { get; set; }
        public SaleWareHouses WareHouse { get; set; }
    }
}
