using System;
using System.Collections.Generic;

namespace AppCore.Entity.Models
{
    public partial class FlexRoles
    {
        public FlexRoles()
        {
            FlexModuleRoles = new HashSet<FlexModuleRoles>();
            FlexUsers = new HashSet<FlexUsers>();
            FlexViewRoles = new HashSet<FlexViewRoles>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public bool IsAdmin { get; set; }
        public long? ParentId { get; set; }
        public long? CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool IsActived { get; set; }
        public bool IsSuperAdmin { get; set; }

        public ICollection<FlexModuleRoles> FlexModuleRoles { get; set; }
        public ICollection<FlexUsers> FlexUsers { get; set; }
        public ICollection<FlexViewRoles> FlexViewRoles { get; set; }
    }
}
