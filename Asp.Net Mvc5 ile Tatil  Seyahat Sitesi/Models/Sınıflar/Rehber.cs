using System.ComponentModel.DataAnnotations;

namespace Asp.Net_Mvc5_ile_Tatil__Seyahat_Sitesi.Models.Sınıflar
{
    public class Rehber
    {
        [Key]
        public int İD { get; set; }
        public string Açiklama { get; set; }
        public string fotourl { get; set; }

    }
}