using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Nilai mahasiswa1 = new Nilai();
        private void btnHitung1_Click(object sender, EventArgs e)
        {
            string nama, matkul, final;
            nama = txtNamaS1.Text;
            matkul = txtMatkulS1.Text;
                        
            mahasiswa1.tugas = Convert.ToDouble(txtTugasS1.Text);
            mahasiswa1.uas = Convert.ToDouble(txtUASS1.Text);
            mahasiswa1.uts = Convert.ToDouble(txtUTSS1.Text);

            if (mahasiswa1.tugas > 100 || mahasiswa1.uts > 100 || mahasiswa1.uas > 100)
            {
                string pesan = "Nilai maksimal adalah 100. Harap masukkan nilai dengan benar";
                MessageBox.Show(pesan);
            }
            else
            {
                mahasiswa1.calculate();
                final = mahasiswa1.nilaiHuruf();
                txtNilaiS1.Text = final;
            }
            
        }

        Nilai mahasiswa2 = new Nilai();
        private void btnHitung2_Click(object sender, EventArgs e)
        {
            string nama, matkul, final;
            nama = txtNamaS2.Text;
            matkul = txtMatkulS2.Text;

            mahasiswa2.tugas = Convert.ToDouble(txtTugasS2.Text);
            mahasiswa2.uas = Convert.ToDouble(txtUASS2.Text);
            mahasiswa2.uts = Convert.ToDouble(txtUTSS2.Text);

            if (mahasiswa2.tugas > 100 || mahasiswa2.uts > 100 || mahasiswa2.uas > 100)
            {
                string pesan = "Nilai maksimal adalah 100. Harap masukkan nilai dengan benar";
                MessageBox.Show(pesan);
            }
            else
            {
                mahasiswa2.calculate();
                final = mahasiswa2.nilaiHuruf();
                txtNilaiS2.Text = final;
            }
        }

        private void btnAverage_Click(object sender, EventArgs e)
        {
            double nilai1 = mahasiswa1.final;
            double nilai2 = mahasiswa2.final;

            double avg = (nilai1 + nilai2) / 2;
            txtAverage.Text = Convert.ToString(avg);
        }
    }
}