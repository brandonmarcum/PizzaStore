using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaStore.Library;
using PizzaStore.Library.Enums;
using PizzaStore.Data;

namespace PizzaStore.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            EFData ed = new EFData();

            foreach (var item in ed.Read())
            {
                Console.WriteLine(item.Name);
            }

            Console.ReadKey();
        }
    }
}
