using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PizzaStore.Library;

namespace PizzaStore.Test
{
    [TestClass]
    public class OrderTest
    {
        [TestMethod]
        public void O1MakeAnOrder()
        {
            Size size = new Size(false, true, false, false, false);
            Crust crust = new Crust(false, true, false);
            Topping topping = new Topping(true, true, true, false, true, false, true);
            Order order = new Order();
            Cart cart = new Cart();
            order.addPizza(topping, size, crust);

            for (int i = 0; i < 13; i++)
            {
                size = new Size(false, true, false, false, false);
                crust = new Crust(false, true, false);
                topping = new Topping(true, true, true, false, true, false, true);
                order.addPizza(topping, size, crust);
            }

            cart.AddOrder(order);

            Assert.IsFalse(order.pizzas.Count == 13);
            Assert.IsTrue(order.pizzas.Count == 12);
            Assert.IsTrue(cart.GetOrders().Count == 1);
        }

        [TestMethod]
        public void O2MakeTwoOrders()
        {
            Size size = new Size(false, true, false, false, false);
            Crust crust = new Crust(false, true, false);
            Topping topping = new Topping(true, true, true, false, true, false, true);
            Order order = new Order();
            Cart cart = new Cart();
            order.addPizza(topping, size, crust);

            for (int q = 0; q < 2; q++)
            {
                for (int i = 0; i < 13; i++)
                {
                    size = new Size(false, true, false, false, false);
                    crust = new Crust(false, true, false);
                    topping = new Topping(true, true, true, false, true, false, true);
                    order.addPizza(topping, size, crust);
                }

                cart.AddOrder(order);
            }


            Assert.IsFalse(order.pizzas.Count == 13);
            Assert.IsTrue(order.pizzas.Count == 12);
            Assert.IsTrue(cart.GetOrders().Count == 2);
        }

        [TestMethod]
        public void O3MakeFourOrders()
        {
            Size size = new Size(false, true, false, false, false);
            Crust crust = new Crust(false, true, false);
            Topping topping = new Topping(true, true, true, false, true, false, true);
            Order order = new Order();
            Cart cart = new Cart();
            order.addPizza(topping, size, crust);

            for (int q = 0; q < 4; q++)
            {
                for (int i = 0; i < 13; i++)
                {
                    size = new Size(false, true, false, false, false);
                    crust = new Crust(false, true, false);
                    topping = new Topping(true, true, true, false, true, false, true);
                    order.addPizza(topping, size, crust);
                }

                cart.AddOrder(order);
            }

            Assert.IsFalse(order.pizzas.Count == 13);
            Assert.IsTrue(order.pizzas.Count == 12);
            Assert.IsFalse(cart.GetOrders().Count == 4);
            Assert.IsTrue(cart.GetOrders().Count == 3);
        }

        [TestMethod]
        public void O4SimulateMakingAnOrder()
        {
            //Start
            //Profile
            Profile profile = new Profile();
            //User
            UserHelper userHelper = new UserHelper();
            User user = new User("John", "Smith", "js@gmail.com", "200-555-5555", true,
                "FL", "76 Skip Street", "Orlando", "57862");
            userHelper.AddUser(user);

            //Location
            Site site = new Site("Main Branch", "GA", "800 Street Street", "Hemp", "80512");


            //Menu
            Size size = new Size();
            Crust crust = new Crust();
            Topping topping = new Topping();

            size.KidsPizza = false;
            size.LargePizza = true; //9.15
            crust.Thin = false;
            crust.ExtraThick = true; //1.05
            topping.CheeseX4 = true; //1
            topping.BaconBits = true; //1
            topping.RealBacon = true; //1

            //Order
            Order order = new Order();
            order.addPizza(topping, size, crust);

            //Cart
            Cart cart = new Cart();
            cart.AddOrder(order);


            //Receipt
            cart.GetSumOfAllOrders();

            Console.WriteLine(cart.GetSumOfAllOrders());
            Assert.IsTrue(cart.GetSumOfAllOrders().ToString() == 13.2.ToString());
        }

    }
}
