using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KasirSepatu
{
    public partial class Print : Form
    {
        public Print()
        {
            InitializeComponent();
        }

        OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=G:\\New folder\\S7\\Visprog\\KasirSepatu\\dbKasir.accdb");
        public static string customer { get; set; }
        public static string merk { get; set; }
        public static string nama { get; set; }
        public static double harga { get; set; }
        public static double price { get; set; }
        public static int quan { get; set; }
        public static DateTime tanggal { get; set; }
        private void Print_Load(object sender, EventArgs e)
        {
            customer = HomeScreen.customer;
            tanggal = HomeScreen.tanggal;

            connection.Open();

            string query = "select s.merk, s.nama, s.harga, t.quan, t.price from masterData s, transaksi t where t.idSepatu = s.idSepatu and customer = @customer and tanggal = @tanggal";
            /*string query = "select sum(tr.totalHarga) as Jumlah from transaksi tr where customer = @customer";*/
            OleDbCommand command = new OleDbCommand(query, connection);
            var table = new DataTable("tblTransaksi");
            var adapter = new OleDbDataAdapter(command);

            //Row cells sama column buat milih data

            command.Parameters.AddWithValue("@customer", customer);
            command.Parameters.AddWithValue("@tanggal", tanggal.ToString("dd/MM/yyyy"));

            adapter.Fill(table);
            dataGridView1.DataSource = table;

            connection.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow rows = this.dataGridView1.Rows[e.RowIndex];
                merk = rows.Cells["merk"].Value.ToString();
                nama = rows.Cells["nama"].Value.ToString();
                harga = Convert.ToInt32(rows.Cells["harga"].Value);
                quan = Convert.ToInt32(rows.Cells["quan"].Value);
                price = Convert.ToDouble(rows.Cells["price"].Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Pen blackPen = new Pen(Color.Black, 2);
            Image watermark = Image.FromFile("G:\\New folder\\S7\\Visprog\\KasirSepatu\\gambar\\Logo.png");

            //Header
            e.Graphics.DrawImage(watermark, new Point(250, 350));
            e.Graphics.DrawString("INVOICE", new Font("Arial", 30, FontStyle.Bold), Brushes.Black, new Point(350, 25));
            e.Graphics.DrawString("Toko Sepatu XXXXXX", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(300, 75));
            e.Graphics.DrawLine(blackPen, new PointF(50.0F, 110.0F), new PointF(800.0F, 110.0F));

            //Identitas
            e.Graphics.DrawString("Customer : " + customer, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(50, 125));
            e.Graphics.DrawString("Tanggal    : " + tanggal, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(50, 150));

            //Tabel
            e.Graphics.DrawLine(new Pen(Color.Black, 1), new PointF(100.0F, 200.0F), new PointF(750.0F, 200.0F));
            e.Graphics.DrawLine(new Pen(Color.Black, 1), new PointF(100.0F, 230.0F), new PointF(750.0F, 230.0F));
            e.Graphics.DrawLine(new Pen(Color.Black, 1), new PointF(100.0F, 800.0F), new PointF(750.0F, 800.0F));
            e.Graphics.DrawLine(new Pen(Color.Black, 1), new PointF(100.0F, 200.0F), new PointF(100.0F, 800.0F));
            e.Graphics.DrawLine(new Pen(Color.Black, 1), new PointF(200.0F, 200.0F), new PointF(200.0F, 800.0F));
            e.Graphics.DrawLine(new Pen(Color.Black, 1), new PointF(350.0F, 200.0F), new PointF(350.0F, 800.0F));
            e.Graphics.DrawLine(new Pen(Color.Black, 1), new PointF(525.0F, 200.0F), new PointF(525.0F, 800.0F));
            e.Graphics.DrawLine(new Pen(Color.Black, 1), new PointF(575.0F, 200.0F), new PointF(575.0F, 800.0F));
            e.Graphics.DrawLine(new Pen(Color.Black, 1), new PointF(750.0F, 200.0F), new PointF(750.0F, 800.0F));
            e.Graphics.DrawLine(new Pen(Color.Black, 1), new PointF(800.0F, 200.0F), new PointF(800.0F, 200.0F));

            //Header Tabel
            e.Graphics.DrawString("Merk", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(125, 205));
            e.Graphics.DrawString("Jenis", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(240, 205));
            e.Graphics.DrawString("Harga", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(405, 205));
            e.Graphics.DrawString("Qty", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(530, 205));
            e.Graphics.DrawString("Total", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(625, 205));

            //Footer
            e.Graphics.DrawString(merk, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(105, 240));
            e.Graphics.DrawString(nama, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(205, 240));
            e.Graphics.DrawString("Rp. " + harga, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(355, 240));
            e.Graphics.DrawString(quan.ToString(), new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(530, 240));
            e.Graphics.DrawString("Rp. " + price, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(580, 240));

            //Petugas
            e.Graphics.DrawString("Petugas", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(600, 850));
            e.Graphics.DrawString("(............................)", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(550, 950));
        }

        private void btnCetak_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument1;

            DialogResult res = printDialog.ShowDialog();

            if (res == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }
    }
}