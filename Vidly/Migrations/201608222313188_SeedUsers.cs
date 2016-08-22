namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'5b1136b0-9d04-48b2-b203-3a38b0c0b21a', N'guest@vidly.com', 0, N'APVuitZH02yf4IYh32eTvmBj9nr9kW+xakM8RKV4xmd249e1rDPk/HbYG92pPD0QTw==', N'20bbb058-8d8a-445e-bef8-6a915f7d971f', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
                  INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'c80a7812-2af2-4364-bb7d-d539cc31dfc0', N'administrator@vidly.com', 0, N'ALWeP1bVHS5I1tfNZac754/BCaH3me/8kmxhLvDPqyPMZbb0+rejB5KQY85ZoUkSKA==', N'fe860ac3-55a9-4d64-b768-087c28c2f652', NULL, 0, 0, NULL, 1, 0, N'administrator@vidly.com')
                  INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'014cd66f-c027-44c1-b90e-8c9294aaefc6', N'CanManageMovies')
                  INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'c80a7812-2af2-4364-bb7d-d539cc31dfc0', N'014cd66f-c027-44c1-b90e-8c9294aaefc6')");
        }
        
        public override void Down()
        {
        }
    }
}
