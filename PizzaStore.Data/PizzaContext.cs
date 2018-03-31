﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace PizzaStore.Data
{
    class PizzaContext : DbContext
    {
        public IConfiguration Configuration { get; set; }
        public DbSet<Crust> Crusts { get; set; }

        public PizzaContext()
        {
            Configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer(Configuration.GetSection("connectionstring").Value);
        }
    }
}
