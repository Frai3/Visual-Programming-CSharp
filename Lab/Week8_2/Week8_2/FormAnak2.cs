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
    public partial class FormAnak2 : Form
    {
        public FormAnak2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void txtNama_KeyDown(object sender, KeyEventArgs e)
        {
            string input = txtNama.Text;
            if(e.KeyCode == Keys.Enter)
            {
                comboBox1.Items.Add(input);
                txtNama.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double data = 0;
            double hasil = 0;

            for(int i = 0; i < comboBox1.Items.Count; i++)
            {
                data = data + Convert.ToDouble(comboBox1.Items[i]);
            }

            hasil = data / comboBox1.Items.Count;
            txtHasil.Text = hasil.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (var i in comboBox1.Items)
            {
                checkedListBox1.Items.Add(i.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double data = 0;
            double hasil = 0;

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                data = data + Convert.ToDouble(listBox1.Items[i]);
            }

            hasil = data / listBox1.Items.Count;
            txtHasil.Text = hasil.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var i in comboBox1.Items)
            {
                listBox1.Items.Add(i.ToString());
            }
        }
    }
}
