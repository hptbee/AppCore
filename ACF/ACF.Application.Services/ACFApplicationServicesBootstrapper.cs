    using ACF.Application.Services.UserManagement;
using ACF.Domain.Persistance;
using Autofac;

namespace ACF.Application.Services
{
    public static class ACFApplicationServicesBootstrapper
    {
        public static void Bootstrap(ContainerBuilder builder)
        {
            ACFDomainBootstrapper.Bootstrap(builder);

            RegisterApplicationServices(builder);
        }
        private static void RegisterApplicationServices(ContainerBuilder builder)
        {
            builder.RegisterType<UserManagementService>().As<IUserManagementService>().AsSelf();
        }
    }
}
