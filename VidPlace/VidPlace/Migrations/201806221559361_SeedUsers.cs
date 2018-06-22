namespace VidPlace.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'b6a2e275-616a-4ab0-9572-a7d4050d1f25', N'guest@vidplace.com', 0, N'AIg/+7cWucEOD3KFottlm9olW+dMIdhb5a00qgyzxwJYdrJ65dnzReXinQy6usw6Wg==', N'ab3e92fb-3982-4cb5-ae12-e4272dacbfb6', NULL, 0, 0, NULL, 1, 0, N'guest@vidplace.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'cbef33f5-bc9f-4e8f-ac29-73965d7d1dec', N'admin@vidplace.com', 0, N'AEj6hK0Xpf+g2oEGo1My10BwQRrb9GEEKvixQtFYgvfXtyIlN/piPoZW6Vi8MzFNEA==', N'dcbbdf96-35b4-4279-911b-1d9f25fb01b7', NULL, 0, 0, NULL, 1, 0, N'admin@vidplace.com')");

            Sql(@"INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'462bf671-bb14-48c0-a442-abfe6d622288', N'CanManageMedia')");

            Sql(@"INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'cbef33f5-bc9f-4e8f-ac29-73965d7d1dec', N'462bf671-bb14-48c0-a442-abfe6d622288')");
        }
        
        public override void Down()
        {
        }
    }
}
