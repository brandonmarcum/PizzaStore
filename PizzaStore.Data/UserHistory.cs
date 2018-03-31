namespace PizzaStore.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserHistory")]
    public partial class UserHistory
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserHistoryId { get; set; }

        public int Order { get; set; }

        public DateTime TimeSinceLast { get; set; }
    }
}
