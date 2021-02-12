namespace Bet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ConsoleBetGameViewModels1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ConsoleBetGameViewModels", "Bet_Id", c => c.Int());
            AddColumn("dbo.ConsoleBetGameViewModels", "Game_Id", c => c.Int());
            CreateIndex("dbo.ConsoleBetGameViewModels", "GroupId");
            CreateIndex("dbo.ConsoleBetGameViewModels", "Bet_Id");
            CreateIndex("dbo.ConsoleBetGameViewModels", "Game_Id");
            AddForeignKey("dbo.ConsoleBetGameViewModels", "Bet_Id", "dbo.BetImpls", "Id");
            AddForeignKey("dbo.ConsoleBetGameViewModels", "Game_Id", "dbo.GameImpls", "Id");
            AddForeignKey("dbo.ConsoleBetGameViewModels", "GroupId", "dbo.GroupImpls", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ConsoleBetGameViewModels", "GroupId", "dbo.GroupImpls");
            DropForeignKey("dbo.ConsoleBetGameViewModels", "Game_Id", "dbo.GameImpls");
            DropForeignKey("dbo.ConsoleBetGameViewModels", "Bet_Id", "dbo.BetImpls");
            DropIndex("dbo.ConsoleBetGameViewModels", new[] { "Game_Id" });
            DropIndex("dbo.ConsoleBetGameViewModels", new[] { "Bet_Id" });
            DropIndex("dbo.ConsoleBetGameViewModels", new[] { "GroupId" });
            DropColumn("dbo.ConsoleBetGameViewModels", "Game_Id");
            DropColumn("dbo.ConsoleBetGameViewModels", "Bet_Id");
        }
    }
}
