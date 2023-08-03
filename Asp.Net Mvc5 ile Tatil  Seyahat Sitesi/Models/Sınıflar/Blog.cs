using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Asp.Net_Mvc5_ile_Tatil__Seyahat_Sitesi.Models.Sınıflar
{
    public class Blog
    {

     public int ID { get; set; }
    public string Baslık { get; set; }
    public DateTime Tarih { get; set; }
    public string Acıklama { get; set; }
     public string BlogImage { get; set; }
        public ICollection<Yorumlar> Yorumlars { get; set; }

    }
}