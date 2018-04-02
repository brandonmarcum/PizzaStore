using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PizzaStore.Library;

namespace PizzaStore.Client.Models
{
    public class PizzaViewModel
    {
        public string SubmitType { get; set; }
        public string Location { get; set; }
        public string Size { get; set; }
        public string Crust { get; set; }
        public string Sauce { get; set; }
        public string FirstCheese { get; set; }
        public string SecondCheese { get; set; }
        public Topping Toppings { get; set; }
        public string CustomerLocation { get; set; }

        public PizzaViewModel()
        {
        }
    }
}
