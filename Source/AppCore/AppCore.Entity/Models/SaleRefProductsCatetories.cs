using System;
using System.Collections.Generic;

namespace AppCore.Entity.Models
{
    public partial class SaleRefProductsCatetories
    {
        public SaleRefProductsCatetories()
        {
            SaleRefProductCategoriesImageList = new HashSet<SaleRefProductCategoriesImageList>();
        }

        public long Id { get; set; }
        public long LanguageId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Avatar { get; set; }
        public string MetaTitle { get; set; }
        public string MetaDescription { get; set; }
        public string MetaKeywords { get; set; }
        public long? CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool IsActived { get; set; }
        public bool IsDelete { get; set; }
        public string NameUrl { get; set; }

        public SaleProductCategorys IdNavigation { get; set; }
        public ICollection<SaleRefProductCategoriesImageList> SaleRefProductCategoriesImageList { get; set; }
    }
}
