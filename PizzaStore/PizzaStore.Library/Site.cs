using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore.Library
{
    public class Site : Location
    {
        string Name { get; set; }

        public Site(string n, string sta, string str, string c, string z)
        {
            Name = n;
            City = c;
            State = sta;
            Street = str;
            Zip = z;
            AddLocation(c, sta, z, str);
        }
    }
}
