namespace Bet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GameImpleGroupIdUpdated : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.GameImpls", "PlayerGuess");
        }
        
        public override void Down()
        {
            AddColumn("dbo.GameImpls", "PlayerGuess", c => c.Double(nullable: false));
        }
    }
}
