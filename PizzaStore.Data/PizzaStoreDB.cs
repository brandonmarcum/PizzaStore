namespace PizzaStore.Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class PizzaStoreDB : DbContext
    {
        public PizzaStoreDB()
            : base("name=PizzaStoreDB1")
        {
        }

        public virtual DbSet<Cheese> Cheese { get; set; }
        public virtual DbSet<Crust> Crusts { get; set; }
        public virtual DbSet<ItemInventory> ItemInventories { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Pizza> Pizzas { get; set; }
        public virtual DbSet<PizzaOrder> PizzaOrders { get; set; }
        public virtual DbSet<Sauce> Sauces { get; set; }
        public virtual DbSet<Size> Sizes { get; set; }
        public virtual DbSet<Topping> Toppings { get; set; }
        public virtual DbSet<UserHistory> UserHistories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cheese>()
                .Property(e => e.Stock)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Crust>()
                .Property(e => e.Dough)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Crust>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Location>()
                .Property(e => e.State)
                .IsUnicode(false);

            modelBuilder.Entity<Location>()
                .Property(e => e.ZipCode)
                .IsUnicode(false);

            modelBuilder.Entity<Location>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Location>()
                .Property(e => e.dough)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Order>()
                .Property(e => e.Cost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Sauce>()
                .Property(e => e.Stock)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Size>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Size>()
                .Property(e => e.Dough)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Topping>()
                .Property(e => e.Stock)
                .HasPrecision(19, 4);
        }
    }
}
