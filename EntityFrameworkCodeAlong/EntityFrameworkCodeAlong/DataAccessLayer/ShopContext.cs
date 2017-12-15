using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using EntityFrameWorkCodeAlong.Models;

namespace EntityFrameWorkCodeAlong.DataAccessLayer
{
    public class ShopContext:DbContext
    {
        public ShopContext() : base("MoviehopDb") { }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Format> Format { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<MovieFormatStock> Stock { get; set; }
        public DbSet<Order> Order { get; set; }

    }
}