using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FurkanBelikirikSmartProFinalProject.Models
{
    public class KullaniciLoginViewModel
    {
        [Display(Name = "Kullanıcı Adı")]
        public string kullaniciAdi { get; set; }

        [Display(Name = "Şifre")]
        [DataType(DataType.Password)]
        public string sifre { get; set; }
    }
}