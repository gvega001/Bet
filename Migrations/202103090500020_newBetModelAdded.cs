namespace Bet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newBetModelAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NewBets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MoneyBet = c.Int(nullable: false),
                        Guess = c.Double(),
                        Game_Id = c.Int(),
                        Group_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.GameDtoes", t => t.Game_Id)
                .ForeignKey("dbo.GroupDtoes", t => t.Group_Id)
                .Index(t => t.Game_Id)
                .Index(t => t.Group_Id);
            
            CreateTable(
                "dbo.GameDtoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EventName = c.String(),
                        EventDateTime = c.DateTime(),
                        LastDateTime = c.DateTime(),
                        GroupId = c.Int(),
                        Team1Name = c.String(nullable: false, maxLength: 250),
                        Team1Score = c.Double(nullable: false),
                        Team2Name = c.String(nullable: false, maxLength: 250),
                        Team2Score = c.Double(nullable: false),
                        SmallestPossibleNumber = c.Double(),
                        LargestPossibleNumber = c.Double(),
                        GameConfirmed = c.Boolean(),
                        BetsConfirmed = c.Boolean(),
                        LockGame = c.Boolean(),
                        GameWon = c.Boolean(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.GroupDtoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BetId = c.Int(),
                        GroupName = c.String(nullable: false, maxLength: 250),
                        PlayerId = c.Int(),
                        JoinCode = c.Int(nullable: false),
                        GameId = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.BetImpls", "GameDto_Id", c => c.Int());
            AddColumn("dbo.BetImpls", "GroupDto_Id", c => c.Int());
            CreateIndex("dbo.BetImpls", "GameDto_Id");
            CreateIndex("dbo.BetImpls", "GroupDto_Id");
            AddForeignKey("dbo.BetImpls", "GameDto_Id", "dbo.GameDtoes", "Id");
            AddForeignKey("dbo.BetImpls", "GroupDto_Id", "dbo.GroupDtoes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.NewBets", "Group_Id", "dbo.GroupDtoes");
            DropForeignKey("dbo.BetImpls", "GroupDto_Id", "dbo.GroupDtoes");
            DropForeignKey("dbo.NewBets", "Game_Id", "dbo.GameDtoes");
            DropForeignKey("dbo.BetImpls", "GameDto_Id", "dbo.GameDtoes");
            DropIndex("dbo.NewBets", new[] { "Group_Id" });
            DropIndex("dbo.NewBets", new[] { "Game_Id" });
            DropIndex("dbo.BetImpls", new[] { "GroupDto_Id" });
            DropIndex("dbo.BetImpls", new[] { "GameDto_Id" });
            DropColumn("dbo.BetImpls", "GroupDto_Id");
            DropColumn("dbo.BetImpls", "GameDto_Id");
            DropTable("dbo.GroupDtoes");
            DropTable("dbo.GameDtoes");
            DropTable("dbo.NewBets");
        }
    }
}
