namespace Bet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BetImplDtoUpdated : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BetImpls", "GameName", c => c.String());
            AddColumn("dbo.BetImpls", "MoneyBet", c => c.Int(nullable: false));
            DropColumn("dbo.BetImpls", "PlayerId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.BetImpls", "PlayerId", c => c.Int());
            DropColumn("dbo.BetImpls", "MoneyBet");
            DropColumn("dbo.BetImpls", "GameName");
        }
    }
}
