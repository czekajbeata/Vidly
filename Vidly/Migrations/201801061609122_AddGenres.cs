namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGenres : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, Name) VALUES (1, 'comedy')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (2, 'action')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (3, 'animated')");

        }
        
        public override void Down()
        {
        }
    }
}
