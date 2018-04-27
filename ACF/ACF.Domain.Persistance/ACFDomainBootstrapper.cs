using ACF.Domain.Persistance.Repositories.StaffManagement;
using Autofac;
using ACF.Infrastructure.Core.DomainModel;
using ACF.Infrastructure.SQLContext;

namespace ACF.Domain.Persistance
{
    public static class ACFDomainBootstrapper
    {
        public static void Bootstrap(ContainerBuilder builder)
        {
            ACFUnitOfWorkBootstrapper.Bootstrap(builder);

            RegisterRepositories(builder);
        }
        private static void RegisterRepositories(ContainerBuilder builder)
        {
            builder.RegisterType<StaffRepository>().As<IStaffRepository>().AsSelf();

        }
      
    }
}
