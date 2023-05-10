namespace Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class productsEdit : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "UnitsOfPriMeasure", c => c.String());
            AlterColumn("dbo.Products", "Code", c => c.String());
            AlterColumn("dbo.Products", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "Price", c => c.String());
            AlterColumn("dbo.Products", "Code", c => c.Int(nullable: false));
            DropColumn("dbo.Products", "UnitsOfPriMeasure");
        }
    }
}
