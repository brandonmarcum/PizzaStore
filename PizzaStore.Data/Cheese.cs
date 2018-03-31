namespace PizzaStore.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Cheese
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CheeseId { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [Column(TypeName = "money")]
        public decimal Stock { get; set; }

        public bool Selected { get; set; }
    }
}
