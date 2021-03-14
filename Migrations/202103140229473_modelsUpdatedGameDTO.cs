namespace Bet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modelsUpdatedGameDTO : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.BetImpls", "GameImpl_Id", "dbo.GameImpls");
            DropForeignKey("dbo.BetImpls", "GameDto_Id", "dbo.GameDtoes");
            DropIndex("dbo.BetImpls", new[] { "GameImpl_Id" });
            DropIndex("dbo.BetImpls", new[] { "GameDto_Id" });
            AddColumn("dbo.GameImpls", "Team2Score", c => c.Double(nullable: false));
            DropColumn("dbo.BetImpls", "GameImpl_Id");
            DropColumn("dbo.BetImpls", "GameDto_Id");
            DropColumn("dbo.GameImpls", "GroupId");
            DropColumn("dbo.GameImpls", "SmallestPossibleNumber");
            DropColumn("dbo.GameImpls", "LargestPossibleNumber");
            DropColumn("dbo.GameDtoes", "GroupId");
            DropColumn("dbo.GameDtoes", "SmallestPossibleNumber");
            DropColumn("dbo.GameDtoes", "LargestPossibleNumber");
        }
        
        public override void Down()
        {
            AddColumn("dbo.GameDtoes", "LargestPossibleNumber", c => c.Double());
            AddColumn("dbo.GameDtoes", "SmallestPossibleNumber", c => c.Double());
            AddColumn("dbo.GameDtoes", "GroupId", c => c.Int());
            AddColumn("dbo.GameImpls", "LargestPossibleNumber", c => c.Double());
            AddColumn("dbo.GameImpls", "SmallestPossibleNumber", c => c.Double());
            AddColumn("dbo.GameImpls", "GroupId", c => c.Int());
            AddColumn("dbo.BetImpls", "GameDto_Id", c => c.Int());
            AddColumn("dbo.BetImpls", "GameImpl_Id", c => c.Int());
            DropColumn("dbo.GameImpls", "Team2Score");
            CreateIndex("dbo.BetImpls", "GameDto_Id");
            CreateIndex("dbo.BetImpls", "GameImpl_Id");
            AddForeignKey("dbo.BetImpls", "GameDto_Id", "dbo.GameDtoes", "Id");
            AddForeignKey("dbo.BetImpls", "GameImpl_Id", "dbo.GameImpls", "Id");
        }
    }
}
