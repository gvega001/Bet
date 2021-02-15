namespace Bet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BetImplModeUpdated3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.BetViewModels", "Bet_Id", "dbo.BetImpls");
            DropForeignKey("dbo.BetViewModels", "Player_Id", "dbo.AspNetUsers");
            DropIndex("dbo.BetViewModels", new[] { "Bet_Id" });
            DropIndex("dbo.BetViewModels", new[] { "Player_Id" });
            AlterColumn("dbo.BetImpls", "PlayerId", c => c.Int());
            AlterColumn("dbo.BetImpls", "Guess", c => c.Double());
            DropColumn("dbo.BetViewModels", "Bet_Id");
            DropColumn("dbo.BetViewModels", "Player_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.BetViewModels", "Player_Id", c => c.String(maxLength: 128));
            AddColumn("dbo.BetViewModels", "Bet_Id", c => c.Int());
            AlterColumn("dbo.BetImpls", "Guess", c => c.Double(nullable: false));
            AlterColumn("dbo.BetImpls", "PlayerId", c => c.Int(nullable: false));
            CreateIndex("dbo.BetViewModels", "Player_Id");
            CreateIndex("dbo.BetViewModels", "Bet_Id");
            AddForeignKey("dbo.BetViewModels", "Player_Id", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.BetViewModels", "Bet_Id", "dbo.BetImpls", "Id");
        }
    }
}
