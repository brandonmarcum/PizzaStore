using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore.Library
{
    public class Topping
    {
        bool Pepperoni { get; set; }
        bool Sausage { get; set; }
        bool BaconBits { get; set; }
        bool Spinach { get; set; }
        bool RealBacon { get; set; }
        bool ExtraCheese { get; set; }
        bool CheeseX4 { get; set; }

        public int GetToppingCount()
        {
            int toppingCount = 0;
            if (Pepperoni)
                toppingCount++;
            if (Sausage)
                toppingCount++;
            if (BaconBits)
                toppingCount++;
            if (Spinach)
                toppingCount++;
            if (RealBacon)
                toppingCount++;
            if (ExtraCheese)
                toppingCount++;
            if (CheeseX4)
                toppingCount++;

            return toppingCount;
        }
    }
}
