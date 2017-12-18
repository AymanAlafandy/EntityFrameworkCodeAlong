using EntityFrameworkCodeAlong.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EntityFrameworkCodeAlong.DataAccessLayer
{
    public class ShopContext : DbContext
    {
        public ShopContext() : base("MovieShopDB")
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Format> Formats { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<MovieFormatStock> MFStocks { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}