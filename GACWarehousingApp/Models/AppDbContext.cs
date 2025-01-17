﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Threading.Tasks;

namespace GACWarehousingApp.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options)
            : base(options)
        {
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet <Product> Products { get; set; }

        public DbSet <Manufacturer> Manufacturers { get; set; }

        public DbSet <SalesOrder> SalesOrders { get; set; }
    }
    
}
