namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@" 
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'41a193eb-e1e9-4034-9047-3bcc5dceefa6', N'beata@vidly.com', 0, N'ADMP8SLloznfcJn5iMhFKwTwQ5/3y2VuO6s0p7HnaSa7eu6p6fGvg/uCDAGp4aUt/g==', N'9de36a12-eef8-4049-8793-c0c509d03c2b', NULL, 0, 0, NULL, 1, 0, N'beata@vidly.com')
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'91c89c4d-689e-4a3d-93da-1cf2ae910be3', N'guest@vidly.com', 0, N'AEmZJuqp1/bvED+pLnJPgmI5pVGuF7MbzvqNmrv9IWL3XPDiWXjYHGeCJTSOVlxVXA==', N'd446e07b-c1bf-4873-8323-fb9e1e4b3f20', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'bff5f4b1-0694-4b0e-97ef-1c36c2f4ebf5', N'admin@vidly.com', 0, N'AC0AHPqRO8KJOCuUlF5DYmuGQJoFvNfSD7wJuFkmEYjIjVkUwuijn1NnG8ijilhC8A==', N'6319cc09-28cb-4876-8430-76e5214a39fd', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

            INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'4999cad9-3fdb-4a79-a8ea-21bd468cd185', N'CanManageMovies')

            INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'bff5f4b1-0694-4b0e-97ef-1c36c2f4ebf5', N'4999cad9-3fdb-4a79-a8ea-21bd468cd185')
            ");
        }
        
        public override void Down()
        {
        }
    }
}
