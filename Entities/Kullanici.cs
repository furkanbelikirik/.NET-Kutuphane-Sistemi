using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FurkanBelikirikSmartProFinalProject.Entities
{
    [Table("Kullanicilar")]
    public class Kullanici
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Ad { get; set; }
        [Required]
        public string Soyad { get; set; }
        [Required]
        public string KullaniciAdi { get; set; }
        [Required]
        public string Parola { get; set; }
        public virtual List<Kitaplar_Kullanici> Kitaplar_Kullanici { get; set; }
    }
}