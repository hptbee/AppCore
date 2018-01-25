﻿using System;
using System.Collections.Generic;

namespace AppCore.Entity.Models
{
    public partial class SaleRefRecuitmentCategories
    {
        public SaleRefRecuitmentCategories()
        {
            SaleRefRecuitmentCategoriesImageList = new HashSet<SaleRefRecuitmentCategoriesImageList>();
        }

        public long Id { get; set; }
        public long LanguageId { get; set; }
        public string Name { get; set; }
        public string NameUrl { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public string Avatar { get; set; }
        public bool IsActived { get; set; }
        public long? CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string MetaTitle { get; set; }
        public string MetaDescription { get; set; }
        public string MetaKeywords { get; set; }
        public int? SortOrder { get; set; }

        public SaleRecuitmentCategories IdNavigation { get; set; }
        public FlexLanguages Language { get; set; }
        public ICollection<SaleRefRecuitmentCategoriesImageList> SaleRefRecuitmentCategoriesImageList { get; set; }
    }
}