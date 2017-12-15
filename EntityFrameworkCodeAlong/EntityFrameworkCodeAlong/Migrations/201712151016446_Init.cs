namespace EntityFrameWorkCodeAlong.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CustomerNr = c.Int(nullable: false),
                        Adress = c.String(),
                        Phone = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .Index(t => t.CustomerId);
            
            CreateTable(
                "dbo.Formats",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MovieFormatStocks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MovieId = c.Int(nullable: false),
                        FormatId = c.Int(nullable: false),
                        AmountInStock = c.Int(nullable: false),
                        ReleaseDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Formats", t => t.FormatId, cascadeDelete: true)
                .ForeignKey("dbo.Movies", t => t.MovieId, cascadeDelete: true)
                .Index(t => t.MovieId)
                .Index(t => t.FormatId);
            
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ReleaseDate = c.DateTime(nullable: false),
                        Length = c.Int(nullable: false),
                        Title = c.String(),
                        Director = c.String(),
                        Genre = c.String(),
                        Descripttion = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MovieFormatStocks", "MovieId", "dbo.Movies");
            DropForeignKey("dbo.MovieFormatStocks", "FormatId", "dbo.Formats");
            DropForeignKey("dbo.Orders", "CustomerId", "dbo.Customers");
            DropIndex("dbo.MovieFormatStocks", new[] { "FormatId" });
            DropIndex("dbo.MovieFormatStocks", new[] { "MovieId" });
            DropIndex("dbo.Orders", new[] { "CustomerId" });
            DropTable("dbo.Movies");
            DropTable("dbo.MovieFormatStocks");
            DropTable("dbo.Formats");
            DropTable("dbo.Orders");
            DropTable("dbo.Customers");
        }
    }
}
