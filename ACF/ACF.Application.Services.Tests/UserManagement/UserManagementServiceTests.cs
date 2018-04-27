using ACF.Application.Services.UserManagement;
using ACF.Domain.Persistance.Repositories.StaffManagement;
using ACF.Infrastructure.Core.DomainModel;
using ACF.Infrastructure.SQLContext;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using ACF.Domain.Persistance;
using Autofac;
using Autofac.Integration.Mvc;

namespace ACF.Application.Services.Tests.UserManagement
{
    [TestClass]
    public class UserManagementServiceTests
    {
        public UserManagementServiceTests()
        {
            RegisterDependencyResolvers();
        }

        [TestMethod]
        public void Get_GetUserByUserName_ReturnMatchedUser()
        {
            // Arrange
            string userName = "ABC";
            var _userManagementService = 
                AutofacDependencyResolver.Current.ApplicationContainer.Resolve<UserManagementService>();

            // Act
            var matchedUsers = _userManagementService.GetByUserName(userName);

            // Assert
            Assert.IsNotNull(matchedUsers);
            Assert.IsTrue(matchedUsers.Count > 0);
            Assert.IsFalse(matchedUsers.Any(u => u.UserName != userName));
        }
        public  void RegisterDependencyResolvers()
        {
            var builder = new ContainerBuilder();
            builder.RegisterAssemblyModules(Assembly.GetExecutingAssembly());

            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly()).PropertiesAutowired();
            builder.RegisterModule<AutofacWebTypesModule>();

        

            ACFDomainBootstrapper.Bootstrap(builder);
            ACFApplicationServicesBootstrapper.Bootstrap(builder);

            var container = builder.Build();
            // Set the dependency resolver to be Autofac.
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            //Set the WebApi DependencyResolver
        }
    }

    
}
