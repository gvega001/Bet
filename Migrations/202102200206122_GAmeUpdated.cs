namespace Bet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GAmeUpdated : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.GameImpls", "Team2Score");
        }
        
        public override void Down()
        {
            AddColumn("dbo.GameImpls", "Team2Score", c => c.Double(nullable: false));
        }
    }
}
