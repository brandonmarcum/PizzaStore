﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore.Library
{
    public class Location
    {
        public string City;
        public string State;
        public string Zip;
        public string Street;

        public void AddLocation(string c, string sta, string z, string str)
        {
            City = c;
            State = sta;
            Street = str;
            Zip = z;
        }

    }
}
