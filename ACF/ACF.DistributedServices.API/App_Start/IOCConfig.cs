using System.Reflection;
using System.Web.Http;
using System.Web.Mvc;
using ACF.Application.Services;
using ACF.Domain.Persistance;
using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;

namespace ACF.DistributedServices.API
{
    public static class IOCConfig
    {
        public static void RegisterDependencyResolvers()
        {
            // Get your HttpConfiguration.
            var config = GlobalConfiguration.Configuration;

            var builder = new ContainerBuilder();
            builder.RegisterAssemblyModules(Assembly.GetExecutingAssembly());

            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly()).PropertiesAutowired();
            builder.RegisterModule<AutofacWebTypesModule>();

            // Register your Web API controllers.
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            // OPTIONAL: Register the Autofac filter provider.
            builder.RegisterWebApiFilterProvider(config);
            // OPTIONAL: Register the Autofac model binder provider.
            builder.RegisterWebApiModelBinderProvider();

            ACFDomainBootstrapper.Bootstrap(builder);
            ACFApplicationServicesBootstrapper.Bootstrap(builder);

            var container = builder.Build();
            // Set the dependency resolver to be Autofac.
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            //Set the WebApi DependencyResolver
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container); 
        }

        
    }
}