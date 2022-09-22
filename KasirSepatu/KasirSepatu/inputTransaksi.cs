using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.OleDb;
using System.Text;
using System.Threading.Tasks;

namespace KasirSepatu
{
    class inputTransaksi
    {
        public static int id { get; set; }
        public static string noInvoice { get; set; }
        public static DateTime tanggal { get; set; }
        public static string customer { get; set; }
        public static string warn { get; set; }

        OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=G:\\New folder\\S7\\Visprog\\KasirSepatu\\dbKasir.accdb");

        public void inputDatabase(string idSepatu, int quantity, double totalPrice)
        {
            id = HomeScreen.id;
            tanggal = HomeScreen.tanggal;
            customer = HomeScreen.customer;
            
            connection.Open();

            string query = "INSERT INTO transaksi (id, idSepatu, quan, price, tanggal, customer) VALUES (@id, @idSepatu, @quan, @price, @tanggal, @customer)";
            OleDbCommand command = new OleDbCommand(query, connection);

            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@idSepatu", idSepatu);
            command.Parameters.AddWithValue("@quan", quantity);
            command.Parameters.AddWithValue("@price", totalPrice);
            command.Parameters.AddWithValue("@tanggal", tanggal.ToString("dd MMMM yyyy"));
            command.Parameters.AddWithValue("@customer", customer);

            command.ExecuteNonQuery();

            warn = "Y";
            connection.Close();
        }
    }
}
