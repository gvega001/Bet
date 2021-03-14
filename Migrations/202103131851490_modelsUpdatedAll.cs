namespace Bet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modelsUpdatedAll : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BetDtoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GameName = c.String(),
                        GroupId = c.Int(),
                        MoneyBet = c.Int(nullable: false),
                        Guess = c.Double(),
                        GameId = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.NewBets", "Bet_Id", c => c.Int());
            CreateIndex("dbo.NewBets", "Bet_Id");
            AddForeignKey("dbo.NewBets", "Bet_Id", "dbo.BetDtoes", "Id");
            DropColumn("dbo.BetImpls", "GroupId");
            DropColumn("dbo.BetImpls", "GameName");
            DropColumn("dbo.NewBets", "MoneyBet");
            DropColumn("dbo.NewBets", "Guess");
        }
        
        public override void Down()
        {
            AddColumn("dbo.NewBets", "Guess", c => c.Double());
            AddColumn("dbo.NewBets", "MoneyBet", c => c.Int(nullable: false));
            AddColumn("dbo.BetImpls", "GameName", c => c.String());
            AddColumn("dbo.BetImpls", "GroupId", c => c.Int());
            DropForeignKey("dbo.NewBets", "Bet_Id", "dbo.BetDtoes");
            DropIndex("dbo.NewBets", new[] { "Bet_Id" });
            DropColumn("dbo.NewBets", "Bet_Id");
            DropTable("dbo.BetDtoes");
        }
    }
}
