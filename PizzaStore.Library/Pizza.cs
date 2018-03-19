using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaStore.Library.Enums;

namespace PizzaStore.Library
{
    public class Pizza
    {
        public Dictionary<int, ToppingEnum> Toppings {get; set;}
        public Dictionary<int, PizzaSizeEnum>();

        public void Add(ToppingEnum topping)
        {
            Toppings.Add(1, topping);
        }
    }
}
