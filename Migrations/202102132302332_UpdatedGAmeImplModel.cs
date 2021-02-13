namespace Bet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedGAmeImplModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.GameImpls", "EventName", c => c.String());
            AddColumn("dbo.GameImpls", "EventDateTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.GameImpls", "EventDateTime");
            DropColumn("dbo.GameImpls", "EventName");
        }
    }
}
