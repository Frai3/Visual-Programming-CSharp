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

namespace ADO.NET
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            string ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=G:\\New folder\\S7\\Visprog\\Latihan\\ADO.NET\\DBJNM.accdb";
            OleDbConnection KoneksiDB = new OleDbConnection(ConnectionString);
            //Menampilkan Data Kedalam Datagrid
            OleDbCommand command = new OleDbCommand("Select * From TBL_BARANG", KoneksiDB);

            KoneksiDB.Open();

            OleDbDataReader reader = command.ExecuteReader();
            DataTable MyTable = new DataTable();

            MyTable.Load(reader);

            KoneksiDB.Close();
            dataGridView1.DataSource = MyTable;

        }
    }
}
