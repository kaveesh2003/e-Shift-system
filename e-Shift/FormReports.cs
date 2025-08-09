using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;

namespace e_Shift
{
    public partial class FormReports : Form
    {
        public FormReports()
        {
            InitializeComponent();
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            if (cmbReportType.SelectedItem?.ToString() != "Customer Report")
                return; // Handle other reports separately later

            string reportPath = Path.Combine(Application.StartupPath, "Reports", "CustomerReport.rpt");

            if (!File.Exists(reportPath))
            {
                MessageBox.Show("Report file not found: " + reportPath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create parameters
            ParameterFields parameters = new ParameterFields();

            ParameterField fromDateParam = new ParameterField();
            fromDateParam.Name = "@FromDate"; // match your Crystal parameter name
            ParameterDiscreteValue fromDateValue = new ParameterDiscreteValue();
            fromDateValue.Value = dtpFromDate.Value.Date;
            fromDateParam.CurrentValues.Add(fromDateValue);
            parameters.Add(fromDateParam);

            ParameterField toDateParam = new ParameterField();
            toDateParam.Name = "@ToDate"; // match your Crystal parameter name
            ParameterDiscreteValue toDateValue = new ParameterDiscreteValue();
            toDateValue.Value = dtpToDate.Value.Date;
            toDateParam.CurrentValues.Add(toDateValue);
            parameters.Add(toDateParam);

            // Open viewer
            ReportViewerForm viewer = new ReportViewerForm(reportPath, parameters);
            viewer.ShowDialog();
        }

        private void LoadReportTypes()
        {
            // Clear existing items if any
            cmbReportType.Items.Clear();

            // Add report types
            cmbReportType.Items.Add("Customer Report");
            cmbReportType.Items.Add("Job Report");
            cmbReportType.Items.Add("Load Report");
            cmbReportType.Items.Add("Transport Units Report");
            cmbReportType.Items.Add("Revenue/Cost Report");
            cmbReportType.Items.Add("Job Status Summary");

            // Optionally select the first item by default
            if (cmbReportType.Items.Count > 0)
            {
                cmbReportType.SelectedIndex = 0;
            }
        }

        private void FormReports_Load(object sender, EventArgs e)
        {
            LoadReportTypes();
            LoadJobStatus();
        }

        private void LoadJobStatus()
        {
            cmbJobStatus.Items.Clear();

            cmbJobStatus.Items.Add("All");
            cmbJobStatus.Items.Add("Declined");
            cmbJobStatus.Items.Add("Accepted");
            cmbJobStatus.Items.Add("In Progress");
            cmbJobStatus.Items.Add("In Transit");
            cmbJobStatus.Items.Add("Completed");
        }
    }
}
