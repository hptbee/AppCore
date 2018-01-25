using System.Collections.Generic;

namespace AppCore.Entity.Models
{
    public partial class SaleWareHouses
    {
        public SaleWareHouses()
        {
            SaleOrderDelivereds = new HashSet<SaleOrderDelivereds>();
            SaleOrderDetails = new HashSet<SaleOrderDetails>();
            SaleOrderRefunds = new HashSet<SaleOrderRefunds>();
            SaleRefWareHouses = new HashSet<SaleRefWareHouses>();
            SaleWareHouseDetails = new HashSet<SaleWareHouseDetails>();
        }

        public long Id { get; set; }
        public long ProductId { get; set; }
        public decimal? Price { get; set; }
        public decimal? PriceSale { get; set; }
        public bool? IsVat { get; set; }
        public string Sku { get; set; }
        public string Barcode { get; set; }
        public bool IsManageWareHouse { get; set; }
        public int? Quantity { get; set; }
        public bool IsAllowDeliveryWhenOutStock { get; set; }
        public long? ProductImageId { get; set; }
        public bool IsActived { get; set; }

        public SaleProducts Product { get; set; }
        public SaleProductImageList ProductImage { get; set; }
        public ICollection<SaleOrderDelivereds> SaleOrderDelivereds { get; set; }
        public ICollection<SaleOrderDetails> SaleOrderDetails { get; set; }
        public ICollection<SaleOrderRefunds> SaleOrderRefunds { get; set; }
        public ICollection<SaleRefWareHouses> SaleRefWareHouses { get; set; }
        public ICollection<SaleWareHouseDetails> SaleWareHouseDetails { get; set; }
    }
}
