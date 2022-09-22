using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace No2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void monthly(out double pinjaman, out double angsuran, out double bunga)
        {
        
            pinjaman = Convert.ToDouble(txtPinjam.Text);
            angsuran = Convert.ToDouble(txtAngsur.Text);
            bunga = Convert.ToDouble(txtAngsur.Text);

        }

        public void printLoan(double pinjaman, double angsuran, double bunga)
        {

            double bulanan = (pinjaman + (pinjaman * (bunga / 100))) / angsuran;
            MessageBox.Show("Yang harus dibayar setiap bulannya: " + bulanan);

            int j = 0;
            double hasil = 0;

            for (double i = pinjaman; i >= 0; i = i - bulanan)
            {
                j += 1;
                if (i == 0)
                {
                    hasil = pinjaman;
                }
                else
                {
                    hasil -= i;
                }
                
                txtShow.Text += "Pembayaran ke-" + j.ToString() + "Sisa Pinjaman " + i + Environment.NewLine;
            }

        }
        private void btnHitung_Click(object sender, EventArgs e)
        {
            double pinjaman, angsuran, bunga, bulanan;
            monthly(out pinjaman, out angsuran, out bunga);

            printLoan(pinjaman, angsuran, bunga);
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAngsur.Clear();
            txtBunga.Clear();
            txtPinjam.Clear();
            txtShow.Clear();
        }
    }
}
