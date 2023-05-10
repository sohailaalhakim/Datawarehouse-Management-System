﻿namespace Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class userimage : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Image", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "Image");
        }
    }
}
