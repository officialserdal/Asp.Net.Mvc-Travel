using Asp.Net_Mvc5_ile_Tatil__Seyahat_Sitesi.Models.Sınıflar;
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
            //var blogbul = c.Blogs.Where(x => x.ID == id).ToList();
            by.deger1 = c.Blogs.Where(x => x.ID == id).ToList();
            by.deger2 = c.Yorumlars.Where(x => x.ID == id).ToList();


            return View(by);

        }
    }

}