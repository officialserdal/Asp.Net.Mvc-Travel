using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Asp.Net_Mvc5_ile_Tatil__Seyahat_Sitesi.Models.Sınıflar;

namespace Asp.Net_Mvc5_ile_Tatil__Seyahat_Sitesi.Controllers
{
    public class RehberController : Controller
    {
        Context t = new Context();
        // GET: Rehber
        public ActionResult Index()
        {
            var degerler = t.Rehbers.ToList();
            return View(degerler);
        }
    }
}