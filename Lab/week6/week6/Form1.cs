using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProses_Click(object sender, EventArgs e)
        {
            int input = Convert.ToInt32(txtInput.Text);
            int[] array = new int[input];
            string tampil1 = "", tampil2 = "";
            int jumlah = 0;
            double average;

            for (int i = 0; i < input; i++)
            {
                int elemen = i + 1;
                array[i] = Convert.ToInt32(Interaction.InputBox("Masukkan nilai index ke-" + elemen));

                tampil1 += i + "".PadRight(13) + array[i] + "".PadRight(13) + new String('*', array[i]) + Environment.NewLine;
                tampil2 += i + "".PadRight(13) + array[i] + "" + Environment.NewLine;
                jumlah += array[i];

            }

            txtHasil.Text = "Index".PadRight(10) + "Value".PadRight(10) + "Histogram" + Environment.NewLine + tampil1;
            txtSUM.Text = jumlah.ToString();
            txtArray.Text = "Index".PadRight(10) + "Value" + Environment.NewLine + tampil2;

            average = jumlah / input;
            txtAVG.Text = average.ToString();
        }
    }
}
