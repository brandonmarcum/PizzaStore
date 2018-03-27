namespace PizzaStore.Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class PizzaDB : DbContext
    {
        public PizzaDB()
            : base("name=PizzaDB")
        {
        }

        public virtual DbSet<Crust> Crusts { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Inventory> Inventories { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Pizza> Pizzas { get; set; }
        public virtual DbSet<PizzaTopping> PizzaToppings { get; set; }
        public virtual DbSet<Size> Sizes { get; set; }
        public virtual DbSet<Topping> Toppings { get; set; }
        public virtual DbSet<ToppingInventory> ToppingInventories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Crust>()
                .Property(e => e.DoughConsu)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Crust>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Crust>()
                .HasMany(e => e.Pizzas)
                .WithRequired(e => e.Crust1)
                .HasForeignKey(e => e.Crust)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Inventory>()
                .Property(e => e.Dough)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Inventory>()
                .Property(e => e.Sauce)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Inventory>()
                .HasMany(e => e.ToppingInventories)
                .WithRequired(e => e.Inventory1)
                .HasForeignKey(e => e.Inventory)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Location>()
                .HasMany(e => e.Inventories)
                .WithRequired(e => e.Location1)
                .HasForeignKey(e => e.Location)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PizzaTopping>()
                .HasMany(e => e.Pizzas)
                .WithRequired(e => e.PizzaTopping1)
                .HasForeignKey(e => e.PizzaTopping)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Size>()
                .Property(e => e.DoughConsu)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Size>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Size>()
                .HasMany(e => e.Pizzas)
                .WithRequired(e => e.Size1)
                .HasForeignKey(e => e.Size)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Topping>()
                .HasMany(e => e.PizzaToppings)
                .WithRequired(e => e.Topping1)
                .HasForeignKey(e => e.Topping)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Topping>()
                .HasMany(e => e.ToppingInventories)
                .WithRequired(e => e.Topping1)
                .HasForeignKey(e => e.Topping)
                .WillCascadeOnDelete(false);
        }
    }
}
