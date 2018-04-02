using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore.Library
{
    public class CheeseL
    {
        public static int FindIndexOfSelected()
        {
            EFData ed = new EFData();
            int i = 1;
            foreach (var item in ed.ReadCheese())
            {
                if (item.Selected)
                    return i;
                i++;
            }

            throw new ArgumentNullException("Couldn't find record");
        }
        

        public string FindSelectedCheese()
        {
            EFData ed = new EFData();

            foreach (var item in ed.ReadCheese())
            {
                if (item.Selected)
                    return item.Name;
            }

            throw new ArgumentNullException("No Size Selected");
        }

        public string FindCheeseByName(string itemName)
        {
            EFData ed = new EFData();

            foreach (var item in ed.ReadCheese())
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

            foreach (var item in ed.ReadCheese())
            {
                item.Selected = false;
            }
        }
    }
}
