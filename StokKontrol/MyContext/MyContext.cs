using StokKontrol.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokKontrol.DbContext
{
    public class MyContext : System.Data.Entity.DbContext
    {
        public DbSet<Urunler> Urunlers { get; set; }
        public DbSet<Musteri> Musteris { get; set; }

    }
}
