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
        public Topping Topping { get; set; }
        public Size Size { get; set; }
        public Crust Crust { get; set; }

        public Pizza(Topping topping, Size size, Crust crust)
        {
            Topping = topping;
            Size = size;
            Crust = crust;
        }
    }
}
