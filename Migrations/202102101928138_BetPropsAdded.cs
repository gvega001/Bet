namespace Bet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BetPropsAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BetImpls", "MaxPossibleNumber", c => c.Double(nullable: false));
            AddColumn("dbo.BetImpls", "LowestPossibleNumber", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.BetImpls", "LowestPossibleNumber");
            DropColumn("dbo.BetImpls", "MaxPossibleNumber");
        }
    }
}
