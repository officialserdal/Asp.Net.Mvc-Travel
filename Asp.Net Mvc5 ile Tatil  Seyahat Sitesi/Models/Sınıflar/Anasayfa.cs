using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Asp.Net_Mvc5_ile_Tatil__Seyahat_Sitesi.Models.Sınıflar
{
    public class Anasayfa
    {
        [Key]
        public int ID { get; set; }
        public string Başlık { get; set; }
        public  string Açıklama { get; set; }


    }
}