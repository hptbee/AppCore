using System;

namespace AppCore.Entity.Models
{
    public partial class FlexEnumValues
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public bool Deletable { get; set; }
        public string Color { get; set; }
        public long EnumId { get; set; }
        public long? CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public long IsActived { get; set; }

        public FlexEnums Enum { get; set; }
    }
}
