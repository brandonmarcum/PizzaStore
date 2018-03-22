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
        public Dictionary<int, Pizza> pizzas = new Dictionary<int, Pizza>();

        public void addPizza(Topping topping, Size size, Crust crust)
        {
            if (pizzas.Count < 12)
                pizzas.Add(pizzas.Count, new Pizza(topping, size, crust));
        }

        public void updatePizza(int index, Topping topping, Size size, Crust crust)
        {
            pizzas[index] = new Pizza(topping, size, crust);
        }

        public void removePizza(int index)
        {
            pizzas.Remove(index);
            for (int i = index; i < pizzas.Count - 1; i++)
            {
                pizzas[i] = pizzas[i + 1];
            }
        }

        public double CalculateTotalCost(int p)
        {
            double total = 0;

            Size size = pizzas[p].Size;
            total += size.GetSizeCost();

            Topping topping = pizzas[p].Topping;
            total += 1 * topping.GetToppingCount();

            Crust crust = pizzas[p].Crust;
            total += crust.GetCrustCost(); //1.05

            return total;
        }
        
        
    }
}
