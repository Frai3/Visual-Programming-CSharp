using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LatihanArray2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] varray = { 1, 2, 3, 4, 5 };
            int vbatas = varray.GetUpperBound(0);
            for(int i = 0; i <= vbatas; i++)
            {
                MessageBox.Show(varray[i].ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] varray = { 3, 2, 1, 6, 7 };
            int vbatas = varray.GetUpperBound(0);
            Array.Sort(varray);
            Array.Reverse(varray);
            for (int i = 0; i <= vbatas; i++)
            {
                MessageBox.Show(varray[i].ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[] varray = { 3, 4, 1, 2, 3 };

            int vhasil;
            Array.Sort(varray);
            int vcari = 2;

            vhasil = Array.BinarySearch(varray, vcari);

            if(vhasil >= 0)
            {
                MessageBox.Show("found value in index: " + vhasil.ToString());
            }
            else
            {
                MessageBox.Show("not found value in index");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string[,] varray = new string[3, 4];
            varray[0, 0] = "a"; varray[0, 1] = "b"; varray[0, 2] = "c"; varray[0, 3] = "d";
            varray[1,0] = "e";
            varray[1,1] = "f";
            varray[1,2] = "g";
            varray[1,3] = "h";
            varray[2,0] = "i";
            varray[2,1] = "j";
            varray[2,2] = "k";
            varray[2,3] = "l";

            foreach (string i in varray)
            {
                MessageBox.Show(i.ToString());
            }

            int vbatas = varray.GetUpperBound(0);
            for(int i = 0; i <= vbatas; i++)
            {
                for(int j = 0; j <= 3; j++)
                {
                    MessageBox.Show(varray[i, j].ToString());
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int[][] arr = new int[2][];

            arr[0] = new int[5] { 1, 3, 5, 7, 9 };
            arr[1] = new int[4] { 2, 4, 6, 8 };

            for(int i = 0; i < arr.Length; i++)
            {
                MessageBox.Show("Element: " + i);

                for(int j = 0; j < arr[i].Length; j++)
                {
                    MessageBox.Show("Value: " + arr[i][j]);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int[] varray = { 1, 2, 3, 4, 5 };
            int[] varraycopy = varray;

            for(int i = 0; i < varray.Length; i++)
            {
                MessageBox.Show(varray[i].ToString());
            }

            Array.Resize(ref varraycopy, 7);

            for (int i = 0; i < varraycopy.Length; i++)
            {
                MessageBox.Show(varraycopy[i].ToString());
            }

            Array.Resize(ref varraycopy, 7);

        }
    }
}