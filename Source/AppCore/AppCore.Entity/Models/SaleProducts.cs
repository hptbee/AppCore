using System;
using System.Collections.Generic;

namespace AppCore.Entity.Models
{
    public partial class SaleProducts
    {
        public SaleProducts()
        {
            SaleFavouriteProducts = new HashSet<SaleFavouriteProducts>();
            SaleProductImageList = new HashSet<SaleProductImageList>();
            SaleProductVsCategories = new HashSet<SaleProductVsCategories>();
            SaleProductVsTabs = new HashSet<SaleProductVsTabs>();
            SaleRefProducts = new HashSet<SaleRefProducts>();
            SaleWareHouses = new HashSet<SaleWareHouses>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string ImageHover { get; set; }
        public string Avatar { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public string NameUrl { get; set; }
        public string MetaTitle { get; set; }
        public string MetaDescription { get; set; }
        public string MetaKeywords { get; set; }
        public bool IsActived { get; set; }
        public long? CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool Ishot { get; set; }
        public bool IsHome { get; set; }
        public decimal? Price1 { get; set; }
        public decimal? Price2 { get; set; }
        public decimal? Price3 { get; set; }
        public string Option1 { get; set; }
        public string Option2 { get; set; }
        public string Option3 { get; set; }
        public string Option4 { get; set; }
        public string Option5 { get; set; }
        public int ViewId { get; set; }

        public ICollection<SaleFavouriteProducts> SaleFavouriteProducts { get; set; }
        public ICollection<SaleProductImageList> SaleProductImageList { get; set; }
        public ICollection<SaleProductVsCategories> SaleProductVsCategories { get; set; }
        public ICollection<SaleProductVsTabs> SaleProductVsTabs { get; set; }
        public ICollection<SaleRefProducts> SaleRefProducts { get; set; }
        public ICollection<SaleWareHouses> SaleWareHouses { get; set; }
    }
}
