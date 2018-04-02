using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore.Library
{
    public class LocationL
    {
        public int FindLocationByName(string itemName)
        {
            EFData ed = new EFData();

            foreach (var item in ed.ReadLocation())
            {
                if (item.Name == itemName)
                {
                    return item.LocationId;
                }
            }

            throw new ArgumentNullException("No Location Selected");
        }
    }
}
