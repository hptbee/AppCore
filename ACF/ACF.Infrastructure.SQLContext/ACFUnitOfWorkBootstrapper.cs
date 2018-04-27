using ACF.Infrastructure.Core.DomainModel;
using Autofac;

namespace ACF.Infrastructure.SQLContext
{
    public static class ACFUnitOfWorkBootstrapper
    {
        public static void Bootstrap(ContainerBuilder builder)
        {
            OtherRegistration(builder);

            RegisterRepositories(builder);
        }
        private static void RegisterRepositories(ContainerBuilder builder)
        {
            builder.RegisterType<ACFUnitOfWorkFactory>().As<IACFUnitOfWorkFactory>().AsSelf();

        }
        private static void OtherRegistration(ContainerBuilder builder)
        {
            builder.Register(c => new ACFUnitOfWork("ACFDBContext")).As<IACFUnitOfWork>();
        }
    }
}
