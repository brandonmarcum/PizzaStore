using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore.Library
{
    class Cart
    {
        public Dictionary<int, Order> Orders { get; set; }
    }
}
