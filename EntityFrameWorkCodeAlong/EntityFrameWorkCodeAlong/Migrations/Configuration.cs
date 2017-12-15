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

            context.Formats.AddOrUpdate(x => x.Name,
                new Models.Format() { Name = "DVD" },
                new Models.Format() { Name = "Bluray" });
            context.Movies.AddOrUpdate(x => x.Title,
                new Models.Movie() { Title = "Scorpion King", Genre = "Bollywood", Length = 120, ReleaseDate = DateTime.Now.AddYears(-35), Description = "", Director = "Jonny" },
                new Models.Movie() { Title = "Scorpion King1", Genre = "Bollywood", Length = 120, ReleaseDate = DateTime.Now.AddYears(-25), Description = "", Director = "Jonny3" },
            new Models.Movie() { Title = "Scorpion King2", Genre = "Bollywood", Length = 120, ReleaseDate = DateTime.Now.AddYears(-15), Description = "", Director = "Jonny2" },
            new Models.Movie() { Title = "Scorpion King3", Genre = "Bollywood", Length = 120, ReleaseDate = DateTime.Now.AddYears(-10), Description = "", Director = "Jonny54"},
            new Models.Movie() { Title = "Scorpion King4", Genre = "Bollywood", Length = 120, ReleaseDate = DateTime.Now.AddYears(-5), Description = "", Director = "Jonny2" },


            context.Customers.AddOrUpdate(xy => xy.Name,
                new Models.Customer() { Name = "Sunny", DateOfBirth = DateTime.Now.AddYears(-25), Adress = "xyz street", Phone = "123445" },
            new Models.Customer() { Name = "bunny", DateOfBirth = DateTime.Now.AddYears(-25), Adress = "abc street", Phone = "123445" },
            new Models.Customer() { Name = "funny", DateOfBirth = DateTime.Now.AddYears(-25), Adress = "mnq street", Phone = "123445" });



        }


    }
}
