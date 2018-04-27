using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using ACF.Infrastructure.Core.DomainModel;

namespace ACF.Infrastructure.SQLContext
{
    public class ACFUnitOfWorkFactory : IDbContextFactory<ACFUnitOfWork>, IACFUnitOfWorkFactory
    {
        public IUnitOfWork Create()
        {
            return new ACFUnitOfWork("name=ACFDBContext");
        }

        ACFUnitOfWork IDbContextFactory<ACFUnitOfWork>.Create()
        {
            return new ACFUnitOfWork("name=ACFDBContext");
        }
    }
}