﻿using Asp.Net_Mvc5_ile_Tatil__Seyahat_Sitesi.Models.Sınıflar;
using System.Linq;
using System.Web.Mvc;

namespace Asp.Net_Mvc5_ile_Tatil__Seyahat_Sitesi.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        Context c = new Context();
        BlogYorum by = new BlogYorum();
        public ActionResult Index()

        {
            //var bloglar = c.Blogs.ToList();
            by.deger1 = c.Blogs.ToList();
            by.deger3 = c.Blogs.OrderByDescending(x => x.ID).Take(3).ToList();
            by.deger4 = c.Yorumlars.ToList();
            return View(by);
        }
       
        public ActionResult BlogDetay(int id)
        {
            //var blogbul = c.Blogs.Where(x => x.ID == id).ToList(); bro dediğin gibi yayınla siteyi çok güzel bir bastit mvc sitesi çok güzel durur githubda tm kanka 
            by.deger1 = c.Blogs.Where(x => x.ID == id).ToList();
            by.deger2 = c.Yorumlars.Where(x => x.Blogid == id).ToList();


            return View(by);

        }
        [HttpGet]
        public PartialViewResult YorumYap(int id)
        {
            ViewBag.deger = id;
            return PartialView();

        }



        [HttpPost]
        public PartialViewResult YorumYap(Yorumlar y)
        {
            c.Yorumlars.Add(y);
            c.SaveChanges();
            return PartialView();

        }
    }

}