using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore.Library
{
    public class OrderL
    {

        public List<PizzaL> pizzas { get; set; }
        public int CustomerLocation { get; set; }
        public int Site { get; set; }
        public double TotalCost { get; set; }
        public double Dough { get; set; }

        public OrderL()
        {

        }

        public OrderL(string x, string site)
        {
            LocationL location = new LocationL();
            CustomerLocation = location.FindLocationByName(x);
            Site = location.FindLocationByName(site);
            TotalCost = GetTotalCost();
            GetLocationDough(site);

            if (!CheckIfAnyPizzas())
                throw new Exception("Add a pizza will ya.");
            CheckIfStockLeft();

            EFData ef = new EFData();
            ef.AddOrder(CustomerLocation, Site, TotalCost);
        }

        public bool CheckIfAnyPizzas()
        {
            EFData ef = new EFData();
            foreach (var item in ef.ReadPizzaOrder())
            {
                if (item.Order == ef.ReadOrder().Count() + 1)
                    return true;
            }

            return false;
        }

        public double GetTotalCost()
        {
            EFData ef = new EFData();

            return ef.GetTotalCost(ef.ReadOrder().Count + 1);
        }

        public void GetLocationDough(string site)
        {
            EFData ef = new EFData();

            foreach (var item in ef.ReadLocation())
            {
                if(item.Name == site)
                {
                    Dough = double.Parse(item.dough.ToString());
                }
            }
        }

        public bool CheckIfStockLeft()
        {
            EFData ef = new EFData();

            foreach (var item in ef.ReadPizzaOrder())
            {
                if (item.Order == ef.ReadOrder().Count() + 1)
                {
                    foreach (var item2 in ef.ReadPizza())
                    {
                        if (item2.PizzaId == item.Pizza)
                        {
                            foreach(var item3 in ef.ReadCrust())
                            {
                                if(item2.Crust == item3.Name)
                                {
                                    if(item3.Dough > decimal.Parse(Dough.ToString()))
                                        throw new Exception("Dough Out of Stock");
                                }
                            }
                            foreach (var item3 in ef.ReadSize())
                            {
                                if (item2.Size == item3.Name)
                                {
                                    if (item3.Dough > decimal.Parse(Dough.ToString()))
                                        throw new Exception("Dough Out of Stock");
                                }
                            }
                            foreach (var item3 in ef.ReadSauce())
                            {
                                if (item2.Crust == item3.Name)
                                {
                                    if (item3.Stock < decimal.Parse(5.1.ToString()) && item3.Name != "No Sauce")
                                        throw new Exception("Sauce Out of Stock");
                                }
                            }
                            foreach (var item3 in ef.ReadCheese())
                            {
                                if (item2.FirstCheese == item3.Name)
                                {
                                    if (item3.Stock < decimal.Parse(2.3.ToString()) && item3.Name != "No Cheese")
                                        throw new Exception("Cheese Out of Stock");
                                }
                                if (item2.SecondCheese == item3.Name && item3.Name != "No Cheese")
                                {
                                    if (item3.Stock < decimal.Parse(2.3.ToString()))
                                        throw new Exception("Cheese Out of Stock");
                                }
                            }
                            foreach(var item3 in ef.ReadPizzaTopping())
                            {
                                if(item3.Pizza == item2.PizzaId)
                                {
                                    foreach(var item4 in ef.ReadTopping())
                                    {
                                        if(item3.Topping == item4.ToppingId)
                                        {
                                            if (item4.Stock < decimal.Parse(1.21.ToString()))
                                                throw new Exception("Toppings Out of Stock");
                                        }
                                    }
                                }
                            }
                        }
                    }
                }


               
            }

            return true;
        }
    }
}
