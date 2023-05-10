namespace Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class datepicker1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "ProductionDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Products", "PrExpirydate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "PrExpirydate", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Products", "ProductionDate", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
