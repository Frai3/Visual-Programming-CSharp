using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDatabase_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext database = new DataClasses1DataContext();
            var data = (from p in database.pelanggans select p);
            dataGridView1.DataSource = data;
        }

        private void btnCR_Click(object sender, EventArgs e)
        {
            CR cr = new CR();
            cr.Show();
        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void btnTxt_Click(object sender, EventArgs e)
        {
            TextWriter write = new StreamWriter("G:\\New folder\\S7\\Visprog\\Lab\\Week14\\dataPelanggan.txt");

            int row = dataGridView1.Rows.Count;
            int column = dataGridView1.Columns.Count;
            for (int i = 0; i < row - 1; i++)
            {
                write.Write(dataGridView1.Rows[i].Cells[0].Value.ToString() + "\t"
                + dataGridView1.Rows[i].Cells[1].Value.ToString() + "\n");
            }
            write.Close();
            MessageBox.Show("Data Exported!");
        }
    }
}
