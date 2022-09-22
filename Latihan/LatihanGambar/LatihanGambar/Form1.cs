using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LatihanGambar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(pictureBox2.Visible == true)
            {
                change1();
            }
            else
            {
                change2();
            }
        }

        private void change1()
        {
            pictureBox2.Visible = false;
            label1.Text = "OFF";
        }

        private void change2()
        {
            pictureBox2.Visible = true;
            label1.Text = "ON";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
        }
    }
}
