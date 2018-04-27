using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACF.Domain.Entities.Identity
{
    public class User : IdentityUser<Guid, GuidIdentityUserLogin, GuidIdentityUserRole, GuidIdentityUserClaim>
    {
        public User()
        {
            this.Id = Guid.NewGuid();
        }

        public string FullName { get; set; }

        public string Gender { get; set; }

        public DateTime? Birthday { get; set; }

        public string Avatar { get; set; }
    }

    public class GuidIdentityUserRole : IdentityUserRole<Guid>
    {
        public GuidIdentityUserRole()
        {
            this.RoleId = Guid.NewGuid();
        }
    }

    public class GuidIdentityRole : IdentityRole<Guid, GuidIdentityUserRole>
    {
        public GuidIdentityRole()
        {
            this.Id = Guid.NewGuid();
        }
    }

    public class GuidIdentityUserLogin : IdentityUserLogin<Guid> { }

    public class GuidIdentityUserClaim : IdentityUserClaim<Guid> { }
}
