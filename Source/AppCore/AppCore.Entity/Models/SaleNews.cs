using System;
using System.Collections.Generic;

namespace AppCore.Entity.Models
{
    public partial class SaleNews
    {
        public SaleNews()
        {
            SaleNewsImageList = new HashSet<SaleNewsImageList>();
            SaleNewsVsCategories = new HashSet<SaleNewsVsCategories>();
            SaleRefNews = new HashSet<SaleRefNews>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string NameUrl { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public string Avatar { get; set; }
        public bool IsActived { get; set; }
        public bool IsDeleted { get; set; }
        public long? CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string MetaTitle { get; set; }
        public string MetaDescription { get; set; }
        public string MetaKeywords { get; set; }
        public bool IsHome { get; set; }
        public int? SortOrder { get; set; }
        public int? Viewer { get; set; }
        public string Video { get; set; }
        public int? Quantity { get; set; }
        public string Location { get; set; }
        public string Deadline { get; set; }
        public int? ViewId { get; set; }
        public string Icon { get; set; }

        public ICollection<SaleNewsImageList> SaleNewsImageList { get; set; }
        public ICollection<SaleNewsVsCategories> SaleNewsVsCategories { get; set; }
        public ICollection<SaleRefNews> SaleRefNews { get; set; }
    }
}
