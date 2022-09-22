using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week8_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "MDI";
        }

        private void formControlStructureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAnak2 f2 = new FormAnak2();
            f2.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
        }

        private void titleHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
