using System;
using System.Collections.Generic;

namespace AppCore.Entity.Models
{
    public partial class SaleRecuitmentCategories
    {
        public SaleRecuitmentCategories()
        {
            SaleRecuitmentCategoriesImageList = new HashSet<SaleRecuitmentCategoriesImageList>();
            SaleRecuitmentCategoryVsUser = new HashSet<SaleRecuitmentCategoryVsUser>();
            SaleRecuitmentsVsCategories = new HashSet<SaleRecuitmentsVsCategories>();
            SaleRefRecuitmentCategories = new HashSet<SaleRefRecuitmentCategories>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string NameUrl { get; set; }
        public long? ParentId { get; set; }
        public bool? IsActived { get; set; }
        public string Avatar { get; set; }
        public int? SortOrder { get; set; }
        public string MetaTitle { get; set; }
        public string MetaDescription { get; set; }
        public string MetaKeywords { get; set; }
        public string Description { get; set; }
        public long? CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UserRole { get; set; }

        public ICollection<SaleRecuitmentCategoriesImageList> SaleRecuitmentCategoriesImageList { get; set; }
        public ICollection<SaleRecuitmentCategoryVsUser> SaleRecuitmentCategoryVsUser { get; set; }
        public ICollection<SaleRecuitmentsVsCategories> SaleRecuitmentsVsCategories { get; set; }
        public ICollection<SaleRefRecuitmentCategories> SaleRefRecuitmentCategories { get; set; }
    }
}
