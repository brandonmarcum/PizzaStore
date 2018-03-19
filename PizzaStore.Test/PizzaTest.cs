using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PizzaStore.Library;

namespace PizzaStore.Test
{
    [TestClass]
    public class PizzaTest
    {
        [TestMethod]
        public void MakeAPizza1()
        {
            Size size = new Size(true, false, false, false, false);
            Crust crust = new Crust(false, false, true);
            Topping topping = new Topping(true, true, true, false, false, false, true);
            Order order = new Order();
            UserHelper userHelper = new UserHelper();
            order.addPizza(topping, size, crust);
            Assert.IsNotNull(order.pizzas);
        }
    }
}
