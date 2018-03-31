using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore.Library
{
    public class PizzaL
    {
        public List<int> Topping { get; set; }
        public string Size { get; set; }
        public string Crust { get; set; }

        public PizzaL()
        {
            SizeL s = new SizeL();
            CrustL c = new CrustL();
            ToppingL t = new ToppingL();

            Topping = t.FindSelectedTopping();
            Size = s.FindSelectedSize();
            Crust = c.FindSelectedCurst();
        }
    }
}
