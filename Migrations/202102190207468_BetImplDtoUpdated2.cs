namespace Bet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BetImplDtoUpdated2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.BetImpls", "MaxPossibleNumber");
            DropColumn("dbo.BetImpls", "LowestPossibleNumber");
        }
        
        public override void Down()
        {
            AddColumn("dbo.BetImpls", "LowestPossibleNumber", c => c.Double());
            AddColumn("dbo.BetImpls", "MaxPossibleNumber", c => c.Double());
        }
    }
}
