using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Asp.Net_Mvc5_ile_Tatil__Seyahat_Sitesi.Models.Sınıflar;

namespace Asp.Net_Mvc5_ile_Tatil__Seyahat_Sitesi.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        Context snf = new Context();
        public ActionResult Index()
        {
            var degerler = snf.Hakkimizdas.ToList();
            
            return View(degerler);
        }
    }
}