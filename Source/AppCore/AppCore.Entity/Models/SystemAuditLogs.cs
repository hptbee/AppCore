using System;

namespace AppCore.Entity.Models
{
    public partial class SystemAuditLogs
    {
        public long Id { get; set; }
        public long? ModuleId { get; set; }
        public long? MasterRecordId { get; set; }
        public string Operator { get; set; }
        public string BeforeValue { get; set; }
        public string AfterValue { get; set; }
        public DateTime? CreatedDate { get; set; }
        public long? CreatedBy { get; set; }
    }
}
