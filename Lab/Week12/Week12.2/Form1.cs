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

namespace Week12._2
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
            laporan.Load("G:\\New folder\\S7\\Visprog\\Lab\\Week12\\Week12.2\\CrystalReport1.rpt");
            crystalReportViewer1.ReportSource = laporan;
            crystalReportViewer1.Refresh();
        }
    }
}
