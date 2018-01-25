using AppCore.Repository.IRepositories;
using AppCore.Repository.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace AppCore.Config.DependencyInjection
{
    public static class Repository
    {
        public static void Register(IServiceCollection services)
        {
            services.AddSingleton<IFlexUserRepository, FlexUserRepository>();
        }
    }
}
