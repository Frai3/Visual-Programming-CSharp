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
    public partial class datareader : Form
    {
        public datareader()
        {
            InitializeComponent();
        }

        private void datareader_Load(object sender, EventArgs e)
        {
            this.Text = "Lihat Data - Datareader";
            string connection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=G:\\New folder\\S7\\Visprog\\Lab\\Week9\\database.mdb";
            OleDbConnection conn = new OleDbConnection(connection);
            string query = "select * from mahasiswa";
            OleDbCommand command = new OleDbCommand(query, conn);
            var vtable = new DataTable("tblBarang");

            conn.Open();
            OleDbDataReader dataReader = command.ExecuteReader();
            vtable.Load(dataReader);

            dataGridView1.DataSource = vtable;

            conn.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            datareader.ActiveForm.Close();
        }
    }
}
