namespace Bet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataAnnotationsAdded : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.GroupImpls", "Player_Id", "dbo.AspNetUsers");
            DropIndex("dbo.GroupImpls", new[] { "Player_Id" });
            AddColumn("dbo.GroupImpls", "BetsAreConfirmed", c => c.Boolean(nullable: false));
            AlterColumn("dbo.GameImpls", "Team1Name", c => c.String(nullable: false, maxLength: 250));
            AlterColumn("dbo.GameImpls", "Team2Name", c => c.String(nullable: false, maxLength: 250));
            AlterColumn("dbo.GroupImpls", "GroupName", c => c.String(nullable: false, maxLength: 250));
            AlterColumn("dbo.GroupImpls", "Player_Id", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.AspNetUsers", "FirstName", c => c.String(maxLength: 250));
            AlterColumn("dbo.AspNetUsers", "LastName", c => c.String(maxLength: 250));
            CreateIndex("dbo.GroupImpls", "Player_Id");
            AddForeignKey("dbo.GroupImpls", "Player_Id", "dbo.AspNetUsers", "Id", cascadeDelete: true);
            DropColumn("dbo.GroupImpls", "BetsAreConfirme");
        }
        
        public override void Down()
        {
            AddColumn("dbo.GroupImpls", "BetsAreConfirme", c => c.Boolean(nullable: false));
            DropForeignKey("dbo.GroupImpls", "Player_Id", "dbo.AspNetUsers");
            DropIndex("dbo.GroupImpls", new[] { "Player_Id" });
            AlterColumn("dbo.AspNetUsers", "LastName", c => c.String());
            AlterColumn("dbo.AspNetUsers", "FirstName", c => c.String());
            AlterColumn("dbo.GroupImpls", "Player_Id", c => c.String(maxLength: 128));
            AlterColumn("dbo.GroupImpls", "GroupName", c => c.String());
            AlterColumn("dbo.GameImpls", "Team2Name", c => c.String());
            AlterColumn("dbo.GameImpls", "Team1Name", c => c.String());
            DropColumn("dbo.GroupImpls", "BetsAreConfirmed");
            CreateIndex("dbo.GroupImpls", "Player_Id");
            AddForeignKey("dbo.GroupImpls", "Player_Id", "dbo.AspNetUsers", "Id");
        }
    }
}
