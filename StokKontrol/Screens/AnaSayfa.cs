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
    public partial class frmAnaSayfa : Form
    {
        public frmAnaSayfa()
        {
            InitializeComponent();
        }
        private void frmAnaSayfa_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UrunEkle form1 = new UrunEkle();
            form1.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MusteriEkle form2 = new MusteriEkle();
            form2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UrunListesi form3 = new UrunListesi();
            form3.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MusteriListesi form4 = new MusteriListesi();
            form4.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmSatis form5 = new frmSatis();
            form5.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("YAKINDA HİZMETE GİRİCEK", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        
    }
}
