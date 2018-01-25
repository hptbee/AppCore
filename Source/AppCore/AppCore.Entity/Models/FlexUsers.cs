using System;
using System.Collections.Generic;

namespace AppCore.Entity.Models
{
    public partial class FlexUsers 
    {
        public FlexUsers()
        {
            FlexUserExt = new HashSet<FlexUserExt>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Photo { get; set; }
        public long RoleId { get; set; }
        public long Status { get; set; }
        public string ActiveCode { get; set; }
        public long? CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool IsActived { get; set; }
        public bool IsDeleted { get; set; }
        public long? DepartmentId { get; set; }
        public string CustomerCode { get; set; }
        public string Address { get; set; }

        public FlexDepartment Department { get; set; }
        public FlexRoles Role { get; set; }
        public ICollection<FlexUserExt> FlexUserExt { get; set; }
    }
}
