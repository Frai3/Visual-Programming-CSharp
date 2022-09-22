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

namespace Week10
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        Form1 f1 = new Form1();

        private void btnOK_Click(object sender, EventArgs e)
        {
            f1.kode = "key";
            f1.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Form2.ActiveForm.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string connection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=G:\\New folder\\S7\\Visprog\\Lab\\Week10\\database.accdb";
            OleDbConnection conn = new OleDbConnection(connection);
            string query = "select * from MstDosen";
            OleDbCommand command = new OleDbCommand(query, conn);
            var vtable = new DataTable("MstDosen");
            var adapter = new OleDbDataAdapter(command);
            try
            {
                adapter.Fill(vtable);
                gridTampil.DataSource = vtable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void gridTampil_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                DataGridViewRow rows = this.gridTampil.Rows[e.RowIndex];
                f1.kodeDosen = rows.Cells["KdDosen"].Value.ToString();
                f1.namaDosen = rows.Cells["NaDosen"].Value.ToString();
                f1.alamat = rows.Cells["Alamat"].Value.ToString();
                f1.noTelp = rows.Cells["NoTelp"].Value.ToString();
                f1.noHP = rows.Cells["NoHP"].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
