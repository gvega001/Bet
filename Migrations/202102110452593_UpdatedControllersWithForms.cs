namespace Bet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedControllersWithForms : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BetViewModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PlayerId = c.Int(nullable: false),
                        MaxPossibleNumber = c.Double(nullable: false),
                        LowestPossibleNumber = c.Double(nullable: false),
                        Guess = c.Double(nullable: false),
                        Player_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.Player_Id)
                .Index(t => t.Player_Id);
            
            CreateTable(
                "dbo.PlayerViewModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 250),
                        LastName = c.String(nullable: false, maxLength: 250),
                        MembershipType = c.Int(nullable: false),
                        DateOfBirth = c.DateTime(nullable: false),
                        Bet_Id = c.Int(),
                        Details_Id = c.Int(),
                        Player_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.BetImpls", t => t.Bet_Id)
                .ForeignKey("dbo.PlayerViewModels", t => t.Details_Id)
                .ForeignKey("dbo.AspNetUsers", t => t.Player_Id)
                .Index(t => t.Bet_Id)
                .Index(t => t.Details_Id)
                .Index(t => t.Player_Id);
            
            AddColumn("dbo.BetImpls", "PlayerViewModels_Id", c => c.Int());
            CreateIndex("dbo.BetImpls", "PlayerViewModels_Id");
            AddForeignKey("dbo.BetImpls", "PlayerViewModels_Id", "dbo.PlayerViewModels", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PlayerViewModels", "Player_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.PlayerViewModels", "Details_Id", "dbo.PlayerViewModels");
            DropForeignKey("dbo.BetImpls", "PlayerViewModels_Id", "dbo.PlayerViewModels");
            DropForeignKey("dbo.PlayerViewModels", "Bet_Id", "dbo.BetImpls");
            DropForeignKey("dbo.BetViewModels", "Player_Id", "dbo.AspNetUsers");
            DropIndex("dbo.PlayerViewModels", new[] { "Player_Id" });
            DropIndex("dbo.PlayerViewModels", new[] { "Details_Id" });
            DropIndex("dbo.PlayerViewModels", new[] { "Bet_Id" });
            DropIndex("dbo.BetViewModels", new[] { "Player_Id" });
            DropIndex("dbo.BetImpls", new[] { "PlayerViewModels_Id" });
            DropColumn("dbo.BetImpls", "PlayerViewModels_Id");
            DropTable("dbo.PlayerViewModels");
            DropTable("dbo.BetViewModels");
        }
    }
}
