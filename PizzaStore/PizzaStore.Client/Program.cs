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
            //Start
            //Profile
            Profile profile = new Profile();
            //User
            //Location

            //Menu
            Size size = new Size();
            Crust crust = new Crust();
            Topping topping = new Topping();

            size.SmallPizza = false;
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
            UserHelper userHelper = new UserHelper();
            userHelper.AddOrder(order);


            //Receipt





            Console.WriteLine(userHelper.GetOrders()[0].pizzas[0].Crust.Thick.ToString());
            Console.WriteLine(userHelper.GetSumOfAllOrders().ToString());
            Console.ReadKey();
        }
    }
}
