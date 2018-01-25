namespace AppCore.Entity.Models
{
    public partial class FlexUserExt
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public long Language { get; set; }
        public long PageSize { get; set; }
        public long Date { get; set; }
        public long Time { get; set; }

        public FlexUsers User { get; set; }
    }
}
