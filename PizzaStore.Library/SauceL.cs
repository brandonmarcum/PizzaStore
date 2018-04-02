using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore.Library
{
    public class SauceL
    {
        public static int FindIndexOfSelected()
        {
            EFData ed = new EFData();
            int i = 1;
            foreach (var item in ed.ReadSauce())
            {
                if (item.Selected)
                    return i;
                i++;
            }

            throw new ArgumentNullException("Couldn't find record");
        }


        public string FindSelectedSauce()
        {
            EFData ed = new EFData();

            foreach (var item in ed.ReadSauce())
            {
                if (item.Selected)
                    return item.Name;
            }

            throw new ArgumentNullException("No Size Selected");
        }

        public string FindSauceByName(string itemName)
        {
            EFData ed = new EFData();

            foreach (var item in ed.ReadSauce())
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

            foreach (var item in ed.ReadSauce())
            {
                item.Selected = false;
            }
        }
    }
}
