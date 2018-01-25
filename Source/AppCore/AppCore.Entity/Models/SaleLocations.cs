using System;

namespace AppCore.Entity.Models
{
    public partial class SaleLocations
    {
        public long Id { get; set; }
        public Guid LocaltionId { get; set; }
        public string LicensePlate { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }
        public string DeviceId { get; set; }
        public DateTime? LocationTime { get; set; }
        public string Driver { get; set; }
        public long? CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
