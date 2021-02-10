namespace Bet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GameImplePropsAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BetImpls", "GameImpl_Id", c => c.Int());
            AddColumn("dbo.GameImpls", "Team1Score", c => c.Double(nullable: false));
            AddColumn("dbo.GameImpls", "Team2Score", c => c.Double(nullable: false));
            AddColumn("dbo.GameImpls", "PlayerGuess", c => c.Double(nullable: false));
            AddColumn("dbo.GameImpls", "SmallestPossibleNumber", c => c.Double(nullable: false));
            AddColumn("dbo.GameImpls", "LargestPossibleNumber", c => c.Double(nullable: false));
            AddColumn("dbo.GameImpls", "GameConfirmed", c => c.Boolean(nullable: false));
            AddColumn("dbo.GameImpls", "BetsConfirmed", c => c.Boolean(nullable: false));
            AddColumn("dbo.GameImpls", "LockGame", c => c.Boolean(nullable: false));
            AddColumn("dbo.GameImpls", "GameWon", c => c.Boolean(nullable: false));
            CreateIndex("dbo.BetImpls", "GameImpl_Id");
            AddForeignKey("dbo.BetImpls", "GameImpl_Id", "dbo.GameImpls", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BetImpls", "GameImpl_Id", "dbo.GameImpls");
            DropIndex("dbo.BetImpls", new[] { "GameImpl_Id" });
            DropColumn("dbo.GameImpls", "GameWon");
            DropColumn("dbo.GameImpls", "LockGame");
            DropColumn("dbo.GameImpls", "BetsConfirmed");
            DropColumn("dbo.GameImpls", "GameConfirmed");
            DropColumn("dbo.GameImpls", "LargestPossibleNumber");
            DropColumn("dbo.GameImpls", "SmallestPossibleNumber");
            DropColumn("dbo.GameImpls", "PlayerGuess");
            DropColumn("dbo.GameImpls", "Team2Score");
            DropColumn("dbo.GameImpls", "Team1Score");
            DropColumn("dbo.BetImpls", "GameImpl_Id");
        }
    }
}
