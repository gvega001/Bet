namespace Bet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GroupImplNullablesAddedToModel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.GroupImpls", "BetId", "dbo.BetImpls");
            DropForeignKey("dbo.GroupImpls", "Player_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUsers", "GroupImpl_Id", "dbo.GroupImpls");
            DropIndex("dbo.AspNetUsers", new[] { "GroupImpl_Id" });
            DropIndex("dbo.GroupImpls", new[] { "BetId" });
            DropIndex("dbo.GroupImpls", new[] { "Player_Id" });
            AddColumn("dbo.GroupImpls", "PlayerId", c => c.Int());
            AddColumn("dbo.GroupImpls", "GameId", c => c.Int());
            AlterColumn("dbo.GameImpls", "GroupId", c => c.Int());
            AlterColumn("dbo.GameImpls", "SmallestPossibleNumber", c => c.Double());
            AlterColumn("dbo.GameImpls", "LargestPossibleNumber", c => c.Double());
            AlterColumn("dbo.GameImpls", "GameConfirmed", c => c.Boolean());
            AlterColumn("dbo.GameImpls", "BetsConfirmed", c => c.Boolean());
            AlterColumn("dbo.GameImpls", "LockGame", c => c.Boolean());
            AlterColumn("dbo.GameImpls", "GameWon", c => c.Boolean());
            AlterColumn("dbo.GroupImpls", "BetId", c => c.Int());
            DropColumn("dbo.AspNetUsers", "GroupImpl_Id");
            DropColumn("dbo.GroupImpls", "GameIsConfirmed");
            DropColumn("dbo.GroupImpls", "BetsAreConfirmed");
            DropColumn("dbo.GroupImpls", "Player_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.GroupImpls", "Player_Id", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.GroupImpls", "BetsAreConfirmed", c => c.Boolean(nullable: false));
            AddColumn("dbo.GroupImpls", "GameIsConfirmed", c => c.Boolean(nullable: false));
            AddColumn("dbo.AspNetUsers", "GroupImpl_Id", c => c.Int());
            AlterColumn("dbo.GroupImpls", "BetId", c => c.Int(nullable: false));
            AlterColumn("dbo.GameImpls", "GameWon", c => c.Boolean(nullable: false));
            AlterColumn("dbo.GameImpls", "LockGame", c => c.Boolean(nullable: false));
            AlterColumn("dbo.GameImpls", "BetsConfirmed", c => c.Boolean(nullable: false));
            AlterColumn("dbo.GameImpls", "GameConfirmed", c => c.Boolean(nullable: false));
            AlterColumn("dbo.GameImpls", "LargestPossibleNumber", c => c.Double(nullable: false));
            AlterColumn("dbo.GameImpls", "SmallestPossibleNumber", c => c.Double(nullable: false));
            AlterColumn("dbo.GameImpls", "GroupId", c => c.Int(nullable: false));
            DropColumn("dbo.GroupImpls", "GameId");
            DropColumn("dbo.GroupImpls", "PlayerId");
            CreateIndex("dbo.GroupImpls", "Player_Id");
            CreateIndex("dbo.GroupImpls", "BetId");
            CreateIndex("dbo.AspNetUsers", "GroupImpl_Id");
            AddForeignKey("dbo.AspNetUsers", "GroupImpl_Id", "dbo.GroupImpls", "Id");
            AddForeignKey("dbo.GroupImpls", "Player_Id", "dbo.AspNetUsers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.GroupImpls", "BetId", "dbo.BetImpls", "Id", cascadeDelete: true);
        }
    }
}
