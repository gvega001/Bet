namespace Bet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PlayerUpdated : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BetImpls", "Player_Id", c => c.String(maxLength: 128));
            CreateIndex("dbo.BetImpls", "Player_Id");
            AddForeignKey("dbo.BetImpls", "Player_Id", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BetImpls", "Player_Id", "dbo.AspNetUsers");
            DropIndex("dbo.BetImpls", new[] { "Player_Id" });
            DropColumn("dbo.BetImpls", "Player_Id");
        }
    }
}
