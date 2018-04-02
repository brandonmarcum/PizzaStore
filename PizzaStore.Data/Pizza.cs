namespace PizzaStore.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Pizza")]
    public partial class Pizza
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PizzaId { get; set; }

        [Required]
        [StringLength(100)]
        public string Crust { get; set; }

        [Required]
        [StringLength(100)]
        public string Size { get; set; }

        [Required]
        [StringLength(100)]
        public string Sauce { get; set; }

        [Required]
        [StringLength(100)]
        public string FirstCheese { get; set; }

        [Required]
        [StringLength(100)]
        public string SecondCheese { get; set; }

        [Column(TypeName = "money")]
        public decimal Cost { get; set; }
    }
}
