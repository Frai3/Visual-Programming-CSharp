using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _00000033360_FarhanRaihan_AL
{
    public partial class No2 : Form
    {
        public No2()
        {
            InitializeComponent();
        }

        public string id;
        public string matkul { get; set; }
        DataClasses1DataContext dataMahasiswa = new DataClasses1DataContext();

        private void Form1_Load(object sender, EventArgs e)
        {
            var listCombo = (from tbl in dataMahasiswa.Matakuliahs select tbl).ToList();
            comboBox3.ValueMember = "kode_matkul";
            comboBox3.DataSource = listCombo;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem=="FTI")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Sistem Informasi");
                comboBox2.Items.Add("Informatika");
                comboBox2.Items.Add("Teknik Komputer");
                comboBox2.Items.Add("Teknik Elektro");
                comboBox2.Items.Add("Teknik Fisika");
            }
            else if (comboBox1.SelectedItem == "Seni & Desain")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("DKV");
                comboBox2.Items.Add("Arsitek");
                comboBox2.Items.Add("Film & Animasi");
            }
            else if (comboBox1.SelectedItem == "Business")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Akutansi");
                comboBox2.Items.Add("Manajemen");
            }
            else if (comboBox1.SelectedItem == "Ilmu Komunikasi")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Ilmu Komunikasi");
                comboBox2.Items.Add("Jurnalistik");
            }
            else
            {
                MessageBox.Show("Pilih Fakultas Terlebih Dulu");
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

            Mahasiswa mhs = new Mahasiswa { nim = txtNIM.Text, nama = txtNama.Text, angkatan = Convert.ToInt32(txtAngkatan.Text), fakultas = comboBox1.Text, prodi = comboBox2.Text };

            dataMahasiswa.Mahasiswas.InsertOnSubmit(mhs);

            try
            {
                dataMahasiswa.SubmitChanges();
                MessageBox.Show("Data berhasil ditambahkan!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNIM.Clear();
            txtNama.Clear();
            txtAngkatan.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
        }

        private void btnEnroll_Click(object sender, EventArgs e)
        {
            var listCombo = (from tbl in dataMahasiswa.Enrollments select tbl).ToList();

            int id = listCombo.Count + 1;

            Enrollment enroll = new Enrollment { id_enrollment = id.ToString(), nim = txtNIMEnroll.Text, kode_matkul = comboBox3.Text };

            dataMahasiswa.Enrollments.InsertOnSubmit(enroll);

            try
            {
                dataMahasiswa.SubmitChanges();
                MessageBox.Show("Data berhasil ditambahkan!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            var listGrid = (from tbl in dataMahasiswa.Enrollments where tbl.nim == textBox1.Text select tbl).ToList();
            dataGridView1.DataSource = listGrid;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void generateCrystalReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }
    }
}
