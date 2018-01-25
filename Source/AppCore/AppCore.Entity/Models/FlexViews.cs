using System;
using System.Collections.Generic;

namespace AppCore.Entity.Models
{
    public partial class FlexViews
    {
        public FlexViews()
        {
            FlexViewColumns = new HashSet<FlexViewColumns>();
            FlexViewConditions = new HashSet<FlexViewConditions>();
            FlexViewGroupColumns = new HashSet<FlexViewGroupColumns>();
            FlexViewSortOrders = new HashSet<FlexViewSortOrders>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public long ModuleId { get; set; }
        public bool IsPublic { get; set; }
        public bool IsShared { get; set; }
        public string SelectSql { get; set; }
        public string FromSql { get; set; }
        public string WhereSql { get; set; }
        public string OrderSql { get; set; }
        public int SortOrder { get; set; }
        public long? CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool? IsActived { get; set; }
        public bool IsDefault { get; set; }
        public long? ViewId { get; set; }
        public bool IsMulti { get; set; }

        public ICollection<FlexViewColumns> FlexViewColumns { get; set; }
        public ICollection<FlexViewConditions> FlexViewConditions { get; set; }
        public ICollection<FlexViewGroupColumns> FlexViewGroupColumns { get; set; }
        public ICollection<FlexViewSortOrders> FlexViewSortOrders { get; set; }
    }
}
