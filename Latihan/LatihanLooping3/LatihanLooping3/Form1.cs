using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LatihanLooping3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            double celcius, fahrenheit;

            listBox1.Items.Add("Celcius \t Fahrenheit");

            for (celcius = 10; celcius <= 100; celcius+=10)
            {
                fahrenheit = Fahrenheit(celcius);
                listBox1.Items.Add(celcius + "\t" + fahrenheit);
                // listBox1.Text += Convert.ToString("Celcius: " + celcius) + "\r\n";
            }

        }
        
        private double Fahrenheit(double celcius)
        {
            return (celcius * 9 / 5) + 32;
        }
    }
}
