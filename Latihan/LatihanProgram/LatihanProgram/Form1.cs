using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LatihanProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void btn_demo_Click(object sender, EventArgs e)
        {
            for (int angka = 1; angka <= 7; angka++)
            {
                listBox1.Items.Add("Sistem Informasi");
            }
        }
    }
}
