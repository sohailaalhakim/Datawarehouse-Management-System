namespace Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class datepicker : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "ProductionDate", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Products", "PrExpirydate", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "PrExpirydate");
            DropColumn("dbo.Products", "ProductionDate");
        }
    }
}
