using FurkanBelikirikSmartProFinalProject.Entities;
using FurkanBelikirikSmartProFinalProject.Models;
using System;
using System.Collections.Generic;
using System.EnterpriseServices.CompensatingResourceManager;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FurkanBelikirikSmartProFinalProject.Areas.Admin.Controllers
{

    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(LoginViewModel login)
        {
            KutuphaneDBContext db = new KutuphaneDBContext();
            var admin = db.Adminler.FirstOrDefault(x => x.KullaniciAdi == login.kullaniciAdi && x.Parola == login.sifre);
            if (admin == null)
            {
                ViewBag.Mesaj = "Kullanıcı adı veya parola hatalıdır.";
            }
            else
            {
                Session["Admin"] = admin;
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        public ActionResult Cikis()
        {
            Session.Remove("Admin");
            return RedirectToAction("Index","Home", new { area = "" });
        }
    }
}