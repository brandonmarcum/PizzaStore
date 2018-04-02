using System.Collections.Generic;
using System.Linq;
using PizzaStore.Data;

namespace PizzaStore.Library
{
    public class EFData
    {
        private PizzaContext db = new PizzaContext();

        public List<Crust> ReadCrust()
        {
            return db.Crusts.ToList();
        }

        public List<Size> ReadSize()
        {
            return db.Sizes.ToList();
        }

        public List<Topping> ReadTopping()
        {
            return db.Toppings.ToList();
        }

        public List<Cheese> ReadCheese()
        {
            return db.Cheeses.ToList();
        }

        public List<Sauce> ReadSauce()
        {
            return db.Sauces.ToList();
        }

        public List<Pizza> ReadPizza()
        {
            return db.Pizzas.ToList();
        }

        public List<Location> ReadLocation()
        {
            return db.Locations.ToList();
        }

        public List<PizzaTopping> ReadPizzaTopping()
        {
            return db.PizzaToppings.ToList();
        }

        public List<PizzaOrder> ReadPizzaOrder()
        {
            return db.PizzaOrders.ToList();
        }

        public List<Order> ReadOrder()
        {
            return db.Orders.ToList();
        }

        public bool AddPizza(string c, string sa, string si, string fc, string sc, double cost)
        {
            PizzaL pizzal = new PizzaL();

            Pizza pizza = new Pizza();
            pizza.PizzaId = ReadPizza().Count + 1;
            pizza.Crust = c;
            pizza.Size = si;
            pizza.Sauce = sa;
            pizza.FirstCheese = fc;
            pizza.SecondCheese = sc;

            pizza.Cost = decimal.Parse(cost.ToString());

            db.Pizzas.AddRange(pizza);

            return db.SaveChanges() != 0;
        }

        public bool AddPizzaTopping(List<int> t)
        {

            PizzaTopping pt;

            int i = 1;
            foreach (var item in t)
            {
                pt = new PizzaTopping();

                pt.PizzaToppingId = ReadPizzaTopping().Count + i;
                pt.Pizza = ReadPizza().Count;
                pt.Topping = item;

                db.PizzaToppings.AddRange(pt);
                i++;
            }

            

            return db.SaveChanges() != 0;
        }

        public bool AddPizzaOrder()
        {

            PizzaOrder po = new PizzaOrder();

            po.PizzaOrderId = ReadPizzaOrder().Count + 1;
            po.Pizza = ReadPizza().Count;
            po.Order = ReadOrder().Count + 1;

            db.PizzaOrders.AddRange(po);

            return db.SaveChanges() != 0;
        }

        public bool AddOrder(int location, int site, double total)
        {

            Order order = new Order();

            order.OrderId = ReadOrder().Count + 1;
            order.Location = location;
            order.Site = site;
            order.Cost = decimal.Parse(total.ToString());

            db.Orders.AddRange(order);

            return db.SaveChanges() != 0;
        }

        public double GetTotalCost(int orderId)
        {
            List<Pizza> pizzas = new List<Pizza>();
            PizzaOrder po = new PizzaOrder();
            foreach (var item in ReadPizzaOrder())
            {
                if(item.Order == orderId)
                {
                    foreach(var item2 in ReadPizza())
                    {
                        if(item2.PizzaId == item.Pizza)
                        {
                            pizzas.Add(item2);
                        }
                    }
                }
            }

            double total = 0;

            foreach(var p in pizzas)
            {
                total += double.Parse(p.Cost.ToString());
            }

            return total;
        }
    }
}
