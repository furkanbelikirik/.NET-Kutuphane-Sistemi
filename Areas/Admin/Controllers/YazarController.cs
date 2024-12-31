using FurkanBelikirikSmartProFinalProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace FurkanBelikirikSmartProFinalProject.Areas.Admin.Controllers
{
    public class YazarController : Controller
    {
        KutuphaneDBContext db = new KutuphaneDBContext();

        // GET: Yazar
        public ActionResult Index()
        {
            var yazarlar = db.Yazarlar.ToList();
            string silMesaj = TempData["SilMesaj"] as string;
            ViewBag.SilMesaj = silMesaj;
            return View(yazarlar);
        }
        public ActionResult Ekle()
        {
            return View(new Yazarlar());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Ekle(Yazarlar yazar)
        {
            db.Yazarlar.Add(yazar);

            try
            {
                db.SaveChanges();
                ViewBag.Mesaj = 1;
            }
            catch (Exception)
            {
                ViewBag.Mesaj = 0;
            }

            return View(yazar);
        }
        public ActionResult Duzenle(int id)
        {
            var yazar = db.Yazarlar.Find(id);          
            return View(yazar);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Duzenle(Yazarlar yazar)
        {
            var duzenle = db.Yazarlar.Find(yazar.Id);
            duzenle.YazarAdi = yazar.YazarAdi;

            try
            {
                db.SaveChanges();
                ViewBag.Mesaj = 1;
            }
            catch (Exception)
            {
                ViewBag.Mesaj = 0;
            }

            return View(yazar);
        }
        public ActionResult Sil(int id)
        {
            var yazarId = db.Yazarlar.Find(id);
            db.Yazarlar.Remove(yazarId);
            try
            {
                db.SaveChanges();
                TempData["SilMesaj"] = yazarId.YazarAdi + " başarıyla silindi!";
            }
            catch (Exception)
            {
                TempData["SilMesaj"] = "Silme işlemi sırasında bir hata meydana geldi!";
            }
            return RedirectToAction("Index");
        }
        public ActionResult YazarinKitaplari(int id)
        {
            var kitaplar = db.Kitaplar.Where(x => x.Yazar.Id == id).ToList();

            return View(kitaplar);
        }
    }
}