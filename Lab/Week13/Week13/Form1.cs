using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static DateTime awal { get; set; }
        public static DateTime akhir { get; set; }
        public static string gender { get; set; }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = ("SOAL 1");
        }

        private void laki_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Laki-Laki";

        }

        private void perempuan_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Perempuan";
        }

        private void btnParameter_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void btnFormula_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void tglAwal_ValueChanged(object sender, EventArgs e)
        {
            tglAwal.Format = DateTimePickerFormat.Custom;
            tglAwal.CustomFormat = "yyy/MM/dd";
            awal = tglAwal.Value.Date;
        }

        private void tglAkhir_ValueChanged(object sender, EventArgs e)
        {
            tglAkhir.Format = DateTimePickerFormat.Custom;
            tglAkhir.CustomFormat = "yyy/MM/dd";
            akhir = tglAkhir.Value.Date;
        }
    }
}
