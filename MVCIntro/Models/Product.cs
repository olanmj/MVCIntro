﻿using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace MVCIntro.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Category { set; get; }
    }

    public class ProductContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}