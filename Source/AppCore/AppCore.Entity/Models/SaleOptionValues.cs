using System;
using System.Collections.Generic;

namespace AppCore.Entity.Models
{
    public partial class SaleOptionValues
    {
        public SaleOptionValues()
        {
            SaleRefOptionValues = new HashSet<SaleRefOptionValues>();
            SaleWareHouseDetails = new HashSet<SaleWareHouseDetails>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public long? OptionId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? CreatedBy { get; set; }
        public DateTime? UpdatedBy { get; set; }

        public SaleOptions Option { get; set; }
        public ICollection<SaleRefOptionValues> SaleRefOptionValues { get; set; }
        public ICollection<SaleWareHouseDetails> SaleWareHouseDetails { get; set; }
    }
}
