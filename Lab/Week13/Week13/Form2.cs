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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        DateTime awal = Form1.awal;
        DateTime akhir = Form1.akhir;
        string gender = Form1.gender;

        private void Form2_Load(object sender, EventArgs e)
        {
            CrystalReport1 cristalReport = new CrystalReport1();
            cristalReport.SetParameterValue("jenis_kelamin", gender);
            cristalReport.SetParameterValue("tglAwal", awal);
            cristalReport.SetParameterValue("tglAkhir", akhir);
            crystalReportViewer1.ReportSource = cristalReport;
        }
    }
}
