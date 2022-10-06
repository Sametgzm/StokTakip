using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.Entity;
using StokKontrol.DbContext;
using StokKontrol.Models;

namespace StokKontrol
{
    public partial class UrunEkle : Form
    {
        public UrunEkle()
        {
            InitializeComponent();
        }

        private void btnUrunKyt_Click(object sender, EventArgs e)
        {
            MyContext _db = new MyContext();
            
            Urunler urunler = new Urunler();

            urunler.Name = txtUrunEkle.Text;
            urunler.Kategori = txtKategori.Text;
            urunler.Fiyat =Convert.ToInt32(txtFiyat.Text);
            urunler.Stok =Convert.ToInt32(txtStok.Text);

            _db.Urunlers.Add(urunler);
            _db.SaveChanges();
            MessageBox.Show("Ürün Kaydedildi","BİLGİ",MessageBoxButtons.OK,MessageBoxIcon.Warning);

            txtKategori.Text = "";
            txtFiyat.Text = "";
            txtStok.Text = "";
            txtUrunEkle.Text = "";
        }
    }
}
