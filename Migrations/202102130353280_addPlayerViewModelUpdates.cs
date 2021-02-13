namespace Bet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addPlayerViewModelUpdates : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.BetImpls", "PlayerViewModels_Id", "dbo.PlayerViewModels");
            DropIndex("dbo.BetImpls", new[] { "PlayerViewModels_Id" });
            AddColumn("dbo.PlayerViewModels", "FirstName", c => c.String(nullable: false, maxLength: 250));
            AddColumn("dbo.PlayerViewModels", "LastName", c => c.String(nullable: false, maxLength: 250));
            AddColumn("dbo.PlayerViewModels", "MembershipType", c => c.Int(nullable: false));
            AddColumn("dbo.PlayerViewModels", "DateOfBirth", c => c.DateTime(nullable: false));
            AddColumn("dbo.PlayerViewModels", "IsSubscribed", c => c.Boolean(nullable: false));
            AddColumn("dbo.PlayerViewModels", "MembershipId", c => c.Int(nullable: false));
            AddColumn("dbo.PlayerViewModels", "Player_Id", c => c.String(maxLength: 128));
            CreateIndex("dbo.PlayerViewModels", "Player_Id");
            AddForeignKey("dbo.PlayerViewModels", "Player_Id", "dbo.AspNetUsers", "Id");
            DropColumn("dbo.BetImpls", "PlayerViewModels_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.BetImpls", "PlayerViewModels_Id", c => c.Int());
            DropForeignKey("dbo.PlayerViewModels", "Player_Id", "dbo.AspNetUsers");
            DropIndex("dbo.PlayerViewModels", new[] { "Player_Id" });
            DropColumn("dbo.PlayerViewModels", "Player_Id");
            DropColumn("dbo.PlayerViewModels", "MembershipId");
            DropColumn("dbo.PlayerViewModels", "IsSubscribed");
            DropColumn("dbo.PlayerViewModels", "DateOfBirth");
            DropColumn("dbo.PlayerViewModels", "MembershipType");
            DropColumn("dbo.PlayerViewModels", "LastName");
            DropColumn("dbo.PlayerViewModels", "FirstName");
            CreateIndex("dbo.BetImpls", "PlayerViewModels_Id");
            AddForeignKey("dbo.BetImpls", "PlayerViewModels_Id", "dbo.PlayerViewModels", "Id");
        }
    }
}
