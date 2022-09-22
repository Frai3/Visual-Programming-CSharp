using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        class karyawan
        {
            public void upah(double UpahJam, double UpahTambahan, int WaktuKerja)
            {
                jam = UpahJam;
                tambahan = UpahTambahan;
                waktu = WaktuKerja;
            }

            protected double jam;
            protected double tambahan;
            protected double waktu;
            public DateTime tglLahir { get; set; }

            public int umur()
            {
                int usia;
                DateTime tahun = DateTime.Now;
                usia = tahun.Year - tglLahir.Year;
                return usia;
            }
        }

        class pegawai : karyawan
        {
            public double gajiPegawai()
            {
                return ((jam*waktu)+tambahan) * 30;
            }
        }

        class buruh : karyawan
        {
            public double gajiBuruh()
            {
                return (jam * waktu) + tambahan;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNama.Clear();
            txtNamaLengkap.Clear();
            txtPanggilan.Clear();
            txtAlamat.Clear();
            txtJamKerja.Clear();
            txtTglLahir.Value = DateTime.Now;
            txtUmur.Clear();
            txtUpah.Clear();
            txtUpahJam.Clear();
            txtUpahTambahan.Clear();
            comboRole.SelectedIndex = -1 ;


            btnClear.Enabled = false;
            btnSubmit.Enabled = true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            double upahJam, upahTambahan, gaji = 0;
            int jamKerja, umur;
            DateTime tglLahir;

            jamKerja = Convert.ToInt32(txtJamKerja.Text);
            upahJam = Convert.ToDouble(txtUpahJam.Text);
            upahTambahan = Convert.ToDouble(txtUpahTambahan.Text);
            tglLahir = Convert.ToDateTime(txtTglLahir.Text);
            
            if (comboRole.SelectedIndex == 0)
            {
                pegawai emp = new pegawai();

                emp.upah(upahJam, upahTambahan, jamKerja);
                gaji = emp.gajiPegawai();
                txtUpah.Text = Convert.ToString("RP. " + gaji);

                emp.tglLahir = tglLahir;
                umur = emp.umur();
                txtUmur.Text = Convert.ToString(umur);
            }
            else
            {
                buruh emp = new buruh();

                emp.upah(upahJam, upahTambahan, jamKerja);
                gaji = emp.gajiBuruh();
                txtUpah.Text = Convert.ToString("RP. " + gaji);

                emp.tglLahir = tglLahir;
                umur = emp.umur();
                txtUmur.Text = Convert.ToString(umur);
            }

            txtUpahJam.Text = Convert.ToString("Rp. " + upahJam);
            txtUpahTambahan.Text = Convert.ToString("Rp. " + upahTambahan);

            btnSubmit.Enabled = false;
            btnClear.Enabled = true;
        }
    }
}
