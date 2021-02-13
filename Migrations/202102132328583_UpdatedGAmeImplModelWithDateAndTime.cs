namespace Bet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedGAmeImplModelWithDateAndTime : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.GameImpls", "LastDateTime", c => c.DateTime());
            AlterColumn("dbo.GameImpls", "EventDateTime", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.GameImpls", "EventDateTime", c => c.DateTime(nullable: false));
            DropColumn("dbo.GameImpls", "LastDateTime");
        }
    }
}
