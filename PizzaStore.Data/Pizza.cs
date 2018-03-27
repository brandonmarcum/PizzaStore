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
        public int PizzaId { get; set; }

        public int PizzaTopping { get; set; }

        public int Size { get; set; }

        public int Crust { get; set; }

        public virtual Crust Crust1 { get; set; }

        public virtual PizzaTopping PizzaTopping1 { get; set; }

        public virtual Size Size1 { get; set; }
    }
}
