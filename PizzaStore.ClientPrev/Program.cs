using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaStore.Data;
using PizzaStore.Library;

namespace PizzaStore.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            EFData efd = new EFData();

            //foreach(var item in efd.ReadCrust())
            //{
            //    Console.WriteLine(item.Name);
            //}
            //foreach (var item in efd.ReadTopping())
            //{
            //    Console.WriteLine(item.Name);
            //}
            //foreach (var item in efd.ReadSize())
            //{
            //    Console.WriteLine(item.Name);
            //}

            //Pizza pizza = new Pizza();
            //Console.WriteLine(pizza.Crust);
            efd.AddPizza();

            PizzaL pizza = new PizzaL();
            Console.WriteLine(pizza.Crust);
            Console.WriteLine(pizza.Size);
            //Console.WriteLine(pizza.PizzaTopping);

            Console.ReadKey();
        }
    }
}
