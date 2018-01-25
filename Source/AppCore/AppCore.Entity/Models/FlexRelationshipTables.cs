using System;

namespace AppCore.Entity.Models
{
    public partial class FlexRelationshipTables
    {
        public int Id { get; set; }
        public long ChildColumnId { get; set; }
        public long ParentColumnId { get; set; }
        public string DisplayParentColumnName { get; set; }
        public string ParentTableAlias { get; set; }
        public long? CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
