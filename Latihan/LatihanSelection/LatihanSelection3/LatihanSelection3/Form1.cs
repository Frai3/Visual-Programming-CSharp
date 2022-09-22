using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LatihanSelection3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            double angkaMax = 0.0;

            if(Double.Parse(txtAngka1.Text) > Double.Parse(txtAngka2.Text))
            {
                angkaMax = Double.Parse(txtAngka1.Text);
            }
            else
            {
                angkaMax = Double.Parse(txtAngka2.Text);
            }
            lblHasil.Text = "Angka Tertinggi Adalah: " + angkaMax;
        }
    }
}