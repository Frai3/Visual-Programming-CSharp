using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LatihanArray1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] warna = { "merah", "biru", "hijau", "ungu", "kuning", "putih" };

            string[] warna2 = new string[6];
            warna2[0] = "merah";
            warna2[1] = "biru";
            warna2[2] = "hijau";
            warna2[3] = "ungu";
            warna2[4] = "kuning";
            warna2[5] = "putih";
        }


        
        
        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
