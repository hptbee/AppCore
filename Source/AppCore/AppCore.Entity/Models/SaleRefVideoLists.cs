namespace AppCore.Entity.Models
{
    public partial class SaleRefVideoLists
    {
        public long Id { get; set; }
        public long VideoId { get; set; }
        public long LanguageId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string Icon { get; set; }
        public string Type { get; set; }
        public string Size { get; set; }

        public SaleRefVideos SaleRefVideos { get; set; }
    }
}
