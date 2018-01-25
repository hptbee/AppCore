using System;
using System.Collections.Generic;

namespace AppCore.Entity.Models
{
    public partial class SaleProductCategorys
    {
        public SaleProductCategorys()
        {
            InverseParent = new HashSet<SaleProductCategorys>();
            SaleProductCategoriesImageList = new HashSet<SaleProductCategoriesImageList>();
            SaleProductVsCategories = new HashSet<SaleProductVsCategories>();
            SaleRefProductsCatetories = new HashSet<SaleRefProductsCatetories>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public string Avatar { get; set; }
        public string Icon { get; set; }
        public string NameUrl { get; set; }
        public long? ParentId { get; set; }
        public string ParentUrl { get; set; }
        public int? Level { get; set; }
        public string MetaTitle { get; set; }
        public string MetaDescription { get; set; }
        public string MetaKeywords { get; set; }
        public int? SortOrder { get; set; }
        public long? CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool IsActived { get; set; }
        public bool IsDelete { get; set; }
        public bool IsHot { get; set; }
        public bool IsHome { get; set; }
        public int ViewId { get; set; }
        public int? PartialViewId { get; set; }

        public SaleProductCategorys Parent { get; set; }
        public SalePartialViews PartialView { get; set; }
        public ICollection<SaleProductCategorys> InverseParent { get; set; }
        public ICollection<SaleProductCategoriesImageList> SaleProductCategoriesImageList { get; set; }
        public ICollection<SaleProductVsCategories> SaleProductVsCategories { get; set; }
        public ICollection<SaleRefProductsCatetories> SaleRefProductsCatetories { get; set; }
    }
}
