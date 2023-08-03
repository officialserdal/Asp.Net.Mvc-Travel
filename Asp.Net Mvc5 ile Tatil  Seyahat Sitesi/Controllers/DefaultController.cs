using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Asp.Net_Mvc5_ile_Tatil__Seyahat_Sitesi.Models.Sınıflar;

namespace Asp.Net_Mvc5_ile_Tatil__Seyahat_Sitesi.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        Context db = new Context();
       
        public ActionResult Index()
        {
            var degerler = db.Blogs.Take(10).ToList();
            return View(degerler);


            
        }
        //public ActionResult About()
        //{
        //    return View();
        //}
        public PartialViewResult Partial1()
        {
            var degerler = db.Blogs.OrderByDescending(x => x.ID).Take(2).ToList();
            return PartialView(degerler);
        }
        public PartialViewResult Partial2()
        {
            var deger = db.Blogs.OrderByDescending(x => x.ID==1).Take(2).ToList();
            return PartialView(deger);
        }
        public PartialViewResult Partial3()
        {
            var deger = db.Blogs.Take(10).ToList();
            return PartialView(deger);
        }
        public PartialViewResult Partial4()
        {
            var deger = db.Blogs.Take(3).ToList();
            return PartialView(deger);
        }
        public PartialViewResult Partial5()
        {
            var deger = db.Blogs.Take(3).OrderByDescending(x => x.ID).ToList();
            return PartialView(deger);
        }
    }
}