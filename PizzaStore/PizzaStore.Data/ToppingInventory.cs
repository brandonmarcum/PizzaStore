namespace PizzaStore.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ToppingInventory")]
    public partial class ToppingInventory
    {
        public int ToppingInventoryId { get; set; }

        public int Inventory { get; set; }

        public int Topping { get; set; }

        public virtual Inventory Inventory1 { get; set; }

        public virtual Topping Topping1 { get; set; }
    }
}
