using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week13
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        DateTime awal = Form1.awal;
        DateTime akhir = Form1.akhir;
        string gender = Form1.gender;

        private void Form3_Load(object sender, EventArgs e)
        {

            string formula = "{Table.ulang_tahun} >=#" + awal + "#" + "and {Table.ulang_tahun} <=#" + akhir + "#" + "and {Table.jenis_kelamin} ='" + gender + "'";

            CrystalReport2 cr2 = new CrystalReport2();
            crystalReportViewer1.SelectionFormula = formula;
            crystalReportViewer1.ReportSource = cr2;

        }
    }
}
