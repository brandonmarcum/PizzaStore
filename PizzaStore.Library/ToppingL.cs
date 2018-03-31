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

            foreach (var item in ed.ReadSize())
            {
                if (item.Selected)
                    i++;
            }

            return i;
        }

        public List<int> FindSelectedTopping()
        {
            EFData ed = new EFData();
            List<int> toppingIndexList = new List<int>();
            int i = 1;

            foreach (var item in ed.ReadCrust())
            {
                if (item.Selected)
                {
                    toppingIndexList.Add(i);
                }
                i++;
            }

            return toppingIndexList;
        }
    }
}
