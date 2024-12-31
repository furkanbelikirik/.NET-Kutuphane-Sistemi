namespace FurkanBelikirikSmartProFinalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Kitap_Kullanici : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kitaplar_Kullanici",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        KitapId = c.Int(nullable: false),
                        KullaniciId = c.Int(nullable: false),
                        KiralamaTarih = c.DateTime(nullable: false),
                        İadeTarih = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Kitaplar", t => t.KitapId, cascadeDelete: true)
                .ForeignKey("dbo.Kullanicilar", t => t.KullaniciId, cascadeDelete: true)
                .Index(t => t.KitapId)
                .Index(t => t.KullaniciId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Kitaplar_Kullanici", "KullaniciId", "dbo.Kullanicilar");
            DropForeignKey("dbo.Kitaplar_Kullanici", "KitapId", "dbo.Kitaplar");
            DropIndex("dbo.Kitaplar_Kullanici", new[] { "KullaniciId" });
            DropIndex("dbo.Kitaplar_Kullanici", new[] { "KitapId" });
            DropTable("dbo.Kitaplar_Kullanici");
        }
    }
}
