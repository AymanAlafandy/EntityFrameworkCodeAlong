namespace EntityFrameWorkCodeAlong.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Shop : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CustomerNr = c.Int(nullable: false),
                        Address = c.String(),
                        Phone = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Formats",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ReleaseDate = c.DateTime(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.MovieFormatStocks",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        AmountInStock = c.Int(nullable: false),
                        ReleaseDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MovieFormatStocks");
            DropTable("dbo.Orders");
            DropTable("dbo.Movies");
            DropTable("dbo.Formats");
            DropTable("dbo.Customers");
        }
    }
}
