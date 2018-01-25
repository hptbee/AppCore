using AppCore.Service.IService;
using AppCore.Service.Service;
using Microsoft.Extensions.DependencyInjection;

namespace AppCore.Config.DependencyInjection
{
    public static class Service
    {
        public static void Register(IServiceCollection services)
        {
            services.AddSingleton<IFlexUserService, FlexUserService>();
        }
    }
}
