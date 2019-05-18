namespace Bookmart.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenreTable : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Genres ON");
            Sql("INSERT INTO Genres (Id, GenreName) VALUES (1, 'Romance')");
            Sql("INSERT INTO Genres (Id, GenreName) VALUES (2, 'Thriller')");
            Sql("INSERT INTO Genres (Id, GenreName) VALUES (3, 'Mystery')");
            Sql("INSERT INTO Genres (Id, GenreName) VALUES (4, 'Kids')");
        }
        
        public override void Down()
        {
        }
    }
}
