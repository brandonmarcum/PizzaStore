namespace PizzaStore.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PizzaOrder")]
    public partial class PizzaOrder
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PizzaOrderId { get; set; }

        public int Pizza { get; set; }

        public int Order { get; set; }
    }
}
