using System;

namespace AppCore.Entity.Models
{
    public partial class SaleDeliveries
    {
        public long Id { get; set; }
        public string DocumentNo { get; set; }
        public DateTime? DocumentDate { get; set; }
        public string LicensePlate { get; set; }
        public string CustomerCode { get; set; }
        public decimal? Quantity { get; set; }
        public string Notes { get; set; }
        public DateTime? TimeBegin { get; set; }
        public DateTime? TimeEnd { get; set; }
        public short Status { get; set; }
        public long? CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
