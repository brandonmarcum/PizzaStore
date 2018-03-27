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
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Topping()
        {
            PizzaToppings = new HashSet<PizzaTopping>();
            ToppingInventories = new HashSet<ToppingInventory>();
        }

        public int ToppingId { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public int Stock { get; set; }

        public bool Selected { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PizzaTopping> PizzaToppings { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ToppingInventory> ToppingInventories { get; set; }
    }
}
