namespace Bet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addPlayerFormViewModel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.PlayerViewModels", "Player_Id", "dbo.AspNetUsers");
            DropIndex("dbo.PlayerViewModels", new[] { "Player_Id" });
            DropColumn("dbo.PlayerViewModels", "FirstName");
            DropColumn("dbo.PlayerViewModels", "LastName");
            DropColumn("dbo.PlayerViewModels", "MembershipType");
            DropColumn("dbo.PlayerViewModels", "DateOfBirth");
            DropColumn("dbo.PlayerViewModels", "IsSubscribed");
            DropColumn("dbo.PlayerViewModels", "MembershipId");
            DropColumn("dbo.PlayerViewModels", "Player_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PlayerViewModels", "Player_Id", c => c.String(maxLength: 128));
            AddColumn("dbo.PlayerViewModels", "MembershipId", c => c.Int(nullable: false));
            AddColumn("dbo.PlayerViewModels", "IsSubscribed", c => c.Boolean(nullable: false));
            AddColumn("dbo.PlayerViewModels", "DateOfBirth", c => c.DateTime(nullable: false));
            AddColumn("dbo.PlayerViewModels", "MembershipType", c => c.Int(nullable: false));
            AddColumn("dbo.PlayerViewModels", "LastName", c => c.String(nullable: false, maxLength: 250));
            AddColumn("dbo.PlayerViewModels", "FirstName", c => c.String(nullable: false, maxLength: 250));
            CreateIndex("dbo.PlayerViewModels", "Player_Id");
            AddForeignKey("dbo.PlayerViewModels", "Player_Id", "dbo.AspNetUsers", "Id");
        }
    }
}
