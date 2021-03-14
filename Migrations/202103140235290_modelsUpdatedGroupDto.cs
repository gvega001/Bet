namespace Bet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modelsUpdatedGroupDto : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.GroupImpls", "BetId");
            DropColumn("dbo.GroupImpls", "PlayerId");
            DropColumn("dbo.GroupImpls", "GameId");
            DropColumn("dbo.GroupDtoes", "BetId");
            DropColumn("dbo.GroupDtoes", "PlayerId");
            DropColumn("dbo.GroupDtoes", "GameId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.GroupDtoes", "GameId", c => c.Int());
            AddColumn("dbo.GroupDtoes", "PlayerId", c => c.Int());
            AddColumn("dbo.GroupDtoes", "BetId", c => c.Int());
            AddColumn("dbo.GroupImpls", "GameId", c => c.Int());
            AddColumn("dbo.GroupImpls", "PlayerId", c => c.Int());
            AddColumn("dbo.GroupImpls", "BetId", c => c.Int());
        }
    }
}
