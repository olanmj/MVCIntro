using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace MVCIntro.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        [Required(ErrorMessage = "Product name required")]
        [StringLength(20, ErrorMessage = "2 - 20 characters needed", MinimumLength = 2)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Description required")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Price required")]
        public decimal Price { get; set; }
        [Required(ErrorMessage = "Category required")]
        public string Category { set; get; }
    }

    public class ProductContext : DbContext
    {
       public DbSet<Product> Products { get; set; }
    }
}