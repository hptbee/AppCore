using System;
using System.Collections.Generic;

namespace AppCore.Entity.Models
{
    public partial class SaleVideos
    {
        public SaleVideos()
        {
            SaleModules = new HashSet<SaleModules>();
            SaleRefVideos = new HashSet<SaleRefVideos>();
            SaleVideosList = new HashSet<SaleVideosList>();
            SaleVideovsNewsCategory = new HashSet<SaleVideovsNewsCategory>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string NameUrl { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public string Avatar { get; set; }
        public bool IsActived { get; set; }
        public bool IsHome { get; set; }
        public bool IsSelected { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ViewId { get; set; }
        public long? CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string MetaTitle { get; set; }
        public string MetaKeywords { get; set; }
        public string MetaDescription { get; set; }
        public int Viewer { get; set; }

        public ICollection<SaleModules> SaleModules { get; set; }
        public ICollection<SaleRefVideos> SaleRefVideos { get; set; }
        public ICollection<SaleVideosList> SaleVideosList { get; set; }
        public ICollection<SaleVideovsNewsCategory> SaleVideovsNewsCategory { get; set; }
    }
}
