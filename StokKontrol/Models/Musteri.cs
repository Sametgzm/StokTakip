using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokKontrol.Models
{
    public class Musteri
    {
        public int id { get; set; }
        public string AdSoyad { get; set; }
        public string Telefon { get; set; }       
        public string Kimlik { get; set; }
        public string Mail { get; set; }
        public string Adres { get; set; }
        public int Adet { get; set; }

        public float Tutar { get; set; }

        public virtual  Urunler Urunler { get; set; }

    }
}
