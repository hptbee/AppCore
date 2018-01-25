namespace AppCore.Entity.Models
{
    public partial class SaleVideosList
    {
        public long Id { get; set; }
        public long? VideoId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string Icon { get; set; }
        public string Type { get; set; }
        public string Size { get; set; }

        public SaleVideos Video { get; set; }
    }
}
