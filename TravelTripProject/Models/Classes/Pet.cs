using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProject.Models.Classes
{
    public class Pet
    {
        [Key]
        public int ID { get; set; }
        public string Tur { get; set; }
        public string Cins { get; set; }
        public string Cinsiyet { get; set; }
        public string Aciklama { get; set; }
        public string Konum { get; set; }
        public DateTime Tarih { get; set; }
        public string Image { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public string Yas { get; set; }
        public string Asilar { get; set; }
        public string Yayinlayan { get; set; }
        public string TelefonNumarasi { get; set; }
        public string Siluet { get; set; }
    }
}