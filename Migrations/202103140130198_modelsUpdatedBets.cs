namespace Bet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modelsUpdatedBets : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BetImpls", "Team", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.BetImpls", "Team");
        }
    }
}
