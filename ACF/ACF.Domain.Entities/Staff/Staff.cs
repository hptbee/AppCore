using ACF.Infrastructure.Core.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACF.Domain.Entities.Staff
{
    public class Staff : Entity
    {
        public Staff()
        {
            Id = Guid.NewGuid();
        }

        public string UserName { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }
    }
}
