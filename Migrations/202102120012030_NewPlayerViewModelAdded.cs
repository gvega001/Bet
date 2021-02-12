namespace Bet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewPlayerViewModelAdded : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.PlayerViewModels", "Bet_Id", "dbo.BetImpls");
            DropForeignKey("dbo.BetImpls", "PlayerViewModels_Id", "dbo.PlayerViewModels");
            DropForeignKey("dbo.PlayerViewModels", "Details_Id", "dbo.PlayerViewModels");
            DropIndex("dbo.BetImpls", new[] { "PlayerViewModels_Id" });
            DropIndex("dbo.PlayerViewModels", new[] { "Bet_Id" });
            DropIndex("dbo.PlayerViewModels", new[] { "Details_Id" });
            CreateTable(
                "dbo.ConsoleBetGameViewModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GroupId = c.Int(nullable: false),
                        TeamName = c.String(maxLength: 250),
                        TeamScore = c.Double(nullable: false),
                        PlayerGuess = c.Double(nullable: false),
                        SmallestPossibleNumber = c.Double(nullable: false),
                        LargestPossibleNumber = c.Double(nullable: false),
                        GameConfirmed = c.Boolean(nullable: false),
                        BetsConfirmed = c.Boolean(nullable: false),
                        LockGame = c.Boolean(nullable: false),
                        GameWon = c.Boolean(nullable: false),
                        Player_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.Player_Id)
                .Index(t => t.Player_Id);
            
            AddColumn("dbo.BetImpls", "ConsoleBetGameViewModel_Id", c => c.Int());
            CreateIndex("dbo.BetImpls", "ConsoleBetGameViewModel_Id");
            AddForeignKey("dbo.BetImpls", "ConsoleBetGameViewModel_Id", "dbo.ConsoleBetGameViewModels", "Id");
            DropColumn("dbo.BetImpls", "PlayerViewModels_Id");
            DropColumn("dbo.PlayerViewModels", "FirstName");
            DropColumn("dbo.PlayerViewModels", "LastName");
            DropColumn("dbo.PlayerViewModels", "MembershipType");
            DropColumn("dbo.PlayerViewModels", "DateOfBirth");
            DropColumn("dbo.PlayerViewModels", "Bet_Id");
            DropColumn("dbo.PlayerViewModels", "Details_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PlayerViewModels", "Details_Id", c => c.Int());
            AddColumn("dbo.PlayerViewModels", "Bet_Id", c => c.Int());
            AddColumn("dbo.PlayerViewModels", "DateOfBirth", c => c.DateTime(nullable: false));
            AddColumn("dbo.PlayerViewModels", "MembershipType", c => c.Int(nullable: false));
            AddColumn("dbo.PlayerViewModels", "LastName", c => c.String(nullable: false, maxLength: 250));
            AddColumn("dbo.PlayerViewModels", "FirstName", c => c.String(nullable: false, maxLength: 250));
            AddColumn("dbo.BetImpls", "PlayerViewModels_Id", c => c.Int());
            DropForeignKey("dbo.ConsoleBetGameViewModels", "Player_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.BetImpls", "ConsoleBetGameViewModel_Id", "dbo.ConsoleBetGameViewModels");
            DropIndex("dbo.ConsoleBetGameViewModels", new[] { "Player_Id" });
            DropIndex("dbo.BetImpls", new[] { "ConsoleBetGameViewModel_Id" });
            DropColumn("dbo.BetImpls", "ConsoleBetGameViewModel_Id");
            DropTable("dbo.ConsoleBetGameViewModels");
            CreateIndex("dbo.PlayerViewModels", "Details_Id");
            CreateIndex("dbo.PlayerViewModels", "Bet_Id");
            CreateIndex("dbo.BetImpls", "PlayerViewModels_Id");
            AddForeignKey("dbo.PlayerViewModels", "Details_Id", "dbo.PlayerViewModels", "Id");
            AddForeignKey("dbo.BetImpls", "PlayerViewModels_Id", "dbo.PlayerViewModels", "Id");
            AddForeignKey("dbo.PlayerViewModels", "Bet_Id", "dbo.BetImpls", "Id");
        }
    }
}
