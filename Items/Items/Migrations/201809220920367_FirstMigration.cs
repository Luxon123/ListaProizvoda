namespace Items.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Proizvods",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Naziv = c.String(nullable: false, maxLength: 25),
                        Opis = c.String(nullable: false, maxLength: 25),
                        Kategorija = c.String(nullable: false, maxLength: 25),
                        Proizvodjac = c.String(nullable: false, maxLength: 25),
                        Dobavljac = c.String(nullable: false, maxLength: 25),
                        Cena = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Proizvods");
        }
    }
}
