using FurkanBelikirikSmartProFinalProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FurkanBelikirikSmartProFinalProject.Areas.Admin.Controllers
{
    public class KitapController : Controller
    {
        KutuphaneDBContext db = new KutuphaneDBContext();

        // GET: Kitap
        public ActionResult Index()
        {
            var kitaplar = db.Kitaplar.ToList();

            string silMesaj = TempData["SilMesaj"] as string;
            ViewBag.SilMesaj = silMesaj;
            return View(kitaplar);
        }
        public ActionResult Ekle()
        {
            ViewBag.YazarlarSelectList = new SelectList(db.Yazarlar, "Id", "YazarAdi");
            return View(new Kitaplar());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Ekle(Kitaplar kitap)
        {
            db.Kitaplar.Add(kitap);

            try
            {
                db.SaveChanges();
                ViewBag.Mesaj = 1;
            }
            catch (Exception)
            {
                ViewBag.Mesaj = 0;
            }

            ViewBag.YazarlarSelectList = new SelectList(db.Yazarlar, "Id", "YazarAdi", kitap.YazarId);
            return View(kitap);
        }
        public ActionResult Duzenle(int id)
        {
            var kitap = db.Kitaplar.Find(id);
            ViewBag.YazarlarSelectList = new SelectList(db.Yazarlar, "Id", "YazarAdi");
            return View(kitap);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Duzenle(Kitaplar kitap)
        {
            var duzenle = db.Kitaplar.Find(kitap.Id);
            duzenle.KitapAdi = kitap.KitapAdi;
            duzenle.YazarId = kitap.YazarId;
            duzenle.Dil = kitap.Dil;
            duzenle.YayimYili = kitap.YayimYili;
            duzenle.SayfaSayisi = kitap.SayfaSayisi;
            duzenle.ISBN = kitap.ISBN;
            duzenle.Yayınevi = kitap.Yayınevi;
            duzenle.Stok = kitap.Stok;

            try
            {
                db.SaveChanges();
                ViewBag.Mesaj = 1;
            }
            catch (Exception)
            {
                ViewBag.Mesaj = 0;
            }

            ViewBag.YazarlarSelectList = new SelectList(db.Yazarlar, "Id", "YazarAdi", kitap.YazarId);
            return View(kitap);
        }
        public ActionResult Sil(int id)
        {
            var kitapId = db.Kitaplar.Find(id);
            db.Kitaplar.Remove(kitapId);
            try
            {
                db.SaveChanges();
                TempData["SilMesaj"] = kitapId.KitapAdi + " başarıyla silindi!";
            }
            catch (Exception)
            {
                TempData["SilMesaj"] = "Silme işlemi sırasında bir hata meydana geldi!";
            }
            return RedirectToAction("Index");
        }
    }
}