namespace PizzaStore.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Crust")]
    public partial class Crust
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CrustId { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [Column(TypeName = "money")]
        public decimal Dough { get; set; }

        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        public bool Selected { get; set; }
    }
}
