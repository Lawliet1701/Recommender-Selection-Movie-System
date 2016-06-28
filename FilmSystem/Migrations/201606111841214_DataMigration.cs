namespace FilmSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Actors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FisrtName = c.String(),
                        LastName = c.String(),
                        ActorKPID = c.Int(nullable: false),
                        Year = c.String(),
                        CountMovies = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Directors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FisrtName = c.String(),
                        LastName = c.String(),
                        DirectorKPID = c.Int(nullable: false),
                        Year = c.String(),
                        CountMovies = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NameRU = c.String(),
                        NameEN = c.String(),
                        FilmID = c.Int(nullable: false),
                        Year = c.String(),
                        Length = c.String(),
                        Slogan = c.String(),
                        Description = c.String(),
                        RatingAgeLimits = c.String(),
                        PremiereWorld = c.String(),
                        Budget = c.String(),
                        RatingIMDB = c.String(),
                        RatingKP = c.String(),
                        Rating = c.String(),
                        CountViews = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
                       
            AddColumn("dbo.AspNetUsers", "Age", c => c.Int(nullable: false));
            AddColumn("dbo.AspNetUsers", "Login", c => c.String());
            AddColumn("dbo.AspNetUsers", "Count", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {

            DropTable("dbo.Movies");
            DropTable("dbo.Directors");
            DropTable("dbo.Actors");
        }
    }
}
