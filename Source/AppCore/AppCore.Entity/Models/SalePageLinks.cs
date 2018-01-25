namespace AppCore.Entity.Models
{
    public partial class SalePageLinks
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long? ParentId { get; set; }
        public string Url { get; set; }
        public string ChildSqlQuery { get; set; }
        public bool IsActived { get; set; }
    }
}
