namespace AppCore.Entity.Models
{
    public partial class FlexViewRoles
    {
        public long Id { get; set; }
        public long RoleId { get; set; }
        public long ViewId { get; set; }

        public FlexRoles Role { get; set; }
    }
}
