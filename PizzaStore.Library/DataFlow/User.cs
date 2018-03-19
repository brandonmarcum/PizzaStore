using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore.Library
{
    public class User : Location
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string Email { get; set; }
        string Phone { get; set; }
        bool Rewards { get; set; }

        public User(string fn, string ln, string e, string p, bool r, string sta, string str, string c, string z)
        {
            FirstName = fn;
            LastName = ln;
            Email = e;
            Phone = p;
            Rewards = r;
            City = c;
            State = sta;
            Street = str;
            Zip = z;
        }
    }
}
