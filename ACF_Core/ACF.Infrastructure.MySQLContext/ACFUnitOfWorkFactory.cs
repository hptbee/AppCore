using ACF.Infrastructure.Core.DomainModel;
using Microsoft.EntityFrameworkCore.Design;

namespace ACF.Infrastructure.MySQLContext
{
    public class ACFUnitOfWorkFactory : IDesignTimeDbContextFactory<ACFUnitOfWork>, IACFUnitOfWorkFactory
    {
        public IUnitOfWork Create()
        {
            return new ACFUnitOfWork();
        }

        ACFUnitOfWork IDesignTimeDbContextFactory<ACFUnitOfWork>.CreateDbContext(string[] args)
        {
            return new ACFUnitOfWork();
        }
    }
}