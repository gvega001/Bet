namespace Bet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PlayerUpdated2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.AspNetUsers", "Subscribed");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "Subscribed", c => c.Boolean());
        }
    }
}
