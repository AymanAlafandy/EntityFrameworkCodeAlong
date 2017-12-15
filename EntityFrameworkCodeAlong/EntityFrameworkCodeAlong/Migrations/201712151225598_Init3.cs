namespace EntityFrameWorkCodeAlong.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.MovieFormatStocks", "ReleaseDate", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Formats", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Movies", "ReleaseDate", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Movies", "Title", c => c.String(nullable: false, maxLength: 25));
            AlterColumn("dbo.Movies", "Description", c => c.String(maxLength: 250));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "Description", c => c.String());
            AlterColumn("dbo.Movies", "Title", c => c.String());
            AlterColumn("dbo.Movies", "ReleaseDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Formats", "Name", c => c.String());
            AlterColumn("dbo.MovieFormatStocks", "ReleaseDate", c => c.DateTime(nullable: false));
        }
    }
}
