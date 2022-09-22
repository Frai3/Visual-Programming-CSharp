using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace No1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int start = 10;
        int finish = 200;

        private void btnFor_Click(object sender, EventArgs e)
        {
            txtTampil.Clear();
            MessageBox.Show("Halaman dibersihkan terlebih dahulu");

            for (int i = start; i<=finish; i++)
            {
                if (i % 2 == 1)
                {
                    txtTampil.Text += Convert.ToString(i + " ");
                }
            }

        }

        private void btnDoWhile_Click(object sender, EventArgs e)
        {
            txtTampil.Clear();
            MessageBox.Show("Halaman dibersihkan terlebih dahulu");

            int i = start;
            do
            {
                if (i % 2 == 1)
                {
                    txtTampil.Text += Convert.ToString(i + " ");
                }
                i++;
            } while (i <= finish);
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            txtTampil.Clear();
            MessageBox.Show("Halaman dibersihkan terlebih dahulu");

            int i = start;
            while (i <= finish)
            {
                if (i % 2 == 1)
                {
                    txtTampil.Text += Convert.ToString(i + " ");
                }
                i++;
            }
        }
    }
}
