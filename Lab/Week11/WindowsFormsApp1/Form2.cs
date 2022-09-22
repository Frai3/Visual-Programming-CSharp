using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string param = null;
        public string name;
        public string address;
        public string age;

        private void Form2_Load(object sender, EventArgs e)
        {
            DataClasses1DataContext database = new DataClasses1DataContext();
            var search = (from p in database.Pelanggans select p);
            dataGridView1.DataSource = search;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            param = dataGridView1.CurrentRow.Cells["kode"].Value.ToString();
            name = dataGridView1.CurrentRow.Cells["nama"].Value.ToString();
            address = dataGridView1.CurrentRow.Cells["alamat"].Value.ToString();
            age = dataGridView1.CurrentRow.Cells["umur"].Value.ToString();

            Form2.ActiveForm.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataClasses1DataContext database = new DataClasses1DataContext();
            var search = (from p in database.Pelanggans where p.kode.Contains(textBox1.Text) select p);
            dataGridView1.DataSource = search;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2.ActiveForm.Close();
        }
    }
}
