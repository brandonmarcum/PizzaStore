namespace PizzaStore.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sauce")]
    public partial class Sauce
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SauceId { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [Column(TypeName = "money")]
        public decimal Stock { get; set; }

        public bool Selected { get; set; }
    }
}
