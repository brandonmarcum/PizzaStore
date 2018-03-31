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

        public List<Pizza> ReadPizza()
        {
            return db.Pizzas.ToList();
        }

        public bool AddPizza()
        {
            PizzaL pizzal = new PizzaL();

            Pizza pizza = new Pizza();
            pizza.PizzaId = ReadPizza().Count + 1;
            pizza.Crust = pizzal.Crust;
            pizza.Size = pizzal.Size;


            db.Pizzas.AddRange(pizza);
            
            PizzaTopping pt = new PizzaTopping();

            foreach(var item in ReadTopping())
            {
                if(item.Selected)
                {
                    pt.Pizza = pizza.PizzaId;
                    pt.Topping = item.ToppingId;
                    db.PizzaToppings.AddRange(pt);
                }
            }
            

            return db.SaveChanges() != 0;
        }
    }
}
