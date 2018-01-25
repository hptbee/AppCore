using System;
using System.Collections.Generic;

namespace AppCore.Entity.Models
{
    public partial class FlexTables
    {
        public FlexTables()
        {
            FlexColumns = new HashSet<FlexColumns>();
            FlexEnums = new HashSet<FlexEnums>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Alias { get; set; }
        public bool IsPrimary { get; set; }
        public bool Deletable { get; set; }
        public long ModuleId { get; set; }
        public long? CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool IsActived { get; set; }

        public FlexModules Module { get; set; }
        public ICollection<FlexColumns> FlexColumns { get; set; }
        public ICollection<FlexEnums> FlexEnums { get; set; }
    }
}
