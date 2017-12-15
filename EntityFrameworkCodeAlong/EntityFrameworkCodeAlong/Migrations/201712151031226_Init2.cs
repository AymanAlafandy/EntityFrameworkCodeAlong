namespace EntityFrameWorkCodeAlong.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init2 : DbMigration
    {
        public override void Up()
        {
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
            DropIndex("dbo.MovieFormatStockOrders", new[] { "Order_Id" });
            DropIndex("dbo.MovieFormatStockOrders", new[] { "MovieFormatStock_Id" });
            DropTable("dbo.MovieFormatStockOrders");
        }
    }
}
