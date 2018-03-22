using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PizzaStore.Library;

namespace PizzaStore.Test
{
    [TestClass]
    public class UserTest
    {
        [TestMethod]
        public void U1TwoPlusTwo()
        {
            Assert.IsTrue(2 + 2 == 4);
        }

        [TestMethod]
        public void U2AddUser()
        {
            UserHelper userHelper = new UserHelper();
            User user = new User("John", "Smith", "JS@gmail.com", "258-963-7412", true, "MD", "591 Grand Blvd", "New Una", "11037");

            userHelper.AddUser(user);
            Assert.IsNotNull(user.State);
        }

        [TestMethod]
        public void U3Update_AddUser()
        {
            UserHelper userHelper = new UserHelper();
            User user = new User("John", "Smith", "JS@gmail.com", "258-963-7412", true, "MD", "591 Grand Blvd", "New Una", "11037");

            userHelper.AddUser(user);
            user.State = "GA";

            userHelper.UpdateUser(0, user);
            Assert.IsTrue(userHelper.GetUsers()[0].State == "GA");
        }

        [TestMethod]
        public void U4Delete_Update_AddUser()
        {
            UserHelper userHelper = new UserHelper();
            User user = new User("John", "Smith", "JS@gmail.com", "258-963-7412", true, "MD", "591 Grand Blvd", "New Una", "11037");

            userHelper.AddUser(user);
            user.State = "GA";
            userHelper.AddUser(user);
            user.City = "Nowhere";
            userHelper.AddUser(user);

            userHelper.DeleteUser(1);

            Assert.IsTrue(userHelper.GetUsers().Count == 2);
            Assert.IsTrue(userHelper.GetUsers()[1].City == "Nowhere");
        }
    }
}
