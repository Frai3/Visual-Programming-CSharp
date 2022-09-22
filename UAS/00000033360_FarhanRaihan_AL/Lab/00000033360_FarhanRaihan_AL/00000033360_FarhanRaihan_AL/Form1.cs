using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _00000033360_FarhanRaihan_AL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ReportDocument laporan = new ReportDocument();
            laporan.Load("G:\\New folder\\S7\\Visprog\\UAS\\Lab\\00000033360_FarhanRaihan_AL\\00000033360_FarhanRaihan_AL\\CrystalReport2.rpt");
            crystalReportViewer1.ReportSource = laporan;
            crystalReportViewer1.Refresh();
        }
    }
}
