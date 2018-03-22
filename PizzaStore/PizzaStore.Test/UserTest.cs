using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PizzaStore.Library;

namespace PizzaStore.Test
{
    [TestClass]
    public class UserTest
    {
        [TestMethod]
        public void TwoPlusTwo()
        {
            Assert.IsTrue(2 + 2 == 4);
        }

        [TestMethod]
        public void AddUser()
        {
            UserHelper userHelper = new UserHelper();
            User user = new User("John", "Smith", "JS@gmail.com", "258-963-7412", true, "MD", "591 Grand Blvd", "New Una", "11037");

            userHelper.AddUser(user);
            Assert.IsNotNull(user.State);
        }
    }
}
