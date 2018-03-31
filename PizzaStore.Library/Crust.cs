using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore.Library
{
    public class Crust
    {
        public bool Thin;
        public bool Thick;
        public bool ExtraThick;

        public Crust()
        {
            Thin = true;
            Thick = false;
            ExtraThick = false;
        }

        public Crust(bool tn, bool tc, bool ex)
        {
            Thin = tn;
            Thick = tc;
            ExtraThick = ex;
        }

        public double GetCrustCost()
        {

            if (Thin)
                return 0.00;
            else if (Thick)
                return 0.75;
            else if (ExtraThick)
                return 1.05;
            else
                throw new ArgumentNullException("No Crust Added");
        }
    }

}
