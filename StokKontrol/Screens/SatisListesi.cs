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
    public partial class frmSatis : Form
    {
        public frmSatis()
        {
            InitializeComponent();
        }
        MyContext _db = new MyContext();


        private void btnSatis_Click(object sender, EventArgs e)
        {
            var a = _db.Musteris.ToList();
            var b = _db.Urunlers.ToList();




            for (int i = 0; i < a.Count; i++)
            {
                
                dgSatis.Rows.Add();
                dgSatis.Rows[i].Cells[0].Value = a[i].AdSoyad.ToString();
                dgSatis.Rows[i].Cells[1].Value = a[i].Telefon.ToString();
                dgSatis.Rows[i].Cells[2].Value = b.Where(s => s.id == a[i].Urunler.id).Select(s => s.Name).First();
                dgSatis.Rows[i].Cells[3].Value = b.Where(s => s.id == a[i].Urunler.id).Select(s => s.Kategori).FirstOrDefault();
                dgSatis.Rows[i].Cells[4].Value = a[i].Adet.ToString();
                dgSatis.Rows[i].Cells[5].Value = b.Where(s => s.id == a[i].Urunler.id).Select(s => s.Fiyat).FirstOrDefault()* a[i].Adet; 

                dgSatis.Rows[i].Cells[6].Value = a[i].Adres.ToString();
            }

        }

    }
}
