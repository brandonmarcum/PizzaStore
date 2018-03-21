using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PizzaStore.Library;

namespace PizzaStore.Test
{
    [TestClass]
    public class PizzaTest
    {
        [TestMethod]
        public void T1MakeAPizza1()
        {
            Size size = new Size(true, false, false, false, false);
            Crust crust = new Crust(false, false, true);
            Topping topping = new Topping(true, true, true, false, false, false, true);
            Order order = new Order();
            UserHelper userHelper = new UserHelper();
            order.addPizza(topping, size, crust);
            Assert.IsNotNull(order.pizzas);
        }

        [TestMethod]
        public void T2MakeTwoPizzas1()
        {
            Size size = new Size(false, true, false, false, false);
            Crust crust = new Crust(false, true, false);
            Topping topping = new Topping(true, true, true, false, true, false, true);
            Order order = new Order();
            UserHelper userHelper = new UserHelper();
            order.addPizza(topping, size, crust);

            size = new Size(false, true, false, false, false);
            crust = new Crust(false, true, false);
            topping = new Topping(true, true, true, false, true, false, true);
            order.addPizza(topping, size, crust);


            Assert.IsTrue(order.pizzas.Count == 2);
        }

        [TestMethod]
        public void T3MakeThreePizzas1()
        {
            Size size = new Size(false, true, false, false, false);
            Crust crust = new Crust(false, true, false);
            Topping topping = new Topping(true, true, true, false, true, false, true);
            Order order = new Order();
            UserHelper userHelper = new UserHelper();
            order.addPizza(topping, size, crust);

            size = new Size(false, true, false, false, false);
            crust = new Crust(false, true, false);
            topping = new Topping(true, true, true, false, true, false, true);
            order.addPizza(topping, size, crust);

            size = new Size(false, true, false, false, false);
            crust = new Crust(false, true, false);
            topping = new Topping(true, true, true, false, true, false, true);
            order.addPizza(topping, size, crust);


            Assert.IsTrue(order.pizzas.Count == 3);
        }

        [TestMethod]
        public void T4MakeTwelvePizzas1()
        {
            Size size = new Size(false, true, false, false, false);
            Crust crust = new Crust(false, true, false);
            Topping topping = new Topping(true, true, true, false, true, false, true);
            Order order = new Order();
            UserHelper userHelper = new UserHelper();
            order.addPizza(topping, size, crust);

            for(int i = 0; i < 12; i++)
            {
                size = new Size(false, true, false, false, false);
                crust = new Crust(false, true, false);
                topping = new Topping(true, true, true, false, true, false, true);
                order.addPizza(topping, size, crust);
            }
            
            Assert.IsTrue(order.pizzas.Count == 12);
        }

        [TestMethod]
        public void T5MakeThirteenPizzas1()
        {
            Size size = new Size(false, true, false, false, false);
            Crust crust = new Crust(false, true, false);
            Topping topping = new Topping(true, true, true, false, true, false, true);
            Order order = new Order();
            UserHelper userHelper = new UserHelper();
            order.addPizza(topping, size, crust);

            for (int i = 0; i < 13; i++)
            {
                size = new Size(false, true, false, false, false);
                crust = new Crust(false, true, false);
                topping = new Topping(true, true, true, false, true, false, true);
                order.addPizza(topping, size, crust);
            }

            Assert.IsFalse(order.pizzas.Count == 13);
            Assert.IsTrue(order.pizzas.Count == 12);
        }

        [TestMethod]
        public void T6MakeAnOrder()
        {
            Size size = new Size(false, true, false, false, false);
            Crust crust = new Crust(false, true, false);
            Topping topping = new Topping(true, true, true, false, true, false, true);
            Order order = new Order();
            UserHelper userHelper = new UserHelper();
            order.addPizza(topping, size, crust);

            for (int i = 0; i < 13; i++)
            {
                size = new Size(false, true, false, false, false);
                crust = new Crust(false, true, false);
                topping = new Topping(true, true, true, false, true, false, true);
                order.addPizza(topping, size, crust);
            }

            userHelper.AddOrder(order);

            Assert.IsFalse(order.pizzas.Count == 13);
            Assert.IsTrue(order.pizzas.Count == 12);
            Assert.IsTrue(userHelper.GetOrder().Count == 1);
        }

        [TestMethod]
        public void T7MakeTwoOrders()
        {
            Size size = new Size(false, true, false, false, false);
            Crust crust = new Crust(false, true, false);
            Topping topping = new Topping(true, true, true, false, true, false, true);
            Order order = new Order();
            UserHelper userHelper = new UserHelper();
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

                userHelper.AddOrder(order);
            }
           

            Assert.IsFalse(order.pizzas.Count == 13);
            Assert.IsTrue(order.pizzas.Count == 12);
            Assert.IsTrue(userHelper.GetOrder().Count == 2);
        }

        [TestMethod]
        public void T8MakeFourOrders()
        {
            Size size = new Size(false, true, false, false, false);
            Crust crust = new Crust(false, true, false);
            Topping topping = new Topping(true, true, true, false, true, false, true);
            Order order = new Order();
            UserHelper userHelper = new UserHelper();
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

                userHelper.AddOrder(order);
            }


            Assert.IsFalse(order.pizzas.Count == 13);
            Assert.IsTrue(order.pizzas.Count == 12);
            Assert.IsFalse(userHelper.GetOrder().Count == 4);
            Assert.IsTrue(userHelper.GetOrder().Count == 3);
        }



    }
}
