using ACF.Domain.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACF.Domain.Persistance.Repositories.IdentityManagement
{
    public interface IApplicationSignInManager
    {
        Task<bool> SignInAsync(User user);


    }
}
