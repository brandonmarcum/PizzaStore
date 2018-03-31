using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore.Library
{
    public class CrustL
    {
        public int FindIndexOfSelected()
        {
            EFData ed = new EFData();
            int i = 1;
            foreach (var item in ed.ReadCrust())
            {
                if (item.Selected)
                    return i;
                i++;
            }

            throw new ArgumentNullException("Couldn't find record");
        }


        public double GetCrustCost()
        {
            EFData ed = new EFData();

            foreach (var item in ed.ReadCrust())
            {
                if (item.Selected)
                    return double.Parse(item.Price.ToString());
            }

            throw new ArgumentNullException("No Crust Added");
        }

        public string FindSelectedCurst()
        {
            EFData ed = new EFData();

            foreach (var item in ed.ReadCrust())
            {
                if (item.Selected)
                    return item.Name;
            }

            throw new ArgumentNullException("No Crust Selected");
        }
    }
}
