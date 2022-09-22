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

namespace Week14
{
    public partial class CR : Form
    {
        public CR()
        {
            InitializeComponent();
        }

        private void CR_Load(object sender, EventArgs e)
        {
            ReportDocument laporan = new ReportDocument();
            laporan.Load("G:\\New folder\\S7\\Visprog\\Lab\\Week14\\Week14\\CrystalReport1.rpt");
            crystalReportViewer1.ReportSource = laporan;
            crystalReportViewer1.Refresh();
        }
    }
}
