using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PizzaStore.Client.Models;
using PizzaStore.Library;

namespace PizzaStore.Client.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(PizzaViewModel pvm, string submitButton)
        {
            try
            {
                if (submitButton == "pizza")
                {
                    AddPizza(pvm);
                    ViewData["Message"] = "The pizza has been added.";
                    return View();
                }
                else if (submitButton == "order")
                {
                    AddOrder(pvm);
                    ViewData["Message"] = "Your order has been added.";
                    return View();
                }
                else if (submitButton == "history")
                {
                    EFData ed = new EFData();
                    string h = "";

                   
                        foreach(var item in ed.ReadLocation())
                        {
                            if(item.Name == pvm.CustomerLocation)
                            {
                                foreach(var item2 in ed.ReadOrder())
                                {
                                    if(item2.Location == item.LocationId)
                                    {
                                        foreach(var item3 in ed.ReadLocation())
                                        {
                                            if(item2.Site == item3.LocationId)
                                            {
                                                h += "Spent " + String.Format("{0:C}", item2.Cost) + " at " + item3.Name + ". --- ";
                                                ViewData["History"] = h;
                                            }
                                        }
                                    }
                                }
                            }
                        }

                    
                }
            }
            catch (Exception ex)
            {
                ViewData["Message"] = ex.Message;
                return View();
            }
            
            
            return View();
            
        }
        
        public void AddOrder(PizzaViewModel pvm)
        {
            OrderL order = new OrderL(pvm.CustomerLocation, pvm.Location);
        }


        public void AddPizza(PizzaViewModel pvm)
        {
            PizzaL pizza = new PizzaL(pvm.Crust, pvm.Size, pvm.Sauce, pvm.FirstCheese, pvm.SecondCheese);
            //Handle toppings sepeartely
            List<string> toppingList = new List<string>();
            if(pvm.Toppings != null)
            {
                if (pvm.Toppings.BaconBits)
                    toppingList.Add("BaconBits");
                if (pvm.Toppings.CheeseX4)
                    toppingList.Add("CheeseX4");
                if (pvm.Toppings.ExtraCheese)
                    toppingList.Add("ExtraCheese");
                if (pvm.Toppings.Pepperoni)
                    toppingList.Add("Pepperoni");
                if (pvm.Toppings.RealBacon)
                    toppingList.Add("RealBacon");
                if (pvm.Toppings.Sausage)
                    toppingList.Add("Sausage");
                if (pvm.Toppings.Spinach)
                    toppingList.Add("Spinach");

                if (toppingList.Count > 3)
                    throw new Exception("Only up to three toppings, please");

                pizza.FillToppingTable(toppingList);
            }
        }


        

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
