namespace Bet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIsSubcribed : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "IsSubscribed", c => c.Boolean());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "IsSubscribed");
        }
    }
}
