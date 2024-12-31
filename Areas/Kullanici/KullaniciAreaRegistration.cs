using System.Web.Mvc;

namespace FurkanBelikirikSmartProFinalProject.Areas.Kullanici
{
    public class KullaniciAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Kullanici";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Kullanici_default",
                "Kullanici/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional },
                new[] { "FurkanBelikirikSmartProFinalProject.Areas.Kullanici.Controllers" }
            );
        }
    }
}