using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaStore.Library;

namespace PizzaStore.Data
{
    public class EFData
    {
        private PizzaContext db = new PizzaContext();

        public List<Crust> Read()
        {
            return db.Crusts.ToList();
        }
    }
}
