using ACF.Domain.Persistance.Repositories;
using ACF.Infrastructure.Core.DomainModel;
using Microsoft.AspNetCore.Identity;

namespace ACF.Domain.Persistance.AccessManagement
{
    public class UserRepository : Repository<IdentityUser>, IUserRepository
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;

        public UserRepository(IACFUnitOfWork aCFUnitOfWork,
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager) : base(aCFUnitOfWork)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
    }
}
