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
            Pizza pizza = new Pizza();
            pizza.Add(ToppingEnum.ExtraCheese);
            
        }
    }
}
