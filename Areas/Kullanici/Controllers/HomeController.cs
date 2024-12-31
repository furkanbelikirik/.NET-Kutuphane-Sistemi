using FurkanBelikirikSmartProFinalProject.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FurkanBelikirikSmartProFinalProject.Areas.Kullanici.Controllers
{
    public class HomeController : Controller
    {
        KutuphaneDBContext db = new KutuphaneDBContext();
        // GET: Kullanici/Kirala
        public ActionResult Index()
        {
            var kitaplar = db.Kitaplar.ToList();
            string KiralaMesaj = TempData["KiralaMesaj"] as string;
            ViewBag.KiralaMesaj = KiralaMesaj;

            var kullanici = Session["Kullanici"] as FurkanBelikirikSmartProFinalProject.Entities.Kullanici;

            var kiralanmisKitaplar = db.Kitap_Kullanici
                .Where(x => x.KullaniciId == kullanici.Id)
                .Select(x => x.KitapId)
                .ToList();

            var viewModel = new Tuple<List<Kitaplar>, List<int>>(kitaplar, kiralanmisKitaplar);

            return View(viewModel);
        }

        public ActionResult Kirala(int id)
        {
            var kitapId = db.Kitaplar.Find(id);
            var kullaniciId = Session["Kullanici"] as FurkanBelikirikSmartProFinalProject.Entities.Kullanici;

            var kitapKullanici = new Kitaplar_Kullanici
            {
                KitapId = kitapId.Id,
                KullaniciId = kullaniciId.Id,
                KiralamaTarih = DateTime.Now,
                İadeTarih = DateTime.Now.AddMonths(1),
            };

            db.Kitap_Kullanici.Add(kitapKullanici);
            db.Kitaplar.Find(id).Stok--;

            try
            {
                db.SaveChanges();
                TempData["KiralaMesaj"] = kitapId.KitapAdi + " adlı kitap başarıyla kiralandı!";
            }
            catch (Exception)
            {
                TempData["KiralaMesaj"] = "Kiralama işlemi sırasında bir hata meydana geldi!";
            }
            return RedirectToAction("Index");
        }
    }
}