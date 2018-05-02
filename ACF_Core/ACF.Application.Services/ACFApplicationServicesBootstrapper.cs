using ACF.Application.Services.Generic.Contracts;
using ACF.Application.Services.Generic.Implementation;
using ACF.Application.Services.UserManagement.Contracts;
using ACF.Application.Services.UserManagement.Implementation;
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
            builder.AddTransient<IEmailSenderService, EmailSenderService>();
        }
    }
}
