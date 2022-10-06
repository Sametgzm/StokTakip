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
    public partial class MusteriListesi : Form
    {
        public MusteriListesi()
        {
            InitializeComponent();
        }
        MyContext _db = new MyContext();
        private void btnMusteriList_Click(object sender, EventArgs e)
        {

            Musteri musteri = new Musteri();

            dataGridView2.DataSource = _db.Musteris.ToList();
            dataGridView2.Columns[8].Visible = false;



        }

        private void btnMusteriAra_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = _db.Musteris.Where(x => x.AdSoyad == txtMusteriAra.Text || x.Adres == txtMusteriAra.Text).ToList();
        }

        private void txtMusteriAra_TextChanged(object sender, EventArgs e)
        {
            string aranan = txtMusteriAra.Text;

            var degerler = from item in _db.Musteris
                           where item.AdSoyad.Contains(aranan)
                           select item;

            dataGridView2.DataSource = degerler.ToList();
        }

        private void btnMusteriGncl_Click(object sender, EventArgs e)
        {
            int secilenid = Convert.ToInt32(txtGnclTutar.Text);



            int id = Convert.ToInt32(txtAraid.Text);
            var x = _db.Musteris.Find(id);            
            x.AdSoyad = txtGncelAd.Text;
            x.Telefon = mskGncelTel.Text;
            x.Kimlik = txtGnclKmlk.Text;
            x.Mail = txtGncelMail.Text;
            x.Adres = txtGnclAdres.Text;
            x.Adet = Convert.ToInt32(txtGnclAdet.Text);
           
            x.Tutar = (float)_db.Urunlers.Where(z => z.id == secilenid).Select(c => c.Fiyat).SingleOrDefault();
            _db.SaveChanges();
            MessageBox.Show("Müşteri Güncellendi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtGncelAd.Text = "";
            mskGncelTel.Text = "";
            txtGnclKmlk.Text = "";
            txtGnclAdres.Text = "";
            txtGncelMail.Text = "";
            txtGnclAdet.Text = "";
            txtGnclTutar.Text = "";

        }

        private void txtAdresAra_TextChanged(object sender, EventArgs e)
        {
            string adaranan = txtAdresAra.Text;
            var deger = from item in _db.Musteris
                        where item.Adres.Contains(adaranan)
                        select item;
            dataGridView2.DataSource = deger.ToList();
        }

        private void txtAraid_TextChanged(object sender, EventArgs e)
        {
            string id = txtAraid.Text;

            var v5 = from item in _db.Musteris
                     where item.id.ToString().Contains(id)
                     select item;
            dataGridView2.DataSource = v5.ToList();
        }
    }
}
