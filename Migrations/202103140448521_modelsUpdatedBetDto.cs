namespace Bet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modelsUpdatedBetDto : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BetDtoes", "Team", c => c.String());
            DropColumn("dbo.BetImpls", "GameId");
            DropColumn("dbo.BetDtoes", "GameName");
            DropColumn("dbo.BetDtoes", "GroupId");
            DropColumn("dbo.BetDtoes", "GameId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.BetDtoes", "GameId", c => c.Int());
            AddColumn("dbo.BetDtoes", "GroupId", c => c.Int());
            AddColumn("dbo.BetDtoes", "GameName", c => c.String());
            AddColumn("dbo.BetImpls", "GameId", c => c.Int());
            DropColumn("dbo.BetDtoes", "Team");
        }
    }
}
