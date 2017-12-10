namespace CourseProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FIO = c.String(nullable: false, maxLength: 150),
                        Year = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Author = c.Int(nullable: false),
                        Publishing = c.String(nullable: false, maxLength: 50),
                        Year = c.Int(nullable: false),
                        Amount = c.Int(nullable: false),
                        Price = c.String(nullable: false, maxLength: 10),
                        SeriesId = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Serieses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        First_Book = c.Int(nullable: false),
                        Last_Book = c.Int(nullable: false),
                        Author = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Checks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Book_Id = c.Int(nullable: false),
                        Reader_Id = c.Int(nullable: false),
                        Date = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Readers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FIO = c.String(nullable: false, maxLength: 150),
                        Address = c.String(maxLength: 50),
                        Telephone = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Readers");
            DropTable("dbo.Checks");
            DropTable("dbo.Serieses");
            DropTable("dbo.Books");
            DropTable("dbo.Authors");
        }
    }
}
