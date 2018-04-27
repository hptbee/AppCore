using ACF.Application.Services.UserManagement;
using Microsoft.Extensions.DependencyInjection;

namespace ACF.Application.Services
{
    public class ACFApplicationServicesBootstrapper
    {
        public static void Bootstrap(IServiceCollection services)
        {
            RegisterApplicationServices(services);
        }

        private static void RegisterApplicationServices(IServiceCollection builder)
        {
            builder.AddTransient<IUserManagementService, UserManagementService>();
        }
    }
}
