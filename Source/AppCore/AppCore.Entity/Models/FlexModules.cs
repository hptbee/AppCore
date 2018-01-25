using System.Collections.Generic;

namespace AppCore.Entity.Models
{
    public partial class FlexModules
    {
        public FlexModules()
        {
            FlexModuleRoles = new HashSet<FlexModuleRoles>();
            FlexTables = new HashSet<FlexTables>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Namespace { get; set; }
        public int SortOrder { get; set; }
        public long ParentId { get; set; }
        public string Icon { get; set; }
        public bool IsPublic { get; set; }
        public bool IsShared { get; set; }
        public bool Deletable { get; set; }
        public bool IsActived { get; set; }
        public bool IsAllowCreatedView { get; set; }
        public bool IsMultilView { get; set; }

        public ICollection<FlexModuleRoles> FlexModuleRoles { get; set; }
        public ICollection<FlexTables> FlexTables { get; set; }
    }
}
