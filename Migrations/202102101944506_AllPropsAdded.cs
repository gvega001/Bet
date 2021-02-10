namespace Bet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AllPropsAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BetImpls", "GroupImpl_Id", c => c.Int());
            AddColumn("dbo.GameImpls", "Team1Name", c => c.String());
            AddColumn("dbo.GameImpls", "Team2Name", c => c.String());
            AddColumn("dbo.GroupImpls", "GroupName", c => c.String());
            AddColumn("dbo.GroupImpls", "JoinCode", c => c.Int(nullable: false));
            AddColumn("dbo.GroupImpls", "GameIsConfirmed", c => c.Boolean(nullable: false));
            AddColumn("dbo.GroupImpls", "BetsAreConfirme", c => c.Boolean(nullable: false));
            AddColumn("dbo.GroupImpls", "Player_Id", c => c.String(maxLength: 128));
            AddColumn("dbo.AspNetUsers", "GroupImpl_Id", c => c.Int());
            CreateIndex("dbo.BetImpls", "GroupImpl_Id");
            CreateIndex("dbo.GroupImpls", "BetId");
            CreateIndex("dbo.GroupImpls", "Player_Id");
            CreateIndex("dbo.AspNetUsers", "GroupImpl_Id");
            AddForeignKey("dbo.GroupImpls", "BetId", "dbo.BetImpls", "Id", cascadeDelete: true);
            AddForeignKey("dbo.BetImpls", "GroupImpl_Id", "dbo.GroupImpls", "Id");
            AddForeignKey("dbo.GroupImpls", "Player_Id", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.AspNetUsers", "GroupImpl_Id", "dbo.GroupImpls", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUsers", "GroupImpl_Id", "dbo.GroupImpls");
            DropForeignKey("dbo.GroupImpls", "Player_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.BetImpls", "GroupImpl_Id", "dbo.GroupImpls");
            DropForeignKey("dbo.GroupImpls", "BetId", "dbo.BetImpls");
            DropIndex("dbo.AspNetUsers", new[] { "GroupImpl_Id" });
            DropIndex("dbo.GroupImpls", new[] { "Player_Id" });
            DropIndex("dbo.GroupImpls", new[] { "BetId" });
            DropIndex("dbo.BetImpls", new[] { "GroupImpl_Id" });
            DropColumn("dbo.AspNetUsers", "GroupImpl_Id");
            DropColumn("dbo.GroupImpls", "Player_Id");
            DropColumn("dbo.GroupImpls", "BetsAreConfirme");
            DropColumn("dbo.GroupImpls", "GameIsConfirmed");
            DropColumn("dbo.GroupImpls", "JoinCode");
            DropColumn("dbo.GroupImpls", "GroupName");
            DropColumn("dbo.GameImpls", "Team2Name");
            DropColumn("dbo.GameImpls", "Team1Name");
            DropColumn("dbo.BetImpls", "GroupImpl_Id");
        }
    }
}
