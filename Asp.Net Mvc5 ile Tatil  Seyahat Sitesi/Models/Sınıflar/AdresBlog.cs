using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Asp.Net_Mvc5_ile_Tatil__Seyahat_Sitesi.Models.Sınıflar
{
    public class AdresBlog
    {
        [Key]
        public int ID { get; set; }
        public string Baslık { get; set; }
        public string Acıklama { get; set; }
        public string AdresAcık { get; set; }
        public string Maıl { get; set; }
        public string Telefon { get; set; }
        public string Konum { get; set; }


    }
}