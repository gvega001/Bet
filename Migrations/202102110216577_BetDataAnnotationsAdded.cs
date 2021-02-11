namespace Bet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BetDataAnnotationsAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BetImpls", "Guess", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.BetImpls", "Guess");
        }
    }
}
