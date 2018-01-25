using System;

namespace AppCore.Entity.Models
{
    public partial class FlexTempViews
    {
        public long Id { get; set; }
        public long ViewId { get; set; }
        public string SelectSql { get; set; }
        public string FromSql { get; set; }
        public string WhereSql { get; set; }
        public string OrderSql { get; set; }
        public long? CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
