using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace PizzaStore.Data
{
    public class PizzaContext : DbContext
    {
        public IConfiguration Configuration { get; set; }
        public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<Crust> Crusts { get; set; }
        public DbSet<Cheese> Cheeses { get; set; }
        public DbSet<Sauce> Sauces { get; set; }
        public DbSet<Topping> Toppings { get; set; }
        public DbSet<PizzaTopping> PizzaToppings { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<PizzaOrder> PizzaOrders { get; set; }
        public DbSet<Order> Orders { get; set; }

        public PizzaContext()
        {
            Configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer(Configuration.GetSection("connectionstring").Value);
        }
    }
}
