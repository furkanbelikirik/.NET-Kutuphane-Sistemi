using FurkanBelikirikSmartProFinalProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FurkanBelikirikSmartProFinalProject.Controllers
{
    public class HomeController : Controller
    {
        KutuphaneDBContext db = new KutuphaneDBContext();

        // GET: Home
        public ActionResult Index(string aramaKelimesi)
        {
            if (Session["Admin"] != null)
            {
                return RedirectToAction("Index", "Home", new { area = "Admin" });
            }
            else if (Session["Kullanici"] != null)
            {
                return RedirectToAction("Index", "Home", new { area = "Kullanici" });
            }
            else
            {
                var kitaplar = db.Kitaplar.ToList();

                if (!String.IsNullOrEmpty(aramaKelimesi))
                {
                    kitaplar = kitaplar.Where(x => x.KitapAdi.ToLower().Contains(aramaKelimesi)).ToList();
                }
                return View(kitaplar);
            }
        }
    }
}