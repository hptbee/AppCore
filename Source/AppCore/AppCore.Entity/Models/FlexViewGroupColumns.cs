using System;

namespace AppCore.Entity.Models
{
    public partial class FlexViewGroupColumns
    {
        public long Id { get; set; }
        public long ColumnId { get; set; }
        public string ColumnName { get; set; }
        public long ViewId { get; set; }
        public long? CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public FlexViews View { get; set; }
    }
}
