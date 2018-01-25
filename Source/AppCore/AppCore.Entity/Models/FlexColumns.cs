using System;

namespace AppCore.Entity.Models
{
    public partial class FlexColumns
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public long TableId { get; set; }
        public int DataTypeId { get; set; }
        public int? MaxLength { get; set; }
        public int SortOrder { get; set; }
        public bool Mandatory { get; set; }
        public bool Searchable { get; set; }
        public bool Sortable { get; set; }
        public bool AllowGroup { get; set; }
        public bool Display { get; set; }
        public bool PrimaryKey { get; set; }
        public bool ForeignKey { get; set; }
        public string SqlScript { get; set; }
        public long? EnumId { get; set; }
        public bool Deletable { get; set; }
        public long? CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool IsActived { get; set; }

        public FlexDataTypes DataType { get; set; }
        public FlexTables Table { get; set; }
    }
}
