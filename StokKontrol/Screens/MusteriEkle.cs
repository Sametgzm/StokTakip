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
    public partial class MusteriEkle : Form
    {
        public MusteriEkle()
        {
            InitializeComponent();
        }

        private void btnMusterKyt_Click(object sender, EventArgs e)
        {

            MyContext _db = new MyContext();

            Musteri musteri = new Musteri();
         
            var urnname = comboBox1.Text;

            musteri.AdSoyad = txtAdSoyad.Text;
            musteri.Telefon = mskbxTelefon.Text;
            musteri.Kimlik = txtKimlik.Text;
            musteri.Mail = txtMail.Text;
            musteri.Adres = txtAdres.Text;
            musteri.Adet = Convert.ToInt32(txtAdet.Text);
            musteri.Urunler = _db.Urunlers.Where(s => s.Name == urnname).FirstOrDefault();
            musteri.Tutar = (float)_db.Urunlers.Where(s => s.Name == urnname).Select(c => c.Fiyat).FirstOrDefault() * Convert.ToInt32(txtAdet.Text);

            _db.Musteris.Add(musteri);
            _db.SaveChanges();

            MessageBox.Show("Müşteri Kaydedildi","BİLGİ",MessageBoxButtons.OK,MessageBoxIcon.Information);

            txtAdres.Text = "";
            txtAdSoyad.Text = "";
            txtMail.Text = "";
            mskbxTelefon.Text = "";
            txtKimlik.Text = "";


        }

        private void MusteriEkle_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stokKontrolDataSet.Urunlers' table. You can move, or remove it, as needed.
            this.urunlersTableAdapter.Fill(this.stokKontrolDataSet.Urunlers);

        }
    }
}
