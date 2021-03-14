namespace Bet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PlayerUpdated1 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.AspNetUsers", newName: "Players");
            DropForeignKey("dbo.BetImpls", "Player_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.PlayerViewModels", "Player_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.BetImpls", new[] { "Player_Id" });
            DropIndex("dbo.Players", "UserNameIndex");
            DropIndex("dbo.PlayerViewModels", new[] { "Player_Id" });
            DropPrimaryKey("dbo.Players");
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        DateOfBirth = c.DateTime(nullable: false),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            AlterColumn("dbo.Players", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Players", "DateOfBirth", c => c.DateTime());
            AlterColumn("dbo.Players", "FirstName", c => c.String(nullable: false, maxLength: 250));
            AlterColumn("dbo.Players", "LastName", c => c.String(nullable: false, maxLength: 250));
            AlterColumn("dbo.Players", "IsSubscribed", c => c.Boolean(nullable: false));
            AlterColumn("dbo.PlayerViewModels", "Player_Id", c => c.Int());
            AddPrimaryKey("dbo.Players", "Id");
            CreateIndex("dbo.PlayerViewModels", "Player_Id");
            AddForeignKey("dbo.PlayerViewModels", "Player_Id", "dbo.Players", "Id");
            DropColumn("dbo.BetImpls", "Player_Id");
            DropColumn("dbo.Players", "Email");
            DropColumn("dbo.Players", "EmailConfirmed");
            DropColumn("dbo.Players", "PasswordHash");
            DropColumn("dbo.Players", "SecurityStamp");
            DropColumn("dbo.Players", "PhoneNumber");
            DropColumn("dbo.Players", "PhoneNumberConfirmed");
            DropColumn("dbo.Players", "TwoFactorEnabled");
            DropColumn("dbo.Players", "LockoutEndDateUtc");
            DropColumn("dbo.Players", "LockoutEnabled");
            DropColumn("dbo.Players", "AccessFailedCount");
            DropColumn("dbo.Players", "UserName");
            DropColumn("dbo.Players", "PlayerId");
            DropColumn("dbo.Players", "Discriminator");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Players", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.Players", "PlayerId", c => c.Int());
            AddColumn("dbo.Players", "UserName", c => c.String(nullable: false, maxLength: 256));
            AddColumn("dbo.Players", "AccessFailedCount", c => c.Int(nullable: false));
            AddColumn("dbo.Players", "LockoutEnabled", c => c.Boolean(nullable: false));
            AddColumn("dbo.Players", "LockoutEndDateUtc", c => c.DateTime());
            AddColumn("dbo.Players", "TwoFactorEnabled", c => c.Boolean(nullable: false));
            AddColumn("dbo.Players", "PhoneNumberConfirmed", c => c.Boolean(nullable: false));
            AddColumn("dbo.Players", "PhoneNumber", c => c.String());
            AddColumn("dbo.Players", "SecurityStamp", c => c.String());
            AddColumn("dbo.Players", "PasswordHash", c => c.String());
            AddColumn("dbo.Players", "EmailConfirmed", c => c.Boolean(nullable: false));
            AddColumn("dbo.Players", "Email", c => c.String(maxLength: 256));
            AddColumn("dbo.BetImpls", "Player_Id", c => c.String(maxLength: 128));
            DropForeignKey("dbo.PlayerViewModels", "Player_Id", "dbo.Players");
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.PlayerViewModels", new[] { "Player_Id" });
            DropPrimaryKey("dbo.Players");
            AlterColumn("dbo.PlayerViewModels", "Player_Id", c => c.String(maxLength: 128));
            AlterColumn("dbo.Players", "IsSubscribed", c => c.Boolean());
            AlterColumn("dbo.Players", "LastName", c => c.String(maxLength: 250));
            AlterColumn("dbo.Players", "FirstName", c => c.String(maxLength: 250));
            AlterColumn("dbo.Players", "DateOfBirth", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Players", "Id", c => c.String(nullable: false, maxLength: 128));
            DropTable("dbo.AspNetUsers");
            AddPrimaryKey("dbo.Players", "Id");
            CreateIndex("dbo.PlayerViewModels", "Player_Id");
            CreateIndex("dbo.Players", "UserName", unique: true, name: "UserNameIndex");
            CreateIndex("dbo.BetImpls", "Player_Id");
            AddForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.PlayerViewModels", "Player_Id", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.BetImpls", "Player_Id", "dbo.AspNetUsers", "Id");
            RenameTable(name: "dbo.Players", newName: "AspNetUsers");
        }
    }
}
