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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext database = new DataClasses1DataContext();
            Pelanggan simpan = new Pelanggan { kode = txtKode.Text, nama = txtNama.Text, alamat = txtAlamat.Text, umur = Convert.ToInt32(txtUmur.Text) };

            database.Pelanggans.InsertOnSubmit(simpan);

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

        private void button3_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext database = new DataClasses1DataContext();
            var ubah = ( from p in database.Pelanggans where p.kode == txtKode.Text select p).Single();
            ubah.nama = txtNama.Text;
            ubah.umur = Convert.ToInt32(txtUmur.Text);
            ubah.alamat = txtAlamat.Text;

            try
            {
                database.SubmitChanges();
                MessageBox.Show("Data berhasil diperbarui!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext database = new DataClasses1DataContext();
            var hapus = (from p in database.Pelanggans where p.kode == txtKode.Text select p).Single();

            database.Pelanggans.DeleteOnSubmit(hapus);
            try
            {
                database.SubmitChanges();
                MessageBox.Show("Data berhasil dihapus!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            txtKode.Clear();
            txtNama.Clear();
            txtAlamat.Clear();
            txtUmur.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
            if(f2.param != null)
            {
                txtKode.Text = f2.param;
                txtNama.Text = f2.name;
                txtAlamat.Text = f2.address;
                txtUmur.Text = f2.age;
            }
        }
    }
}
