using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore.Library
{
    public class Topping
    {
        public bool Pepperoni { get; set; }
        public bool Sausage { get; set; }
        public bool BaconBits { get; set; }
        public bool Spinach { get; set; }
        public bool RealBacon { get; set; }
        public bool ExtraCheese { get; set; }
        public bool CheeseX4 { get; set; }

        public Topping()
        {
            Pepperoni = false;
            Sausage = false;
            BaconBits = false;
            Spinach = false;
            RealBacon = false;
            ExtraCheese = false;
            CheeseX4 = false;
        }

        public Topping(bool p, bool sa, bool bb, bool sp, bool rb, bool ec, bool x4)
        {
            Pepperoni = p;
            Sausage = sa;
            BaconBits = bb;
            Spinach = sp;
            RealBacon = rb;
            ExtraCheese = ec;
            CheeseX4 = x4;
        }

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
