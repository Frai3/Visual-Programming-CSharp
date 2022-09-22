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

namespace No1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int keterangan = 0;
        
        private void btnPlus_Click(object sender, EventArgs e)
        {
            lblKet.Text = "Tambah";
            keterangan = 1;
        }

        private void btnSubs_Click(object sender, EventArgs e)
        {
            lblKet.Text = "Kurang";
            keterangan = 2;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            lblKet.Text = "Bagi";
            keterangan = 3;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLength.Clear();
            txtShow.Clear();
        }

        CountAdd tambah = new CountAdd();
        CountDivide bagi = new CountDivide();
        CountSubstract kurang = new CountSubstract();

        private void btnHasil_Click(object sender, EventArgs e)
        {
            int length = Convert.ToInt32(txtLength.Text);
            int[] arr = new int[length];
            double jumlah = 0.0;
            string total = "";
            
            for (int i = 0; i < length; i++)
            {
                int angka = i + 1;
                arr[i] = Convert.ToInt32(Interaction.InputBox("Masukkan nilai ke-" + angka));

                if (keterangan == 1)
                {
                    tambah.index = i;
                    tambah.penambahan = arr[i];
                    tambah.add();
                    total = tambah.balikNilai();

                    if (i == 0)
                    {
                        txtShow.Text = 0 + " + " + arr[i] + " = " + total + Environment.NewLine;
                    }
                    else
                    {
                        double total2 = Convert.ToInt32(total);
                        txtShow.Text += total2 - arr[i] + " + " + arr[i] + " = " + total + Environment.NewLine;
                    }
                }
                else if(keterangan == 2)
                {

                    kurang.index = i;
                    kurang.pengurangan = arr[i];
                    kurang.substract();
                    total = kurang.balikNilai();

                    if (i == 0)
                    {
                        txtShow.Text = 0 + " - " + arr[i] + " = " + total + Environment.NewLine;
                    }
                    else
                    {
                        double total2 = Convert.ToInt32(total);
                        txtShow.Text += total2 - arr[i] + " - " + arr[i] + " = " + total + Environment.NewLine;
                    }

                }
                else if(keterangan == 3)
                {
                    bagi.index = i;
                    bagi.pembagian = arr[i];
                    bagi.substract();
                    total = bagi.balikNilai();

                    if (i == 0)
                    {
                        txtShow.Text = 0 + " / " + arr[i] + " = " + total + Environment.NewLine;
                    }
                    else
                    {
                        double total2 = Convert.ToInt32(total);
                        txtShow.Text += total2 + " / " + arr[i] + " = " + total + Environment.NewLine;
                    }
                }
                
            }
            
        }
    }
}