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

namespace KasirSepatu
{
    public partial class HomeScreen : Form
    {
        public HomeScreen()
        {
            InitializeComponent();
        }

        OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=G:\\New folder\\S7\\Visprog\\KasirSepatu\\dbKasir.accdb");

        public static int id { get; set; }
        public static DateTime tanggal { get; set; }
        public static string customer { get; set; }
        public static string warn { get; set; }
        private void button1_Click(object sender, EventArgs e)
        {
            Supernova supernova = new Supernova();
            if (customer == " ")
            {
                MessageBox.Show("Harap Masukkan Nama Customer");
            }
            else
            {
                supernova.Show();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Print cetak = new Print();
            if (customer == " ")
            {
                MessageBox.Show("Harap Masukkan Nama Customer");
            }
            else
            {
                cetak.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AirMax airmax = new AirMax();
            if (customer == " ")
            {
                MessageBox.Show("Harap Masukkan Nama Customer");
            }
            else
            {
                airmax.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hyperfuse hyperfuse = new Hyperfuse();
            if (customer == " ")
            {
                MessageBox.Show("Harap Masukkan Nama Customer");
            }
            else
            {
                hyperfuse.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Vektor vektor = new Vektor();
            if (customer == " ")
            {
                MessageBox.Show("Harap Masukkan Nama Customer");
            }
            else
            {
                vektor.Show();
            }
        }

        public void getId()
        {
            connection.Open();

            string query = "SELECT id FROM transaksi ";
            OleDbCommand command = new OleDbCommand(query, connection);
            OleDbDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                id = Convert.ToInt32(dataReader.GetValue(0));
            }

            if (id.ToString() == "0")
            {
                id = 1;
            }
            else
            {
                for (int i = id + 1; i > id; i--)
                {
                    id = i;
                }
            }
            connection.Close();
        }

        private void HomeScreen_Load(object sender, EventArgs e)
        {
            if (warn != "Y")
            {
                getId();
                tanggal = DateTime.Now;
                customer = " ";
            }
            else
            {
                getId();
            }

        }

        private void txtCustomer_TextChanged(object sender, EventArgs e)
        {
            customer = txtCustomer.Text;
        }
    }
}
