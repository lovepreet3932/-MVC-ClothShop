using _MVC_ClothShop.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace _MVC_ClothShop.Data
{
    


    public class ClothShopDbContext : DbContext
    {
        public DbSet<Brand> Brand { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Order> Order { get; set; }
        public ClothShopDbContext(DbContextOptions<ClothShopDbContext> options)
            : base(options)
        {
        }
        public ClothShopDbContext()
        {

        }
    }
}
