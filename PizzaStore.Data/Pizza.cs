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

        public int Crust { get; set; }

        public int Size { get; set; }

        public int Sauce { get; set; }
    }
}
