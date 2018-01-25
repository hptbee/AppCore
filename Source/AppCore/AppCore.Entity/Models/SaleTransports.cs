namespace AppCore.Entity.Models
{
    public partial class SaleTransports
    {
        public long Id { get; set; }
        public string Avatar { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string KeyApi { get; set; }
        public string Readmore { get; set; }
        public string Link { get; set; }
        public bool IsUsed { get; set; }
        public bool IsActive { get; set; }
    }
}
