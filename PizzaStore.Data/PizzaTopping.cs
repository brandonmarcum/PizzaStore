namespace PizzaStore.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PizzaTopping")]
    public partial class PizzaTopping
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PizzaToppingId { get; set; }

        public int Pizza { get; set; }

        public int Topping { get; set; }
    }
}
