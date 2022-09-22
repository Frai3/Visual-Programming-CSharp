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

namespace No2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            int length = Convert.ToInt32(txtLength.Text);
            int[] arr = new int[length];
            string tampil = "";
            int sum = 0;
            int max;
            decimal avg;

            for(int i=0; i<length; i++)
            {
                int angka = i + 1;
                arr[i] = Convert.ToInt32(Interaction.InputBox("Masukkan nilai index ke-" + angka));
                sum += arr[i];
                tampil += i + "".PadRight(13) + arr[i] + "".PadRight(13) + Environment.NewLine;
            }

            avg = sum / length;
            max = arr.Max();

            txtShow.Text = "Index".PadRight(10) + "Value".PadRight(10) + Environment.NewLine + tampil;
            txtSum.Text = sum.ToString();
            txtAvg.Text = avg.ToString();
            txtMax.Text = max.ToString();


        }
    }
}
