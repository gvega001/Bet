namespace Bet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewBetViewModelAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BetViewModels", "Bet_Id", c => c.Int());
            CreateIndex("dbo.BetViewModels", "Bet_Id");
            AddForeignKey("dbo.BetViewModels", "Bet_Id", "dbo.BetImpls", "Id");
            DropColumn("dbo.BetViewModels", "PlayerId");
            DropColumn("dbo.BetViewModels", "MaxPossibleNumber");
            DropColumn("dbo.BetViewModels", "LowestPossibleNumber");
            DropColumn("dbo.BetViewModels", "Guess");
        }
        
        public override void Down()
        {
            AddColumn("dbo.BetViewModels", "Guess", c => c.Double(nullable: false));
            AddColumn("dbo.BetViewModels", "LowestPossibleNumber", c => c.Double(nullable: false));
            AddColumn("dbo.BetViewModels", "MaxPossibleNumber", c => c.Double(nullable: false));
            AddColumn("dbo.BetViewModels", "PlayerId", c => c.Int(nullable: false));
            DropForeignKey("dbo.BetViewModels", "Bet_Id", "dbo.BetImpls");
            DropIndex("dbo.BetViewModels", new[] { "Bet_Id" });
            DropColumn("dbo.BetViewModels", "Bet_Id");
        }
    }
}
