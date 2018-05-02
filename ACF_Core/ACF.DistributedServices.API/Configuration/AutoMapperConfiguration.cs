using ACF.Application.Contracts.UserManagement;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

namespace ACF.DistributedServices.API.Configuration
{
    public static class AutoMapperConfiguration
    {
        public static void Configure(IServiceCollection services)
        {
            var config = new AutoMapper.MapperConfiguration(cfg =>
            {
                cfg.CreateMap<IdentityUser, UserDto>();
            });
            var mapper = config.CreateMapper();
            services.AddSingleton(mapper);
        }
    }
}
