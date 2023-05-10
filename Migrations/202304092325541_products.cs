namespace Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class products : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Quantity", c => c.Int(nullable: false));
            AddColumn("dbo.Products", "Notes", c => c.String());
            AddColumn("dbo.Products", "Price", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "Price");
            DropColumn("dbo.Products", "Notes");
            DropColumn("dbo.Products", "Quantity");
        }
    }
}
