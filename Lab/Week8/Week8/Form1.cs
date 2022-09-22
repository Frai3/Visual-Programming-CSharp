using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblResult.Text = "";
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                lblResult.Text = textBox1.Text;
                lblResult.Font = new Font("Times New Roman", 30, FontStyle.Regular);
            }
        }

        private void enableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
        }

        private void disableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void labelResultClearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
        }

        private void boldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblResult.Font = new Font("Times New Roman", 30, FontStyle.Bold);
        }

        private void italicsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblResult.Font = new Font("Times New Roman", 30, FontStyle.Italic);
        }

        private void underlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblResult.Font = new Font("Times New Roman", 30, FontStyle.Underline);
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblResult.ForeColor = Color.Blue;
        }

        private void yellowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblResult.ForeColor = Color.Yellow;
        }
    }
}
