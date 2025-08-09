using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace e_Shift
{
    public partial class ReportViewerForm : Form
    {
        public ReportViewerForm(string reportPath, ParameterFields parameters)
        {
            InitializeComponent();

            ReportDocument reportDoc = new ReportDocument();
            reportDoc.Load(reportPath);

            crystalReportViewer1.ReportSource = reportDoc;
            crystalReportViewer1.ParameterFieldInfo = parameters;

            crystalReportViewer1.Refresh();

            // Set parameter fields BEFORE setting ReportSource
            crystalReportViewer1.ParameterFieldInfo = parameters;


            // Optional: if report needs DB login at runtime, set connection info here (see note)
            crystalReportViewer1.ReportSource = reportDoc;
            crystalReportViewer1.Refresh();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
