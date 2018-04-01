using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore.Library
{
    public class SizeL
    {
        public SizeL()
        {

        }

        public SizeL(string n)
        {

        }

        public static int FindIndexOfSelected()
        {
            EFData ed = new EFData();
            int i = 1;
            foreach (var item in ed.ReadSize())
            {
                if (item.Selected)
                    return i;
                i++;
            }

            throw new ArgumentNullException("Couldn't find record");
        }

        public double GetSizeCost()
        {
            EFData ed = new EFData();

            foreach (var item in ed.ReadSize())
            {
                if (item.Selected)
                    return double.Parse(item.Price.ToString());
            }

            throw new ArgumentNullException("No Size Added");
        }

        public string FindSelectedSize()
        {
            EFData ed = new EFData();

            foreach (var item in ed.ReadSize())
            {
                if (item.Selected)
                    return item.Name;
            }

            throw new ArgumentNullException("No Size Selected");
        }
    }
}
