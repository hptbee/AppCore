using System;

namespace AppCore.Entity.Models
{
    public partial class FlexTempViewConditions
    {
        public long Id { get; set; }
        public long ColumnId { get; set; }
        public string ColumnName { get; set; }
        public string Operator { get; set; }
        public bool IsAnd { get; set; }
        public long ViewId { get; set; }
        public string FilterValue1 { get; set; }
        public string FilterValue2 { get; set; }
        public long? CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
