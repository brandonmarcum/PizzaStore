using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore.Data
{
    class EFData
    {
        private PizzaContext db = new PizzaContext();

        public List<Crust> Read()
        {
            return db.Crusts.ToList();
        }
    }
}
