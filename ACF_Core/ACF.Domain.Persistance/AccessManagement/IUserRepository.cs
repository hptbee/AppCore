using ACF.Infrastructure.Core.DomainModel;
using Microsoft.AspNetCore.Identity;

namespace ACF.Domain.Persistance.AccessManagement
{
    public interface IUserRepository : IRepository<IdentityUser>
    {
    }
}
