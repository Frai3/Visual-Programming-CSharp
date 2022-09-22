using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KasirSepatu
{
    public partial class Supernova : Form
    {
        public Supernova()
        {
            InitializeComponent();
        }

        public static string idSepatu { get; set; }
        public static double price { get; set; }
        public static int quantity { get; set; }
        public static double totalPrice { get; set; }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            idSepatu = "SP001";
            quantity = Convert.ToInt32(txtQuan.Text);
            price = 250000;
            totalPrice = quantity * price;

            inputTransaksi transaksi = new inputTransaksi();
            transaksi.inputDatabase(idSepatu, quantity, totalPrice);

            if(inputTransaksi.warn == "Y")
            {
                MessageBox.Show("Data Berhasil Ditambahkan!");
            }
            else
            {
                MessageBox.Show("Data Gagal Ditambahkan!");
            }

            Supernova.ActiveForm.Close();
        }
    }
}
