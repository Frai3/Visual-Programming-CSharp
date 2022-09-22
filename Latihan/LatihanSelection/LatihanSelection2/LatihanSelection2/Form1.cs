using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LatihanSelection2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {

            int nilai = 0;
            nilai = int.Parse(txtNilai.Text);
            if (nilai < 50)
                listHasil.Text = "Gagal";
            else if (nilai < 60)
                listHasil.Text = "C";
            else if (nilai < 80)
                listHasil.Text = "B";
            else if (nilai < 101)
                listHasil.Text = "A";
            listHasil.Items.Add(nilai + "==>" + listHasil.Text);
        }
    }
}
