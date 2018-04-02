using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore.Library
{
    public class PizzaL
    {
       // public List<int> Topping { get; set; }
        public string Size { get; set; }
        public string Crust { get; set; }
        public string Sauce { get; set; }
        public string Cheese1 { get; set; }
        public string Cheese2 { get; set; }
        public double Cost { get; set; }


        public PizzaL(string C, string Si, string Sa, string FC, string SC)
        {
            SizeL s = new SizeL();
            CrustL c = new CrustL();
            SauceL sa = new SauceL();
            CheeseL ch = new CheeseL();

            
            Crust = c.FindCrustByName(C);
            Size = s.FindSizeByName(Si);
            Sauce = sa.FindSauceByName(Sa);
            Cheese1 = ch.FindCheeseByName(FC);
            Cheese2 = ch.FindCheeseByName(SC);
            Cost = GetTotalCost(C, Si);

            if (!CheckTotalCost())
                throw new Exception("The total cost is over $1,000!!!");

            EFData ef = new EFData();
            ef.AddPizza(Crust, Size, Sauce, Cheese1, Cheese2, Cost);

            ef.AddPizzaOrder();

            c.ClearSelected();
            s.ClearSelected();
            sa.ClearSelected();
            ch.ClearSelected();
        }

        public PizzaL()
        {
        }

        public void FillToppingTable(List<string> tl)
        {
            ToppingL t = new ToppingL();
            List<int> Topping = new List<int>();

            foreach(string item in tl)
            {
                Topping.Add(t.FindToppingByName(item));
            }

            EFData ef = new EFData();
            ef.AddPizzaTopping(Topping);

        }

        public double GetTotalCost(string C, string S)
        {
            double total = 0;

            SizeL s = new SizeL();
            CrustL c = new CrustL();
            ToppingL t = new ToppingL();

            total += s.GetSizeCost(S);
            total += c.GetCrustCost(C);
            total += t.GetToppingCount();

            return total;
        }

        public bool CheckTotalCost()
        {
            OrderL order = new OrderL();

            double totalCost = order.GetTotalCost();
            
            if (totalCost > 1000.00)
                return false;

            return true;
        }
    }
}
