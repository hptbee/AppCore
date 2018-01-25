namespace AppCore.Entity.Models
{
    public partial class SaleWebImages
    {
        public long Id { get; set; }
        public string PageCode { get; set; }
        public string PositionCode { get; set; }
        public string Name { get; set; }
        public bool IsAll { get; set; }
        public string Link { get; set; }
        public string Title { get; set; }
        public int? SortOrder { get; set; }
        public bool IsActived { get; set; }
        public string TitleEnglish { get; set; }
        public string Description { get; set; }
        public string DescriptionEng { get; set; }

        public SaleWebPages PageCodeNavigation { get; set; }
        public SaleWebPagePositions PositionCodeNavigation { get; set; }
    }
}
