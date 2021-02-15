namespace Bet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BetImpFormsUpdate : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ConsoleBetGameViewModels", "GameImpl_Id", "dbo.GameImpls");
            DropForeignKey("dbo.GroupViewModels", "GroupImpl_Id", "dbo.GroupImpls");
            DropIndex("dbo.ConsoleBetGameViewModels", new[] { "GameImpl_Id" });
            DropIndex("dbo.GroupViewModels", new[] { "GroupImpl_Id" });
            DropTable("dbo.BetViewModels");
            DropTable("dbo.ConsoleBetGameViewModels");
            DropTable("dbo.GroupViewModels");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.GroupViewModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GroupImpl_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ConsoleBetGameViewModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GameImpl_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.BetViewModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.GroupViewModels", "GroupImpl_Id");
            CreateIndex("dbo.ConsoleBetGameViewModels", "GameImpl_Id");
            AddForeignKey("dbo.GroupViewModels", "GroupImpl_Id", "dbo.GroupImpls", "Id");
            AddForeignKey("dbo.ConsoleBetGameViewModels", "GameImpl_Id", "dbo.GameImpls", "Id");
        }
    }
}
