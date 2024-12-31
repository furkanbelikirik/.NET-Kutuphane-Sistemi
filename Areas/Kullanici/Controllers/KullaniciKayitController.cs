using FurkanBelikirikSmartProFinalProject.Entities;
using FurkanBelikirikSmartProFinalProject.Migrations;
using FurkanBelikirikSmartProFinalProject.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace FurkanBelikirikSmartProFinalProject.Areas.Kullanici.Controllers
{
    public class KullaniciKayitController : Controller
    {
        // GET: Kullanici/KullaniciKayit
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(KullaniciKayitViewModel kayit)
        {
            KutuphaneDBContext db = new KutuphaneDBContext();

            var yeniKayit = new FurkanBelikirikSmartProFinalProject.Entities.Kullanici
            {
                Ad = kayit.Ad,
                Soyad = kayit.Soyad,
                KullaniciAdi = kayit.kullaniciAdi,
                Parola = kayit.sifre,
            };

            db.Kullanicilar.Add(yeniKayit);

            try
            {
                db.SaveChanges();
                var kullanici = db.Kullanicilar.FirstOrDefault(x => x.KullaniciAdi == kayit.kullaniciAdi && x.Parola == kayit.sifre);
                Session["Kullanici"] = kullanici;
                return RedirectToAction("Index", "Home");
            }
            catch (Exception)
            {
                ViewBag.Mesaj = "Kayıt sırasında bir hata meydana geldi!";
            }
            return View();
        }
    }
}