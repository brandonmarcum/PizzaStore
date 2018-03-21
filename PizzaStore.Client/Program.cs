using System;
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
            


            Console.WriteLine(userHelper.GetOrder()[0].pizzas[0].Crust.Thick.ToString());
            Console.WriteLine(userHelper.GetSumOfAllOrders().ToString());
            Console.ReadKey();
        }
    }
}
