using ACF.Domain.Persistance.AccessManagement;
using ACF.Infrastructure.Core.DomainModel;
using ACF.Infrastructure.MySQLContext;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

namespace ACF.Domain.Persistance
{
    public static class ACFDomainBootstrapper
    {
        public static void Bootstrap(IServiceCollection services)
        {
            RegisterIdentity(services);
            OtherRegistration(services);
            RegisterRepositories(services);
        }

        private static void RegisterRepositories(IServiceCollection services)
        {
            services.AddTransient<IUserRepository, UserRepository>();
        }

        private static void OtherRegistration(IServiceCollection services)
        {
            //services.AddTransient<IACFUnitOfWorkFactory, ACFUnitOfWorkFactory>();
            //services.AddTransient<IACFUnitOfWork, ACFUnitOfWork>();
        }

        private static void RegisterIdentity(IServiceCollection services)
        {
            services.AddDbContext<ACFUnitOfWork>();
            
            services.AddIdentity<IdentityUser, IdentityRole>()
                .AddEntityFrameworkStores<ACFUnitOfWork>()
                .AddDefaultTokenProviders();
        }
    }
}
