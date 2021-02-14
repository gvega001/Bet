namespace Bet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BetImplModeUpdated2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ConsoleBetGameViewModels", "Bet_Id", "dbo.BetImpls");
            DropForeignKey("dbo.BetImpls", "ConsoleBetGameViewModel_Id", "dbo.ConsoleBetGameViewModels");
            DropForeignKey("dbo.ConsoleBetGameViewModels", "GroupId", "dbo.GroupImpls");
            DropForeignKey("dbo.ConsoleBetGameViewModels", "Player_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.GroupViewModels", "BetId", "dbo.BetImpls");
            DropForeignKey("dbo.BetImpls", "GroupViewModels_Id", "dbo.GroupViewModels");
            DropForeignKey("dbo.GroupViewModels", "Player_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUsers", "GroupViewModels_Id", "dbo.GroupViewModels");
            DropIndex("dbo.BetImpls", new[] { "ConsoleBetGameViewModel_Id" });
            DropIndex("dbo.BetImpls", new[] { "GroupViewModels_Id" });
            DropIndex("dbo.AspNetUsers", new[] { "GroupViewModels_Id" });
            DropIndex("dbo.ConsoleBetGameViewModels", new[] { "GroupId" });
            DropIndex("dbo.ConsoleBetGameViewModels", new[] { "Bet_Id" });
            DropIndex("dbo.ConsoleBetGameViewModels", new[] { "Player_Id" });
            DropIndex("dbo.GroupViewModels", new[] { "BetId" });
            DropIndex("dbo.GroupViewModels", new[] { "Player_Id" });
            RenameColumn(table: "dbo.ConsoleBetGameViewModels", name: "Game_Id", newName: "GameImpl_Id");
            RenameColumn(table: "dbo.GroupViewModels", name: "Group_Id", newName: "GroupImpl_Id");
            RenameIndex(table: "dbo.ConsoleBetGameViewModels", name: "IX_Game_Id", newName: "IX_GameImpl_Id");
            RenameIndex(table: "dbo.GroupViewModels", name: "IX_Group_Id", newName: "IX_GroupImpl_Id");
            AlterColumn("dbo.BetImpls", "GroupId", c => c.Int());
            DropColumn("dbo.BetImpls", "ConsoleBetGameViewModel_Id");
            DropColumn("dbo.BetImpls", "GroupViewModels_Id");
            DropColumn("dbo.AspNetUsers", "GroupViewModels_Id");
            DropColumn("dbo.ConsoleBetGameViewModels", "GroupId");
            DropColumn("dbo.ConsoleBetGameViewModels", "TeamName");
            DropColumn("dbo.ConsoleBetGameViewModels", "TeamScore");
            DropColumn("dbo.ConsoleBetGameViewModels", "PlayerGuess");
            DropColumn("dbo.ConsoleBetGameViewModels", "SmallestPossibleNumber");
            DropColumn("dbo.ConsoleBetGameViewModels", "LargestPossibleNumber");
            DropColumn("dbo.ConsoleBetGameViewModels", "GameConfirmed");
            DropColumn("dbo.ConsoleBetGameViewModels", "BetsConfirmed");
            DropColumn("dbo.ConsoleBetGameViewModels", "LockGame");
            DropColumn("dbo.ConsoleBetGameViewModels", "GameWon");
            DropColumn("dbo.ConsoleBetGameViewModels", "Bet_Id");
            DropColumn("dbo.ConsoleBetGameViewModels", "Player_Id");
            DropColumn("dbo.GroupViewModels", "BetId");
            DropColumn("dbo.GroupViewModels", "GroupName");
            DropColumn("dbo.GroupViewModels", "JoinCode");
            DropColumn("dbo.GroupViewModels", "GameIsConfirmed");
            DropColumn("dbo.GroupViewModels", "BetsAreConfirmed");
            DropColumn("dbo.GroupViewModels", "Player_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.GroupViewModels", "Player_Id", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.GroupViewModels", "BetsAreConfirmed", c => c.Boolean(nullable: false));
            AddColumn("dbo.GroupViewModels", "GameIsConfirmed", c => c.Boolean(nullable: false));
            AddColumn("dbo.GroupViewModels", "JoinCode", c => c.Int(nullable: false));
            AddColumn("dbo.GroupViewModels", "GroupName", c => c.String(nullable: false, maxLength: 250));
            AddColumn("dbo.GroupViewModels", "BetId", c => c.Int(nullable: false));
            AddColumn("dbo.ConsoleBetGameViewModels", "Player_Id", c => c.String(maxLength: 128));
            AddColumn("dbo.ConsoleBetGameViewModels", "Bet_Id", c => c.Int());
            AddColumn("dbo.ConsoleBetGameViewModels", "GameWon", c => c.Boolean(nullable: false));
            AddColumn("dbo.ConsoleBetGameViewModels", "LockGame", c => c.Boolean(nullable: false));
            AddColumn("dbo.ConsoleBetGameViewModels", "BetsConfirmed", c => c.Boolean(nullable: false));
            AddColumn("dbo.ConsoleBetGameViewModels", "GameConfirmed", c => c.Boolean(nullable: false));
            AddColumn("dbo.ConsoleBetGameViewModels", "LargestPossibleNumber", c => c.Double(nullable: false));
            AddColumn("dbo.ConsoleBetGameViewModels", "SmallestPossibleNumber", c => c.Double(nullable: false));
            AddColumn("dbo.ConsoleBetGameViewModels", "PlayerGuess", c => c.Double(nullable: false));
            AddColumn("dbo.ConsoleBetGameViewModels", "TeamScore", c => c.Double(nullable: false));
            AddColumn("dbo.ConsoleBetGameViewModels", "TeamName", c => c.String(maxLength: 250));
            AddColumn("dbo.ConsoleBetGameViewModels", "GroupId", c => c.Int(nullable: false));
            AddColumn("dbo.AspNetUsers", "GroupViewModels_Id", c => c.Int());
            AddColumn("dbo.BetImpls", "GroupViewModels_Id", c => c.Int());
            AddColumn("dbo.BetImpls", "ConsoleBetGameViewModel_Id", c => c.Int());
            AlterColumn("dbo.BetImpls", "GroupId", c => c.Int(nullable: false));
            RenameIndex(table: "dbo.GroupViewModels", name: "IX_GroupImpl_Id", newName: "IX_Group_Id");
            RenameIndex(table: "dbo.ConsoleBetGameViewModels", name: "IX_GameImpl_Id", newName: "IX_Game_Id");
            RenameColumn(table: "dbo.GroupViewModels", name: "GroupImpl_Id", newName: "Group_Id");
            RenameColumn(table: "dbo.ConsoleBetGameViewModels", name: "GameImpl_Id", newName: "Game_Id");
            CreateIndex("dbo.GroupViewModels", "Player_Id");
            CreateIndex("dbo.GroupViewModels", "BetId");
            CreateIndex("dbo.ConsoleBetGameViewModels", "Player_Id");
            CreateIndex("dbo.ConsoleBetGameViewModels", "Bet_Id");
            CreateIndex("dbo.ConsoleBetGameViewModels", "GroupId");
            CreateIndex("dbo.AspNetUsers", "GroupViewModels_Id");
            CreateIndex("dbo.BetImpls", "GroupViewModels_Id");
            CreateIndex("dbo.BetImpls", "ConsoleBetGameViewModel_Id");
            AddForeignKey("dbo.AspNetUsers", "GroupViewModels_Id", "dbo.GroupViewModels", "Id");
            AddForeignKey("dbo.GroupViewModels", "Player_Id", "dbo.AspNetUsers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.BetImpls", "GroupViewModels_Id", "dbo.GroupViewModels", "Id");
            AddForeignKey("dbo.GroupViewModels", "BetId", "dbo.BetImpls", "Id", cascadeDelete: true);
            AddForeignKey("dbo.ConsoleBetGameViewModels", "Player_Id", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.ConsoleBetGameViewModels", "GroupId", "dbo.GroupImpls", "Id", cascadeDelete: true);
            AddForeignKey("dbo.BetImpls", "ConsoleBetGameViewModel_Id", "dbo.ConsoleBetGameViewModels", "Id");
            AddForeignKey("dbo.ConsoleBetGameViewModels", "Bet_Id", "dbo.BetImpls", "Id");
        }
    }
}
