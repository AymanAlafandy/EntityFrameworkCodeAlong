namespace EntityFrameWorkCodeAlong.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init4 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.MovieFormatStockOrders", "MovieFormatStock_Id", "dbo.MovieFormatStocks");
            DropForeignKey("dbo.MovieFormatStockOrders", "Order_Id", "dbo.Orders");
            DropIndex("dbo.MovieFormatStockOrders", new[] { "MovieFormatStock_Id" });
            DropIndex("dbo.MovieFormatStockOrders", new[] { "Order_Id" });
            AddColumn("dbo.Orders", "OrderNr", c => c.Int(nullable: false));
            AddColumn("dbo.Orders", "OrderDate", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AddColumn("dbo.Orders", "HasBeenSent", c => c.Boolean(nullable: false));
            AddColumn("dbo.Orders", "MovieFormatStock_Id", c => c.Int());
            AddColumn("dbo.MovieFormatStocks", "Order_Id", c => c.Int());
            AddColumn("dbo.MovieFormatStocks", "Order_Id1", c => c.Int());
            AlterColumn("dbo.Customers", "Name", c => c.String(maxLength: 10));
            AlterColumn("dbo.Customers", "Phone", c => c.String());
            AlterColumn("dbo.Customers", "DateOfBirth", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            CreateIndex("dbo.Orders", "MovieFormatStock_Id");
            CreateIndex("dbo.MovieFormatStocks", "Order_Id");
            CreateIndex("dbo.MovieFormatStocks", "Order_Id1");
            AddForeignKey("dbo.Orders", "MovieFormatStock_Id", "dbo.MovieFormatStocks", "Id");
            AddForeignKey("dbo.MovieFormatStocks", "Order_Id", "dbo.Orders", "Id");
            AddForeignKey("dbo.MovieFormatStocks", "Order_Id1", "dbo.Orders", "Id");
            DropTable("dbo.MovieFormatStockOrders");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.MovieFormatStockOrders",
                c => new
                    {
                        MovieFormatStock_Id = c.Int(nullable: false),
                        Order_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.MovieFormatStock_Id, t.Order_Id });
            
            DropForeignKey("dbo.MovieFormatStocks", "Order_Id1", "dbo.Orders");
            DropForeignKey("dbo.MovieFormatStocks", "Order_Id", "dbo.Orders");
            DropForeignKey("dbo.Orders", "MovieFormatStock_Id", "dbo.MovieFormatStocks");
            DropIndex("dbo.MovieFormatStocks", new[] { "Order_Id1" });
            DropIndex("dbo.MovieFormatStocks", new[] { "Order_Id" });
            DropIndex("dbo.Orders", new[] { "MovieFormatStock_Id" });
            AlterColumn("dbo.Customers", "DateOfBirth", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Customers", "Phone", c => c.Int(nullable: false));
            AlterColumn("dbo.Customers", "Name", c => c.String());
            DropColumn("dbo.MovieFormatStocks", "Order_Id1");
            DropColumn("dbo.MovieFormatStocks", "Order_Id");
            DropColumn("dbo.Orders", "MovieFormatStock_Id");
            DropColumn("dbo.Orders", "HasBeenSent");
            DropColumn("dbo.Orders", "OrderDate");
            DropColumn("dbo.Orders", "OrderNr");
            CreateIndex("dbo.MovieFormatStockOrders", "Order_Id");
            CreateIndex("dbo.MovieFormatStockOrders", "MovieFormatStock_Id");
            AddForeignKey("dbo.MovieFormatStockOrders", "Order_Id", "dbo.Orders", "Id", cascadeDelete: true);
            AddForeignKey("dbo.MovieFormatStockOrders", "MovieFormatStock_Id", "dbo.MovieFormatStocks", "Id", cascadeDelete: true);
        }
    }
}
