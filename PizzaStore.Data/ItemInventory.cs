namespace PizzaStore.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ItemInventory")]
    public partial class ItemInventory
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ItemInventoryId { get; set; }

        public int? Location { get; set; }

        public int? Topping { get; set; }

        public int? Cheese { get; set; }

        public int? Sauce { get; set; }
    }
}
