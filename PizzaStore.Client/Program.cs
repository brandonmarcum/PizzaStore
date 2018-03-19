﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaStore.Library;
using PizzaStore.Library.Enums;

namespace PizzaStore.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Size size = new Size(true, false, false, false, false);
            Crust crust = new Crust(false, false, true);
            Topping topping = new Topping(true, true, true, false, false, false, true);
            Order order = new Order();
            UserHelper userHelper = new UserHelper();
            order.addPizza(topping, size, crust);

            Console.WriteLine(order.pizzas[0].Crust.Thin.ToString());
            Console.ReadKey();
        }
    }
}
