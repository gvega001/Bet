namespace Bet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PropertiesAddedToDB : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "MembershipId", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "MembershipId");
        }
    }
}
