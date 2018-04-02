namespace PizzaStore.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Topping")]
    public partial class Topping
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ToppingId { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Column(TypeName = "money")]
        public decimal Stock { get; set; }

        public bool Selected { get; set; }

        public int Location { get; set; }
    }
}
