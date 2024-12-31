using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FurkanBelikirikSmartProFinalProject.Models
{
    public class KullaniciKayitViewModel
    {
        [Display(Name = "Ad")]
        public string Ad { get; set; }

        [Display(Name = "Soyad")]
        public string Soyad { get; set; }

        [Display(Name = "Kullanıcı Adı")]
        public string kullaniciAdi { get; set; }

        [Display(Name = "Şifre")]
        [DataType(DataType.Password)]
        public string sifre { get; set; }
    }
}