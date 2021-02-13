namespace Bet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BetImplNullablesAddedToModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BetImpls", "GameId", c => c.Int());
            AlterColumn("dbo.BetImpls", "MaxPossibleNumber", c => c.Double());
            AlterColumn("dbo.BetImpls", "LowestPossibleNumber", c => c.Double());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.BetImpls", "LowestPossibleNumber", c => c.Double(nullable: false));
            AlterColumn("dbo.BetImpls", "MaxPossibleNumber", c => c.Double(nullable: false));
            DropColumn("dbo.BetImpls", "GameId");
        }
    }
}
