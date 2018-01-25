using System;
using System.Collections.Generic;

namespace AppCore.Entity.Models
{
    public partial class FlexLanguages
    {
        public FlexLanguages()
        {
            SaleRefOptionValues = new HashSet<SaleRefOptionValues>();
            SaleRefOptions = new HashSet<SaleRefOptions>();
            SaleRefRecuitmentCategories = new HashSet<SaleRefRecuitmentCategories>();
            SaleRefRecuitments = new HashSet<SaleRefRecuitments>();
            SaleRefVideos = new HashSet<SaleRefVideos>();
            SaleRefWareHouses = new HashSet<SaleRefWareHouses>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Locale { get; set; }
        public string Url { get; set; }
        public string LanguageUl { get; set; }
        public string Image { get; set; }
        public bool? IsDefault { get; set; }
        public string FileName { get; set; }
        public int SortOrder { get; set; }
        public long? CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool IsActived { get; set; }

        public ICollection<SaleRefOptionValues> SaleRefOptionValues { get; set; }
        public ICollection<SaleRefOptions> SaleRefOptions { get; set; }
        public ICollection<SaleRefRecuitmentCategories> SaleRefRecuitmentCategories { get; set; }
        public ICollection<SaleRefRecuitments> SaleRefRecuitments { get; set; }
        public ICollection<SaleRefVideos> SaleRefVideos { get; set; }
        public ICollection<SaleRefWareHouses> SaleRefWareHouses { get; set; }
    }
}
