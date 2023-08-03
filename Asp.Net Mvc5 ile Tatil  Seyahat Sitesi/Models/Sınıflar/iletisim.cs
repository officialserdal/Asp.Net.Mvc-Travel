using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Asp.Net_Mvc5_ile_Tatil__Seyahat_Sitesi.Models.Sınıflar
{
    public class iletisim
    {
        [Key]
        public int ID { get; set; }
        public string AdSoyad { get; set; }

        public string Maıl { get; set; }
        public string Konu { get; set; }
        public string Mesaj { get; set; }


    }
    
}