namespace EntityFrameWorkCodeAlong.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 10),
                        CustomerNr = c.Int(nullable: false, identity: true),
                        Address = c.String(),
                        Phone = c.String(),
                        DateOfBirth = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        CustomerId = c.Int(nullable: false),
                        OrderDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        HasBeenSent = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .Index(t => t.CustomerId);
            
            CreateTable(
                "dbo.MovieFormatStocks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MovieId = c.Int(nullable: false),
                        FormatId = c.Int(nullable: false),
                        AmountInStock = c.Int(nullable: false),
                        ReleaseDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Formats", t => t.FormatId, cascadeDelete: true)
                .ForeignKey("dbo.Movies", t => t.MovieId, cascadeDelete: true)
                .Index(t => t.MovieId)
                .Index(t => t.FormatId);
            
            CreateTable(
                "dbo.Formats",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ReleaseDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Length = c.Int(nullable: false),
                        Title = c.String(nullable: false, maxLength: 35),
                        Director = c.String(),
                        Genre = c.String(),
                        Description = c.String(maxLength: 250),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MovieFormatStockOrders",
                c => new
                    {
                        MovieFormatStock_Id = c.Int(nullable: false),
                        Order_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.MovieFormatStock_Id, t.Order_Id })
                .ForeignKey("dbo.MovieFormatStocks", t => t.MovieFormatStock_Id, cascadeDelete: true)
                .ForeignKey("dbo.Orders", t => t.Order_Id, cascadeDelete: true)
                .Index(t => t.MovieFormatStock_Id)
                .Index(t => t.Order_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MovieFormatStockOrders", "Order_Id", "dbo.Orders");
            DropForeignKey("dbo.MovieFormatStockOrders", "MovieFormatStock_Id", "dbo.MovieFormatStocks");
            DropForeignKey("dbo.MovieFormatStocks", "MovieId", "dbo.Movies");
            DropForeignKey("dbo.MovieFormatStocks", "FormatId", "dbo.Formats");
            DropForeignKey("dbo.Orders", "CustomerId", "dbo.Customers");
            DropIndex("dbo.MovieFormatStockOrders", new[] { "Order_Id" });
            DropIndex("dbo.MovieFormatStockOrders", new[] { "MovieFormatStock_Id" });
            DropIndex("dbo.MovieFormatStocks", new[] { "FormatId" });
            DropIndex("dbo.MovieFormatStocks", new[] { "MovieId" });
            DropIndex("dbo.Orders", new[] { "CustomerId" });
            DropTable("dbo.MovieFormatStockOrders");
            DropTable("dbo.Movies");
            DropTable("dbo.Formats");
            DropTable("dbo.MovieFormatStocks");
            DropTable("dbo.Orders");
            DropTable("dbo.Customers");
        }
    }
}
