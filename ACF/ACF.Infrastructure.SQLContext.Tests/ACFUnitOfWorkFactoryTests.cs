using ACF.Domain.Entities.Staff;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACF.Infrastructure.SQLContext.Tests
{
    [TestClass]
    public class ACFUnitOfWorkFactoryTests
    {
        [TestMethod]
        public void Add_AddUserRecord_ReturnNumberOfAddedEntities()
        {
            // Arrange
            var uowFactory = new ACFUnitOfWorkFactory();
            using (var ctx = uowFactory.Create() as ACFUnitOfWork)
            {
                //var user = new User { FirstName = "Bill", UserName = "ABC" };
                var user = new Staff() { FirstName = "Bill", UserName = "ABC" };

                // Act
                ctx.Users.Add(user);
                var numberOfAdded = ctx.SaveChanges();
                // Assert
                Assert.IsTrue(numberOfAdded > 0);
            }
        }
    }

}
