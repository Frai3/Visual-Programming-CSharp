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
    public partial class Form1 : Form
    {

        public string kodeDosen { get; set; }
        public string namaDosen { get; set; }
        public string alamat { get; set; }
        public string noTelp { get; set; }
        public string noHP { get; set; }
        public string kode { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=G:\\New folder\\S7\\Visprog\\Lab\\Week10\\database.accdb");

        private void textBox1_Leave(object sender, EventArgs e)
        {
            connection.Open();

            string query = "select * from MstDosen where KdDosen = @KdDosen";
            OleDbCommand command = new OleDbCommand(query, connection);

            command.Parameters.AddWithValue("@KdDosen", txtKodeDosen.Text);

            OleDbDataReader dataReader = command.ExecuteReader();
            if (kode != "key")
            {
                try
                {
                    while (dataReader.Read())
                    {
                        txtNamaDosen.Text = dataReader.GetValue(1).ToString();
                        txtAlamat.Text = dataReader.GetValue(2).ToString();
                        txtTelp.Text = dataReader.GetValue(3).ToString();
                        txtHP.Text = dataReader.GetValue(4).ToString();
                        MessageBox.Show("Data Ditemukan!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Data Tidak Ditemukan. Anda Dapat Memasukkan Data");
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }

            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string query = "insert into MstDosen(KdDosen, NaDosen, Alamat, Notelp, NoHP) values (@KdDosen, @NaDosen, @Alamat, @Notelp, @NoHP)";
            OleDbCommand command = new OleDbCommand(query, connection);

            command.Parameters.AddWithValue("@KdDosen", txtKodeDosen.Text);
            command.Parameters.AddWithValue("@NaDosen", txtNamaDosen.Text);
            command.Parameters.AddWithValue("@Alamat", txtAlamat.Text);
            command.Parameters.AddWithValue("@Notelp", txtTelp.Text);
            command.Parameters.AddWithValue("@NoHP", txtHP.Text);


            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Data Berhasil Diinput!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tidak Dapat Membuka Koneksi!");
                MessageBox.Show(ex.Message);
            }

            finally
            {
                connection.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string query = "delete from MstDosen where KdDosen = @KdDosen";
            OleDbCommand command = new OleDbCommand(query, connection);

            command.Parameters.AddWithValue("@KdDosen", txtKodeDosen.Text);


            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Data Berhasil Dihapus!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tidak Dapat Membuka Koneksi!");
                MessageBox.Show(ex.Message);
            }

            finally
            {
                connection.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string query = "update MstDosen set NaDosen = '" + txtNamaDosen.Text + "', Alamat = '" + txtAlamat.Text + "', Notelp = '" + txtTelp.Text + "', NoHP = '" + txtHP.Text + "' where KdDosen = '" + txtKodeDosen.Text + "'";
            OleDbCommand command = new OleDbCommand(query, connection);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Data Berhasil Diperbarui!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tidak Dapat Membuka Koneksi!");
                MessageBox.Show(ex.Message);
            }

            finally
            {
                connection.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(kode == "key")
            {
                txtKodeDosen.Text = kodeDosen;
                txtNamaDosen.Text = namaDosen;
                txtAlamat.Text = alamat;
                txtTelp.Text = noTelp;
                txtHP.Text = noHP;
            }
        }
    }
}
