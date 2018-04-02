using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore.Library
{
    public class ToppingL
    {
        public int GetToppingCount()
        {
            EFData ed = new EFData();

            int i = 0;
            

            return i;
        }

        public List<int> FindSelectedTopping()
        {
            EFData ed = new EFData();
            List<int> toppingIndexList = new List<int>();
            int i = 1;

            foreach (var item in ed.ReadTopping())
            {
                if (item.Selected)
                {
                    toppingIndexList.Add(i);
                }
                i++;
            }

            return toppingIndexList;
        }

        public int FindToppingByName(string itemName)
        {
            EFData ed = new EFData();

            foreach (var item in ed.ReadTopping())
            {
                if (item.Name == itemName)
                {
                    item.Selected = true;
                    return item.ToppingId;
                }
            }

            throw new ArgumentNullException("No Topping Selected");
        }

        public void ClearSelected()
        {
            EFData ed = new EFData();

            foreach (var item in ed.ReadTopping())
            {
                item.Selected = false;
            }
        }
    }
}
