namespace Bet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class playerViewModelUpdated : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "PlayerId", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "PlayerId");
        }
    }
}
