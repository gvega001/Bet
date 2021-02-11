namespace Bet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedControllersWithForms1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GroupViewModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BetId = c.Int(nullable: false),
                        GroupName = c.String(nullable: false, maxLength: 250),
                        JoinCode = c.Int(nullable: false),
                        GameIsConfirmed = c.Boolean(nullable: false),
                        BetsAreConfirmed = c.Boolean(nullable: false),
                        Player_Id = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.BetImpls", t => t.BetId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.Player_Id, cascadeDelete: true)
                .Index(t => t.BetId)
                .Index(t => t.Player_Id);
            
            AddColumn("dbo.BetImpls", "GroupViewModels_Id", c => c.Int());
            AddColumn("dbo.AspNetUsers", "GroupViewModels_Id", c => c.Int());
            CreateIndex("dbo.BetImpls", "GroupViewModels_Id");
            CreateIndex("dbo.AspNetUsers", "GroupViewModels_Id");
            AddForeignKey("dbo.BetImpls", "GroupViewModels_Id", "dbo.GroupViewModels", "Id");
            AddForeignKey("dbo.AspNetUsers", "GroupViewModels_Id", "dbo.GroupViewModels", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUsers", "GroupViewModels_Id", "dbo.GroupViewModels");
            DropForeignKey("dbo.GroupViewModels", "Player_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.BetImpls", "GroupViewModels_Id", "dbo.GroupViewModels");
            DropForeignKey("dbo.GroupViewModels", "BetId", "dbo.BetImpls");
            DropIndex("dbo.GroupViewModels", new[] { "Player_Id" });
            DropIndex("dbo.GroupViewModels", new[] { "BetId" });
            DropIndex("dbo.AspNetUsers", new[] { "GroupViewModels_Id" });
            DropIndex("dbo.BetImpls", new[] { "GroupViewModels_Id" });
            DropColumn("dbo.AspNetUsers", "GroupViewModels_Id");
            DropColumn("dbo.BetImpls", "GroupViewModels_Id");
            DropTable("dbo.GroupViewModels");
        }
    }
}
