using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FurkanBelikirikSmartProFinalProject.Entities
{
    [Table("Kitaplar")]
    public class Kitaplar
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string KitapAdi { get; set; }
        [Required]
        public string Dil { get; set; }
        [Required]
        public string YayimYili { get; set; }
        [Required]
        public string SayfaSayisi { get; set; }
        [Required]
        public string ISBN { get; set; }
        [Required]
        public string Yayınevi { get; set; }
        [Required]
        public int Stok {  get; set; }
        [Required]             
        public int YazarId { get; set; }
        [ForeignKey("YazarId")]
        public virtual Yazarlar Yazar { get; set; }
        public virtual List<Kitaplar_Kullanici> Kitaplar_Kullanici { get; set; }
    }
}