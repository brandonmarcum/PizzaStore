using System.ComponentModel.DataAnnotations;

namespace PizzaStore.Library.Models
{
    class Crust
    {
        [Key]
        public string Name { get; set; }
        public double Cost { get; set; }
        public bool Selected { get; set; }


        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
