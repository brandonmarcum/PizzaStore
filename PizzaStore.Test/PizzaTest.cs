using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PizzaStore.Library;

namespace PizzaStore.Test
{
    [TestClass]
    public class PizzaTest
    {
        [TestMethod]
        public void P1MakeAPizza()
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
        public void P2MakeTwoPizzas()
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
        public void P3MakeThreePizzas()
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
        public void P4MakeTwelvePizzas()
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
        public void P5MakeThirteenPizzas()
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
        public void P6UpdatePizza()
        {
            Size size = new Size(false, true, false, false, false);
            Crust crust = new Crust(false, true, false);
            Topping topping = new Topping(true, true, true, false, true, false, true);
            Order order = new Order();
            UserHelper userHelper = new UserHelper();
            order.addPizza(topping, size, crust);

            size.KidsPizza = true;
            size.SmallPizza = false;
            crust.Thin = true;
            crust.Thick = false;
            order.updatePizza(0, topping, size, crust);


            Assert.IsTrue(order.pizzas[0].Size.KidsPizza = true);
            Assert.IsFalse(order.pizzas[0].Size.SmallPizza = true);
            Assert.IsTrue(order.pizzas[0].Crust.Thin = true);
            Assert.IsFalse(order.pizzas[0].Crust.Thick = true);
        }

    }
}
