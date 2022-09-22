using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            string nama, pesan;
            int semester;
            double konsumsi, transportasi, akomodasi, komunikasi, kuliah, buku, total;

            nama = txtNama.Text;
            semester = Convert.ToInt32(txtSemester.Text);
            konsumsi = Convert.ToDouble(txtKonsumsi.Text);
            transportasi = Convert.ToDouble(txtTransportasi.Text);
            akomodasi = Convert.ToDouble(txtAkomodasi.Text);
            komunikasi = Convert.ToDouble(txtKomunikasi.Text);
            kuliah = Convert.ToDouble(txtKuliah.Text);
            buku = Convert.ToDouble(txtBuku.Text);

            perhitungan hitung = new perhitungan();
            hitung.hitungAkomodasi(akomodasi, semester);
            hitung.hitungBuku(buku, semester);
            hitung.hitungKomunikasi(komunikasi, semester);
            hitung.hitungKuliah(kuliah, semester);
            hitung.hitungKonsumsi(konsumsi, semester);
            hitung.hitungTransportasi(transportasi, semester);

            total = hitung.hasilAkomodasi + hitung.hasilBuku + hitung.hasilKomunikasi + hitung.hasilKonsumsi + hitung.hasilKuliah + hitung.hasilTransportasi;
            pesan = "Hai, " + nama + "! Biaya yang akan kamu keluarkan untuk kuliah selama " + semester + " semester adalah sebesar Rp. " + String.Format("{0:n}", total);
            MessageBox.Show(pesan);

        }
    }
}
