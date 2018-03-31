namespace PizzaStore.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Location")]
    public partial class Location
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LocationId { get; set; }

        [Required]
        [StringLength(150)]
        public string Name { get; set; }

        [Required]
        [StringLength(150)]
        public string Street { get; set; }

        [Required]
        [StringLength(2)]
        public string State { get; set; }

        [Required]
        [StringLength(5)]
        public string ZipCode { get; set; }

        [Required]
        [StringLength(13)]
        public string Phone { get; set; }

        [StringLength(150)]
        public string Email { get; set; }

        [Column(TypeName = "money")]
        public decimal dough { get; set; }
    }
}
