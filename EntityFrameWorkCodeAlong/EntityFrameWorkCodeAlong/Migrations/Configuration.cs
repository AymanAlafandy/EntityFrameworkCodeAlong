namespace EntityFrameWorkCodeAlong.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EntityFrameWorkCodeAlong.DataAccessLayer.ShopContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EntityFrameWorkCodeAlong.DataAccessLayer.ShopContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Formats.AddOrUpdate(x => x.Name,
                new Models.Format() { Name = "DVD" },
                new Models.Format() { Name = "BluRay" });

            context.Movies.AddOrUpdate(x => x.Title,
                new Models.Movie() { Title = "Sraw Rats", Genre = "SciFi", Length = 230, Director = "BOB", ReleaseDate = DateTime.Now.AddYears(-35), Description = "" },
                new Models.Movie() { Title = "Kert Rats", Genre = "SciFi", Length = 230, Director = "BOB", ReleaseDate = DateTime.Now.AddYears(-5), Description = "" },
                new Models.Movie() { Title = "Kerhs", Genre = "SciFi", Length = 120, Director = "BOB", ReleaseDate = DateTime.Now.AddYears(-25), Description = "" },
                new Models.Movie() { Title = "Etag Rats", Genre = "SciFi", Length = 72, Director = "BOB", ReleaseDate = DateTime.Now.AddYears(-35), Description = "" });

            context.Customers.AddOrUpdate(x => x.Name,
                new Models.Customer() {Name="Billy",
                    DateOfBirth = DateTime.Now.AddYears(-5),
                    CustomerNr =152, Adress ="Blabla Street 0",
                    Phone = "555-555555" },
                new Models.Customer() { Name = "Steve",
                    DateOfBirth = DateTime.Now.AddYears(-50),
                    CustomerNr = 1232, Adress = "Blabla Street 0",
                    Phone = "555-555555" },
                new Models.Customer() { Name = "Sara",
                    DateOfBirth = DateTime.Now.AddYears(-35),
                    CustomerNr = 12, Adress = "Blabla Street 0",
                    Phone = "555-555555" });

            context.SaveChanges();

            foreach(Models.Movie m in context.Movies)
            {
                context.MovieFormatStocks.AddOrUpdate(x => x.ReleaseDate,

                    new Models.MovieFormatStock() {
                        AmountInStock = 100,
                        FormatId = context.Formats.ToList()[0].Id,
                        MovieId = m.Id,
                        ReleaseDate = m.ReleaseDate.AddMonths(2) },

                    new Models.MovieFormatStock() {
                        AmountInStock = (50*m.Id)+m.Id,
                        FormatId = context.Formats.ToList()[1].Id,
                        MovieId = m.Id,
                        ReleaseDate = m.ReleaseDate.AddMonths(2) }
                    );
            }
            context.SaveChanges();

            int i = 1;
            foreach(Models.Customer c in context.Customers)
            {
                context.Orders.AddOrUpdate(x => x.OrderDate,
                    new Models.Order() {
                        CustomerId = c.Id,
                        HasBeenSent = false,
                        OrderDate = DateTime.Now.AddYears(-(2 + c.Id)),
                        OrderNr = i * i * 2,
                        MovieFormats = new List<Models.MovieFormatStock> { context.MovieFormatStocks.ToList()[i++]}
                    }, 
                    new Models.Order()
                    {
                        CustomerId = c.Id,
                        HasBeenSent = false,
                        OrderDate = DateTime.Now.AddYears(-(1 + c.Id)),
                        OrderNr = i * i * 3,
                        MovieFormats = new List<Models.MovieFormatStock>() { context.MovieFormatStocks.ToList()[i++] }
                    });
            }
            context.SaveChanges();
            
        }
    }
}
