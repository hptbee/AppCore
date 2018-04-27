using ACF.Infrastructure.Core.DomainModel;

namespace ACF.Infrastructure.MySQLContext
{
    public interface IACFUnitOfWorkFactory
    {
        IUnitOfWork Create();
    }
}
