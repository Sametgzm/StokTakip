using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokKontrol.Models
{
    public class Urunler
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Kategori { get; set; }
        public double Fiyat { get; set; }
        public int Stok { get; set; }




        public virtual IEnumerable<Musteri> Musteris { get; set; }


    }
}
