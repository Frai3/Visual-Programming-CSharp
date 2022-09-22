using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week14
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnTampil_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("ID");
            dt.Columns.Add("Nama");

            dt.Rows.Add(txtID.Text, txtNama.Text);
            dataGridView1.DataSource = dt;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext database = new DataClasses1DataContext();
            pelanggan simpan = new pelanggan { id_pelanggan = txtID.Text, nama_pelanggan = txtNama.Text };

            database.pelanggans.InsertOnSubmit(simpan);

            //Microsoft.ACE.OLEDB.12.0 tidak support di .NET Framework untuk input ke ms access
            //Jadi input ke sqlserver

            try
            {
                database.SubmitChanges();
                MessageBox.Show("Data berhasil disimpan!");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
