using Asp.Net_Mvc5_ile_Tatil__Seyahat_Sitesi.Models.Sınıflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Asp.Net_Mvc5_ile_Tatil__Seyahat_Sitesi.Controllers
{
    public class RestoranlarController : Controller
    {
        // GET: Restoranlar
        Context s = new Context();
        public ActionResult Index()
        {
            var deger = s.Restoranlars.ToList();
            return View(deger);
        }
    }
}