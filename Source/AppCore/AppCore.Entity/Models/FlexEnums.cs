using System;
using System.Collections.Generic;

namespace AppCore.Entity.Models
{
    public partial class FlexEnums
    {
        public FlexEnums()
        {
            FlexEnumValues = new HashSet<FlexEnumValues>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public long TableId { get; set; }
        public bool Deletable { get; set; }
        public long? CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public long IsActived { get; set; }

        public FlexTables Table { get; set; }
        public ICollection<FlexEnumValues> FlexEnumValues { get; set; }
    }
}
