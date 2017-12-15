namespace EntityFrameWorkCodeAlong.Migrations
{
    using System;
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

            //context.Formats.AddOrUpdate(x => x.Name,
            //    new Models.Format() { Name = "DVD" },
            //    new Models.Format() { Name = "BlueRay" });

            //context.Movies.AddOrUpdate(x => x.Title,
            //    new Models.Movie() { Title = "Sraw Rats", Genre = "SciFi", Length = 230, Description = "BOB", ReleaseDate = DateTime.Now.AddYears(-8), Director = "Jack" },
            //    new Models.Movie() { Title = "Sraw Rats", Genre = "SciFi", Length = 230, Description = "BOB", ReleaseDate = DateTime.Now.AddYears(-8), Director = "Jack" });


            ////context.Customers.AddOrUpdate(x => x.Name
            ////new Models.Customer() { });


            ////this is required otherwise we can't use foreign keys
        
            //context.SaveChanges();

            ////foreach (Models.Movie m in context.Movies)
            ////{
            ////    context.MovieFormatStocks.AddOrUpdate(x => x.ReleaseDate,
            ////    new Models.MovieFormatStock() { AmountInStock = 100, FormatId = context.Formats.First().Id, MovieId = m.Id, ReleaseDate = m.ReleaseDate.AddMonths(2) }
            ////    );
            ////}
        }
    }
 }
