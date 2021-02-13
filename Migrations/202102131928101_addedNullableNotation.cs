namespace Bet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedNullableNotation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.PlayerViewModels", "MembershipType", c => c.Int());
            AlterColumn("dbo.PlayerViewModels", "DateOfBirth", c => c.DateTime());
            AlterColumn("dbo.PlayerViewModels", "MembershipId", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.PlayerViewModels", "MembershipId", c => c.Int(nullable: false));
            AlterColumn("dbo.PlayerViewModels", "DateOfBirth", c => c.DateTime(nullable: false));
            AlterColumn("dbo.PlayerViewModels", "MembershipType", c => c.Int(nullable: false));
        }
    }
}
