using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inisial = comboBox1.Text;
            otomatis showOtomatis = new otomatis();
            dataset showDataset = new dataset();
            datareader showDatareader = new datareader();
            Form1 f1 = new Form1();

            if (inisial == "Lihat Data")
            {
                showOtomatis.Show();
            }
            else if(inisial == "Lihat Data - Dengan Dataset")
            {
                showDataset.Show();
            }
            else
            {
                showDatareader.Show();
            }
        }
    }
}
