using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using EntityFrameWorkCodeAlong.Models;

namespace EntityFrameWorkCodeAlong.DataAccessLayer
{
    public class ShopContext : DbContext
    {
        public ShopContext() : base("MovieShopDb") { }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Format> Formats { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<MovieFormatStock> MovieFormatStocks { get; set; }
    }
}