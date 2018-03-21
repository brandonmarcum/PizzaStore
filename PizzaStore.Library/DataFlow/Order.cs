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
        }

        public void addPizza(Topping topping, Size size, Crust crust)
        {
            if (pizzas.Count < 12)
                pizzas.Add(pizzas.Count, new Pizza(topping, size, crust));
        }

        public double CalculateTotalCost(int p)
        {
            double total = 0;

            Size size = pizzas[p].Size;
            total += size.GetSizeCost();

            Topping topping = pizzas[p].Topping;
            total += 1 * topping.GetToppingCount();

            Crust crust = pizzas[p].Crust;
            total += crust.GetCrustCost();

            return total;
        }

        
    }
}
