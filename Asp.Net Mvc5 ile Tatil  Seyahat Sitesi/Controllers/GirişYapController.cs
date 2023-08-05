using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Asp.Net_Mvc5_ile_Tatil__Seyahat_Sitesi.Models.Sınıflar;


namespace Asp.Net_Mvc5_ile_Tatil__Seyahat_Sitesi.Controllers
{
    public class GirişYapController : Controller
    {
        // GET: GirişYap
        Context c = new Context();

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {

            return View();

        }
        [HttpPost]
        public ActionResult Login(Admin ad)
        {
            var bilgiler = c.Admins.FirstOrDefault(x => x.Kullanıcı == ad.Kullanıcı && x.Sıfre == ad.Sıfre);
            if (bilgiler!=null)
            {
                FormsAuthentication.SetAuthCookie(bilgiler.Kullanıcı,false);
                Session["kullanıcı"] = bilgiler.Kullanıcı.ToString();
                return RedirectToAction("Index", "Admin");
                 
            }
            else
            {
                return View();

            }

        }
    }
}