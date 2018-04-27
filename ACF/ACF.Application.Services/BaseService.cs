using ACF.Infrastructure.Core;
using ACF.Infrastructure.SQLContext;

namespace ACF.Application.Services
{
    public class BaseService
    {
        protected readonly IACFUnitOfWorkFactory unitOfWorkFactory;

        public BaseService(IACFUnitOfWorkFactory unitOfWorkFactory)
        {
            Check.NotNull(unitOfWorkFactory, "unitOfWorkFactory");

            this.unitOfWorkFactory = unitOfWorkFactory;
        }
    }
}
