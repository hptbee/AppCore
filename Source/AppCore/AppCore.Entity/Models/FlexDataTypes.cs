using System.Collections.Generic;

namespace AppCore.Entity.Models
{
    public partial class FlexDataTypes
    {
        public FlexDataTypes()
        {
            FlexColumns = new HashSet<FlexColumns>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsInteger { get; set; }
        public bool IsDecimal { get; set; }
        public bool IsCurrency { get; set; }
        public bool IsLong { get; set; }
        public bool IsString { get; set; }
        public bool IsPassword { get; set; }
        public bool IsTextArea { get; set; }
        public bool IsHtml { get; set; }
        public bool IsEmail { get; set; }
        public bool IsUrl { get; set; }
        public bool IsDate { get; set; }
        public bool IsDateTime { get; set; }
        public bool IsTime { get; set; }
        public bool IsDropDownList { get; set; }
        public bool IsMultiSelect { get; set; }
        public bool IsCheckbox { get; set; }
        public bool IsImage { get; set; }
        public bool? IsActived { get; set; }

        public ICollection<FlexColumns> FlexColumns { get; set; }
    }
}
