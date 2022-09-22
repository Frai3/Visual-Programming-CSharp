using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int jenis = 0;

        private void btnPersegi_Click(object sender, EventArgs e)
        {
            jenis = 1;
            lblAngka1.Text = "Panjang";
            lblAngka2.Text = "Lebar";
        }

        private void btnJajarGenjang_Click(object sender, EventArgs e)
        {
            lblAngka1.Text = "Alas";
            lblAngka2.Text = "Tinggi";
            jenis = 2;
        }

        private void btnSegitiga_Click(object sender, EventArgs e)
        {
            lblAngka1.Text = "Alas";
            lblAngka2.Text = "Tinggi";
            jenis = 3;
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {

            if(jenis == 1)
            {
                int  panjang, lebar, hasil;
                panjang = Convert.ToInt32(txtAngka1.Text);
                lebar = Convert.ToInt32(txtAngka2.Text);

                PersegiPanjang luas = new PersegiPanjang();

                hasil = luas.Hitung(panjang, lebar);
                txtHasil.Text = hasil.ToString();

            }
            else if(jenis == 2)
            {
                int alas, tinggi, hasil;
                alas = Convert.ToInt32(txtAngka1.Text);
                tinggi = Convert.ToInt32(txtAngka2.Text);

                JajarGenjang luas = new JajarGenjang();

                hasil = luas.Luas(alas, tinggi);
                txtHasil.Text = hasil.ToString();
            }
            else
            {
                double alas, tinggi, hasil;
                alas = Convert.ToDouble(txtAngka1.Text);
                tinggi = Convert.ToDouble(txtAngka2.Text);

                Segitiga luas = new Segitiga();

                hasil = luas.Luas(alas, tinggi);
                txtHasil.Text = hasil.ToString();
            }

        }
    }
}
