using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Asp.Net_Mvc5_ile_Tatil__Seyahat_Sitesi.Models.Sınıflar;

namespace Asp.Net_Mvc5_ile_Tatil__Seyahat_Sitesi.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context c = new Context();

        public ActionResult Index()
        {
            var degerler = c.Blogs.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult YeniBlog()
        {
            return View();

        }
        [HttpPost]
        public ActionResult YeniBlog(Blog p)
        {
            c.Blogs.Add(p);
            c.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}