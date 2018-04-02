using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore.Library
{
    public class SizeL
    {

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

        public double GetSizeCost(string itemName)
        {
            EFData ed = new EFData();

            foreach (var item in ed.ReadSize())
            {
                if (item.Name == itemName)
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

        public string FindSizeByName(string itemName)
        {
            EFData ed = new EFData();

            foreach (var item in ed.ReadSize())
            {
                if (item.Name == itemName)
                {
                    item.Selected = true;
                    return item.Name;
                }
            }

            throw new ArgumentNullException("No Size Selected");
        }

        public void ClearSelected()
        {
            EFData ed = new EFData();

            foreach (var item in ed.ReadSize())
            {
                    item.Selected = false;
            }
        }



    }
}
