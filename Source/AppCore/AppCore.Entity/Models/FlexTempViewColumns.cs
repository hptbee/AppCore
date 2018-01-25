using System;

namespace AppCore.Entity.Models
{
    public partial class FlexTempViewColumns
    {
        public long Id { get; set; }
        public long ColumnId { get; set; }
        public long ViewId { get; set; }
        public bool Visible { get; set; }
        public string Width { get; set; }
        public long? CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
