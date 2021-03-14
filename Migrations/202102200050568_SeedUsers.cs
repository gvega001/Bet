namespace Bet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [FirstName], [LastName], [MembershipType], [Discriminator], [IsSubscribed], [MembershipId], [DateOfBirth], [PlayerId]) VALUES (N'8a38c9c2-ce8b-4166-8d6e-d4b353039031', N'gabe_corona23@yahoo.com', 0, N'AEI7KM4nrk7SgWU3MisW/f7fDaiYB21F7WNv1yy3u10ia4yCFITBRfDMCdAKgyALhA==', N'bbd87c58-9936-4afd-a35b-72ce8095bd6c', NULL, 0, 0, NULL, 1, 0, N'gabe_corona23@yahoo.com', NULL, NULL, NULL, N'ApplicationUser', NULL, NULL, NULL, NULL)
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [FirstName], [LastName], [MembershipType], [Discriminator], [IsSubscribed], [MembershipId], [DateOfBirth], [PlayerId]) VALUES (N'a4981827-a50b-4d5d-8408-71d06a6dff13', N'gvega001@gmail.com', 0, N'ABff5job2mor0qczQJwneSOMZylTjEsfq65n1P7eEwa3zQABFUagcFGrQNw1CUx79g==', N'f80a20c0-d2a1-4fc9-adee-181988400d67', NULL, 0, 0, NULL, 1, 0, N'gvega001@gmail.com', NULL, NULL, NULL, N'ApplicationUser', NULL, NULL, NULL, NULL)

");
        }
        
        public override void Down()
        {
            Sql(@"
            INSERT INTO[dbo].[AspNetRoles] ([Id], [Name]) VALUES(N'bb7cf0e0-ddb8-4ec9-afb2-1d8da0f1543b', N'CanMakeBets')
            INSERT INTO[dbo].[AspNetRoles] ([Id], [Name]) VALUES(N'ce5e02be-9fba-4ab1-b272-4be42921468d', N'CanManageUsers')

            INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'a4981827-a50b-4d5d-8408-71d06a6dff13', N'bb7cf0e0-ddb8-4ec9-afb2-1d8da0f1543b')
            INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'8a38c9c2-ce8b-4166-8d6e-d4b353039031', N'ce5e02be-9fba-4ab1-b272-4be42921468d')

");
           

        }
    }
}
