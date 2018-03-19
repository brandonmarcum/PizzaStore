using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore.Library
{
    public class Order
    {
        public double TotalCost {get; set;}
        public Dictionary<int, Pizza> pizzas;
        
        public Order()
        {
            pizzas = new Dictionary<int, Pizza>();
            TotalCost = CalculateTotalCost();
        }

        public void addPizza(Topping topping, Size size, Crust crust)
        {
            pizzas.Add(pizzas.Count, new Pizza(topping, size, crust));
        }

        public double CalculateTotalCost()
        {
            double total = 0;

            //Size size = new Size();
            //total = size.GetSizeCost();

            //Topping topping = new Topping();
            //total += 1 * topping.GetToppingCount();

            //Crust crust = new Crust();
            //total = crust.GetCrustCost();

            return total;
        }

        
    }
}
