namespace Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class check : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Expirydate", c => c.DateTime(nullable: false));
            DropColumn("dbo.Products", "PrExpirydate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "PrExpirydate", c => c.DateTime(nullable: false));
            DropColumn("dbo.Products", "Expirydate");
        }
    }
}
