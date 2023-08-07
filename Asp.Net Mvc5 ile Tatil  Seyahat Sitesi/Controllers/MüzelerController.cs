using Asp.Net_Mvc5_ile_Tatil__Seyahat_Sitesi.Models.Sınıflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Asp.Net_Mvc5_ile_Tatil__Seyahat_Sitesi.Controllers
{
    public class MüzelerController : Controller
    {
        // GET: Müzeler
        Context a = new Context();
        public ActionResult Index()
        {
            var degerler = a.Müzelers.ToList();
            return View(degerler);

        }
    }
}