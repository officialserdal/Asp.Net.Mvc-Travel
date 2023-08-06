using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Asp.Net_Mvc5_ile_Tatil__Seyahat_Sitesi.Models.Sınıflar
{
    public class Oteller
    {
        [Key]
        public int İD { get; set; }
        public string OtelAdi { get; set; }
        public string fotourl { get; set; }
        public string Açiklama { get; set; }


    }
}