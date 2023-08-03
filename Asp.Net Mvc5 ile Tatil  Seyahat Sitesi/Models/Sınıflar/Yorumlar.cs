using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Asp.Net_Mvc5_ile_Tatil__Seyahat_Sitesi.Models.Sınıflar
{
    public class Yorumlar
    {
        [Key]
        public int ID { get; set; }
        public string KullanıcıAdı { get; set; }
        public string Maıl { get; set; }
        public string Yorum  { get; set; }
        public int Blogid { get; set; }
        public virtual Blog blog  { get; set; }

    }
}