using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaStore.Library.Enums;

namespace PizzaStore.Library
{
    public class Size
    {
        public bool KidsPizza { get; set; }
        public bool SmallPizza { get; set; }
        public bool MediumPizza { get; set; }
        public bool LargePizza { get; set; }
        public bool VeganPizza { get; set; }
        
        public double GetSizeCost()
        {
            if (KidsPizza)
                return 7.50;
            else if (SmallPizza)
                return 8.25;
            else if (MediumPizza)
                return 8.80;
            else if (LargePizza)
                return 9.15;
            else
                throw new ArgumentNullException("No Size Added");
        }
    }
}
