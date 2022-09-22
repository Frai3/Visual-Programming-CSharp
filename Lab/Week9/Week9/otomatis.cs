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
    public partial class otomatis : Form
    {

        public otomatis()
        {
            InitializeComponent();
        }

        private void otomatis_Load(object sender, EventArgs e)
        {
            this.Text = "Lihat Data Otomatis";
            string connection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=G:\\New folder\\S7\\Visprog\\Lab\\Week9\\database.mdb";
            OleDbConnection conn = new OleDbConnection(connection);
            string query = "select * from barang";
            OleDbCommand command = new OleDbCommand(query, conn);
            var vtable = new DataTable("tblBarang");
            var adapter = new OleDbDataAdapter(command);

            adapter.Fill(vtable);
            dataGridView1.DataSource = vtable;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            otomatis.ActiveForm.Close();
        }
    }
}