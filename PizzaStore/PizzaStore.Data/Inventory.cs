namespace PizzaStore.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Inventory")]
    public partial class Inventory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Inventory()
        {
            ToppingInventories = new HashSet<ToppingInventory>();
        }

        public int InventoryId { get; set; }

        public int Location { get; set; }

        [Column(TypeName = "money")]
        public decimal Dough { get; set; }

        [Column(TypeName = "money")]
        public decimal Sauce { get; set; }

        public virtual Location Location1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ToppingInventory> ToppingInventories { get; set; }
    }
}
