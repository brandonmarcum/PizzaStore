using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore.Library
{
    public class Order
    {
        Dictionary<int, Pizza> Pizzas;
        public int PizzaCount { get; set; }
        public int TotalCost { get; set; }

        public Order()
        {

        }

    }
}
