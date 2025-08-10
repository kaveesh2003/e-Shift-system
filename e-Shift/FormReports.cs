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
            string selected = cmbReportType.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selected))
            {
                MessageBox.Show("Select a report", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            // Create parameters list
            ParameterFields parameters = new ParameterFields();
            string reportPath = "";

            if (selected == "Customer Report")
            {
                reportPath = Path.Combine(Application.StartupPath, "Reports", "CustomerReport.rpt");

                ParameterField fromDateParam = new ParameterField();
                fromDateParam.Name = "@FromDate";
                fromDateParam.CurrentValues.Add(new ParameterDiscreteValue { Value = dtpFromDate.Value.Date });
                parameters.Add(fromDateParam);

                ParameterField toDateParam = new ParameterField();
                toDateParam.Name = "@ToDate";
                toDateParam.CurrentValues.Add(new ParameterDiscreteValue { Value = dtpToDate.Value.Date });
                parameters.Add(toDateParam);
            }

            else if (selected == "Job Report")
            {
                reportPath = Path.Combine(Application.StartupPath, "Reports", "JobReport.rpt");

                ParameterField pfFrom = new ParameterField();
                pfFrom.Name = "FromDate";
                pfFrom.CurrentValues.Add(new ParameterDiscreteValue { Value = dtpFromDate.Value.Date });
                parameters.Add(pfFrom);

                ParameterField pfTo = new ParameterField();
                pfTo.Name = "ToDate";
                pfTo.CurrentValues.Add(new ParameterDiscreteValue { Value = dtpToDate.Value.Date });
                parameters.Add(pfTo);

                ParameterField pfStatus = new ParameterField();
                pfStatus.Name = "JobStatus";
                pfStatus.CurrentValues.Add(new ParameterDiscreteValue
                {
                    Value = cmbJobStatus.SelectedItem?.ToString() ?? "All"
                });
                parameters.Add(pfStatus);
            }
            else if (selected == "Load Report")
            {
                reportPath = Path.Combine(Application.StartupPath, "Reports", "LoadReport.rpt");

                ParameterField pfFrom = new ParameterField();
                pfFrom.Name = "FromDate";
                pfFrom.CurrentValues.Add(new ParameterDiscreteValue { Value = dtpFromDate.Value.Date });
                parameters.Add(pfFrom);

                ParameterField pfTo = new ParameterField();
                pfTo.Name = "ToDate";
                pfTo.CurrentValues.Add(new ParameterDiscreteValue { Value = dtpToDate.Value.Date });
                parameters.Add(pfTo);

                ParameterField pfStatus = new ParameterField();
                pfStatus.Name = "LoadStatus";
                pfStatus.CurrentValues.Add(new ParameterDiscreteValue
                {
                    Value = cmbLoadStatus.SelectedItem?.ToString() ?? "All"
                });
                parameters.Add(pfStatus);
            }
            else if (selected == "Transport Units Report")
            {
                reportPath = Path.Combine(Application.StartupPath, "Reports", "TransportUnitDetailsReport.rpt");

                // Create the AvailabilityStatus parameter
                ParameterField availabilityParam = new ParameterField();
                availabilityParam.Name = "AvailabilityStatus"; 

                ParameterDiscreteValue availabilityValue = new ParameterDiscreteValue();

                string availabilityStatus = cmbAvailabilityStatus.SelectedItem?.ToString() ?? "All";

                availabilityValue.Value = availabilityStatus;
                availabilityParam.CurrentValues.Add(availabilityValue);

                parameters.Add(availabilityParam);
            }
            else
            {
                MessageBox.Show("Selected report is not implemented yet.", "Feature Pending", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

            // Check if file exists
            if (!File.Exists(reportPath))
            {
                MessageBox.Show("Report file not found: " + reportPath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Show in viewer
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

            if (cmbReportType.Items.Count > 0)
            {
                cmbReportType.SelectedIndex = 0;
            }
        }

        private void FormReports_Load(object sender, EventArgs e)
        {
            LoadReportTypes();
            LoadJobStatus();
            LoadLoadStatus();
            LoadAvailabilityStatus();
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

        private void LoadLoadStatus()
        {
            cmbLoadStatus.Items.Clear();

            cmbLoadStatus.Items.Add("All");
            cmbLoadStatus.Items.Add("Pending");
            cmbLoadStatus.Items.Add("In Transit");
            cmbLoadStatus.Items.Add("Delivered");
        }

        private void LoadAvailabilityStatus()
        {
            cmbAvailabilityStatus.Items.Clear();

            cmbAvailabilityStatus.Items.Add("All");
            cmbAvailabilityStatus.Items.Add("Available");
            cmbAvailabilityStatus.Items.Add("On Job");
            cmbAvailabilityStatus.Items.Add("Pending");
            cmbAvailabilityStatus.Items.Add("In Transit");
            cmbAvailabilityStatus.Items.Add("Completed");
        }
    }
}
