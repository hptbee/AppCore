namespace AppCore.Entity.Models
{
    public partial class FlexModuleRoles
    {
        public long Id { get; set; }
        public long RoleId { get; set; }
        public long ModuleId { get; set; }
        public bool AllowRead { get; set; }
        public bool AllowAdd { get; set; }
        public bool AllowEdit { get; set; }
        public bool AllowDelete { get; set; }
        public bool AllowUploadFile { get; set; }
        public bool AllowReAssign { get; set; }
        public bool AllowClose { get; set; }
        public bool AllowRating { get; set; }

        public FlexModules Module { get; set; }
        public FlexRoles Role { get; set; }
    }
}
