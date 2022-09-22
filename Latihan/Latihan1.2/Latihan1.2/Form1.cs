using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan1._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = Convert.ToInt32(txtAngka1.Text);
            b = Convert.ToInt32(txtAngka2.Text);

            c = a + b;
            Hasil.Text = Convert.ToString(c);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnKurang_Click(object sender, EventArgs e)
        {

            int a, b, c;
            a = Convert.ToInt32(txtAngka1.Text);
            b = Convert.ToInt32(txtAngka2.Text);

            c = a - b;
            Hasil.Text = Convert.ToString(c);

        }

        private void btnKali_Click(object sender, EventArgs e)
        {

            int a, b, c;
            a = Convert.ToInt32(txtAngka1.Text);
            b = Convert.ToInt32(txtAngka2.Text);

            c = a * b;
            Hasil.Text = Convert.ToString(c);

        }

        private void btnBagi_Click(object sender, EventArgs e)
        {

            double a, b, c;
            a = Convert.ToDouble(txtAngka1.Text);
            b = Convert.ToDouble(txtAngka2.Text);

            c = a / b;
            Hasil.Text = Convert.ToString(c);

        }
    }
}
