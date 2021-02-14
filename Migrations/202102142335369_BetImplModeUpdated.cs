namespace Bet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BetImplModeUpdated : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BetImpls", "GroupId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.BetImpls", "GroupId");
        }
    }
}
