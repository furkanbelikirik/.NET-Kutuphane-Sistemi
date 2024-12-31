using FurkanBelikirikSmartProFinalProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FurkanBelikirikSmartProFinalProject.Areas.Kullanici.Controllers
{
    public class KitaplarimController : Controller
    {
        KutuphaneDBContext db = new KutuphaneDBContext();
        // GET: Kullanici/Home
        public ActionResult Index()
        {
            var kullaniciId = Session["Kullanici"] as FurkanBelikirikSmartProFinalProject.Entities.Kullanici;
            var kiralikKitaplar = db.Kitap_Kullanici.Where(x => x.KullaniciId == kullaniciId.Id).ToList();

            string IadeMesaj = TempData["IadeMesaj"] as string;
            ViewBag.IadeMesaj = IadeMesaj;
            return View(kiralikKitaplar);
        }
        public ActionResult IadeEt(int id)
        {
            var kitap_kullanici_Id = db.Kitap_Kullanici.Find(id);
            var kitapAd = kitap_kullanici_Id.Kitap.KitapAdi;

            db.Kitap_Kullanici.Remove(kitap_kullanici_Id);
            db.Kitaplar.Find(kitap_kullanici_Id.KitapId).Stok++;

            try
            {
                db.SaveChanges();
                TempData["IadeMesaj"] = kitapAd + " adlı kitap başarıyla iade ettiniz!";
            }
            catch (Exception e)
            {
                TempData["IadeMesaj"] = e.Message;
            }
            return RedirectToAction("Index");
        }
    }
}