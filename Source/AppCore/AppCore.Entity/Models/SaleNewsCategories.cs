using System;
using System.Collections.Generic;

namespace AppCore.Entity.Models
{
    public partial class SaleNewsCategories
    {
        public SaleNewsCategories()
        {
            InverseParent = new HashSet<SaleNewsCategories>();
            SaleModules = new HashSet<SaleModules>();
            SaleModulevsNewsCategory = new HashSet<SaleModulevsNewsCategory>();
            SaleNewsCategoriesImageList = new HashSet<SaleNewsCategoriesImageList>();
            SaleNewsVsCategories = new HashSet<SaleNewsVsCategories>();
            SaleRefNewsCategories = new HashSet<SaleRefNewsCategories>();
            SaleVideovsNewsCategory = new HashSet<SaleVideovsNewsCategory>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string NameUrl { get; set; }
        public string Avatar { get; set; }
        public string Icon { get; set; }
        public long? CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public long? ParentId { get; set; }
        public int? SortOrder { get; set; }
        public string PositionFrom { get; set; }
        public string PositionTo { get; set; }
        public string MetaTitle { get; set; }
        public string MetaDescription { get; set; }
        public string MetaKeywords { get; set; }
        public string Content { get; set; }
        public string Description { get; set; }
        public bool IsActived { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsHome { get; set; }
        public int? ViewId { get; set; }
        public int? PartialViewId { get; set; }

        public SaleNewsCategories Parent { get; set; }
        public SalePartialViews PartialView { get; set; }
        public ICollection<SaleNewsCategories> InverseParent { get; set; }
        public ICollection<SaleModules> SaleModules { get; set; }
        public ICollection<SaleModulevsNewsCategory> SaleModulevsNewsCategory { get; set; }
        public ICollection<SaleNewsCategoriesImageList> SaleNewsCategoriesImageList { get; set; }
        public ICollection<SaleNewsVsCategories> SaleNewsVsCategories { get; set; }
        public ICollection<SaleRefNewsCategories> SaleRefNewsCategories { get; set; }
        public ICollection<SaleVideovsNewsCategory> SaleVideovsNewsCategory { get; set; }
    }
}
