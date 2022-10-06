using StokKontrol.DbContext;
using StokKontrol.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokKontrol
{
    public partial class UrunListesi : Form
    {
        public UrunListesi()
        {
            InitializeComponent();
        }
        MyContext _db = new MyContext();

        private void btnUrunList_Click(object sender, EventArgs e)
        {
            
            Urunler urunler = new Urunler();

            dataGridView1.DataSource = _db.Urunlers.ToList();
            
            dataGridView1.Columns[5].Visible = false;
        }

        private void txtGnclUrunAd_TextChanged(object sender, EventArgs e)
        {
            string arama=txtGnclUrunAra.Text;

            var v1 = from item in _db.Urunlers
                     where item.Name.Contains(arama)
                     select item;
            dataGridView1.DataSource =v1.ToList();

        }

        private void txtGnclKategor_TextChanged(object sender, EventArgs e)
        {
            string arayan = txtGnclKategorAra.Text;

            var v2 = from item in _db.Urunlers
                     where item.Kategori.Contains(arayan)
                     select item;
            dataGridView1.DataSource = v2.ToList();
        }

        private void txtUrunIDAra_TextChanged(object sender, EventArgs e)
        {
            string id = txtUrunIDAra.Text;
            var v3 = from item in _db.Urunlers
                     where item.id.ToString().Contains(id)
                     select item;
            dataGridView1.DataSource = v3.ToList();

        }

        private void btnUrunGnclle_Click(object sender, EventArgs e)
        {
            int gncelle =Convert.ToInt32(txtUrunIDAra.Text);
            var v4 = _db.Urunlers.Find(gncelle);

            v4.Name = txtGncelAd.Text;
            v4.Kategori=txtGnclKata.Text;
            v4.Fiyat =Convert.ToDouble(txtGnclFiyat.Text);
            v4.Stok =Convert.ToInt32(txtGnclStok.Text);

            _db.SaveChanges();
            MessageBox.Show("Ürün Bilgileri Güncellendi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtGncelAd.Text = "";
            txtGnclKata.Text = "";
            txtGnclFiyat.Text = "";
            txtGnclStok.Text = "";
            
                     
            


        }
    }
}
