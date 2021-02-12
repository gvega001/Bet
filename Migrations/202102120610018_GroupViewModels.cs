namespace Bet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GroupViewModels : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.GroupViewModels", "Group_Id", c => c.Int());
            CreateIndex("dbo.GroupViewModels", "Group_Id");
            AddForeignKey("dbo.GroupViewModels", "Group_Id", "dbo.GroupImpls", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.GroupViewModels", "Group_Id", "dbo.GroupImpls");
            DropIndex("dbo.GroupViewModels", new[] { "Group_Id" });
            DropColumn("dbo.GroupViewModels", "Group_Id");
        }
    }
}
