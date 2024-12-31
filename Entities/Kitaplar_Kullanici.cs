using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FurkanBelikirikSmartProFinalProject.Entities
{
    [Table("Kitaplar_Kullanici")]
    public class Kitaplar_Kullanici
    {
        [Key]
        public int Id { get; set; }
        
        [Required] 
        public int KitapId { get; set; }
        [ForeignKey("KitapId")]
        public virtual Kitaplar Kitap { get; set; }

        [Required]
        public int KullaniciId { get; set; }
        [ForeignKey("KullaniciId")]
        public virtual Kullanici Kullanici { get; set; }

        [Required]
        public DateTime KiralamaTarih { get; set; }
        [Required]
        public DateTime İadeTarih { get; set; }
    }
}