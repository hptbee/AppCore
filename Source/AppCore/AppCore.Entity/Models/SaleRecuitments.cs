using System;
using System.Collections.Generic;

namespace AppCore.Entity.Models
{
    public partial class SaleRecuitments
    {
        public SaleRecuitments()
        {
            SaleRecuitmentsVsCategories = new HashSet<SaleRecuitmentsVsCategories>();
            SaleRefRecuitments = new HashSet<SaleRefRecuitments>();
        }

        public long Id { get; set; }
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
        public int? Number { get; set; }
        public DateTime? DateExpiration { get; set; }
        public string Province { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public bool IsHome { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }
        public bool IsHeadquarter { get; set; }
        public string Email { get; set; }

        public ICollection<SaleRecuitmentsVsCategories> SaleRecuitmentsVsCategories { get; set; }
        public ICollection<SaleRefRecuitments> SaleRefRecuitments { get; set; }
    }
}
