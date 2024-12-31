using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FurkanBelikirikSmartProFinalProject.Entities
{
    [Table("Yazarlar")]
    public class Yazarlar
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string YazarAdi { get; set; }
        public virtual List<Kitaplar> Kitaplar { get; set; }
    }
}