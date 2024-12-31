namespace FurkanBelikirikSmartProFinalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Kullanici : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kullanicilar",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ad = c.String(nullable: false),
                        Soyad = c.String(nullable: false),
                        KullaniciAdi = c.String(nullable: false),
                        Parola = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Kullanicilar");
        }
    }
}
