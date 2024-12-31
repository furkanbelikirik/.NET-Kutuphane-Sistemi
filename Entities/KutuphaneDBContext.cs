using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using static System.Data.Entity.Migrations.Model.UpdateDatabaseOperation;

namespace FurkanBelikirikSmartProFinalProject.Entities
{
    public class KutuphaneDBContext : DbContext
    {
        public KutuphaneDBContext() : base("SMPKutuphaneDBConnection")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<KutuphaneDBContext, Migrations.Configuration>("SMPKutuphaneDBConnection"));
        }
        public DbSet<Admin> Adminler { get; set; }
        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<Kitaplar> Kitaplar { get; set; }
        public DbSet<Yazarlar> Yazarlar { get; set; }
        public DbSet<Kitaplar_Kullanici> Kitap_Kullanici { get; set; }
    }
}