using System;

namespace AppCore.Entity.Models
{
    public partial class SaleRefMenus
    {
        public long Id { get; set; }
        public long LanguageId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public bool IsActived { get; set; }
        public long? CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public SaleMenus IdNavigation { get; set; }
    }
}
