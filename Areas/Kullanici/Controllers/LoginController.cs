using FurkanBelikirikSmartProFinalProject.Entities;
using FurkanBelikirikSmartProFinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FurkanBelikirikSmartProFinalProject.Areas.Kullanici.Controllers
{
    public class LoginController : Controller
    {
        // GET: Kullanici/Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(LoginViewModel login)
        {
            KutuphaneDBContext db = new KutuphaneDBContext();
            var kullanici = db.Kullanicilar.FirstOrDefault(x => x.KullaniciAdi == login.kullaniciAdi && x.Parola == login.sifre);
            if (kullanici == null)
            {
                ViewBag.Mesaj = "Kullanıcı adı veya parola hatalıdır.";
            }
            else
            {
                Session["Kullanici"] = kullanici;
                return RedirectToAction("Index","Home");
            }
            return View();
        }

        public ActionResult Cikis()
        {
            Session.Remove("Kullanici");
            return RedirectToAction("Index", "Home", new { area = "" });
        }
    }
}