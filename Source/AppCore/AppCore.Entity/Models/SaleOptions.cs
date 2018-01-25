using System;
using System.Collections.Generic;

namespace AppCore.Entity.Models
{
    public partial class SaleOptions
    {
        public SaleOptions()
        {
            SaleOptionValues = new HashSet<SaleOptionValues>();
            SaleRefOptions = new HashSet<SaleRefOptions>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsActived { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public long? CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }

        public ICollection<SaleOptionValues> SaleOptionValues { get; set; }
        public ICollection<SaleRefOptions> SaleRefOptions { get; set; }
    }
}
