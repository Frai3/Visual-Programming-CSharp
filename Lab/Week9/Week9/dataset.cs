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
    public partial class dataset : Form
    {
        public dataset()
        {
            InitializeComponent();
        }

        private void dataset_Load(object sender, EventArgs e)
        {
            this.Text = "Lihat Data - Dataset";
            string connection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=G:\\New folder\\S7\\Visprog\\Lab\\Week9\\database.mdb";
            OleDbConnection conn = new OleDbConnection(connection);
            string query = "select * from barang";
            OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet, "tblBarang");
            dataGridView1.DataSource = dataSet;
            dataGridView1.DataMember = "tblBarang";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataset.ActiveForm.Close();
        }
    }
}
