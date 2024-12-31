using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FurkanBelikirikSmartProFinalProject.Entities
{
    [Table("Admins")]
    public class Admin
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
    }
}