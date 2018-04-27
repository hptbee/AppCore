using ACF.Infrastructure.Core.Helpers;
using ACF.Infrastructure.MySQLContext;
using Microsoft.AspNetCore.Identity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace ACF.DistributedServices.API.Tests
{
    [TestClass]
    public class ACFUnitOfWorkFactoryTests
    {
        [TestMethod]
        public void Add_AddUserRecord_FetchAgainToCompareId()
        {
            var username = "tester";

            var uowFactory = new ACFUnitOfWorkFactory();
            using (var ctx = uowFactory.Create() as ACFUnitOfWork)
            {
                var user = new IdentityUser()
                {
                    UserName = username,
                    Email = "tester@gmail.com",
                    EmailConfirmed = true,
                    PasswordHash = "AbcXyz",
                    SecurityStamp = "AbcXyz"
                };

                ctx.Users.Add(user);
                ctx.Commit();

                var addedUser = ctx.Users.FirstOrDefault(u => u.UserName == username);
                Assert.IsNotNull(addedUser);
                Assert.AreEqual(addedUser.Id, user.Id);
            }
        }
    }
}
