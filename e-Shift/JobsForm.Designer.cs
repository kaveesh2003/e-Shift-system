namespace e_Shift
{
    partial class JobsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdminSettings = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnTransportUnit = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnLoads = new System.Windows.Forms.Button();
            this.btnJobs = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvRequestedJobs = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnAcceptJob = new System.Windows.Forms.Button();
            this.btnDecline = new System.Windows.Forms.Button();
            this.btnAssignTU = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequestedJobs)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAdminSettings);
            this.panel1.Controls.Add(this.btnReports);
            this.panel1.Controls.Add(this.btnTransportUnit);
            this.panel1.Controls.Add(this.btnProducts);
            this.panel1.Controls.Add(this.btnLoads);
            this.panel1.Controls.Add(this.btnJobs);
            this.panel1.Controls.Add(this.btnCustomers);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 647);
            this.panel1.TabIndex = 2;
            // 
            // btnAdminSettings
            // 
            this.btnAdminSettings.Location = new System.Drawing.Point(19, 574);
            this.btnAdminSettings.Name = "btnAdminSettings";
            this.btnAdminSettings.Size = new System.Drawing.Size(170, 41);
            this.btnAdminSettings.TabIndex = 7;
            this.btnAdminSettings.Text = "Admin Settings";
            this.btnAdminSettings.UseVisualStyleBackColor = true;
            // 
            // btnReports
            // 
            this.btnReports.Location = new System.Drawing.Point(19, 511);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(170, 41);
            this.btnReports.TabIndex = 6;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = true;
            // 
            // btnTransportUnit
            // 
            this.btnTransportUnit.Location = new System.Drawing.Point(19, 450);
            this.btnTransportUnit.Name = "btnTransportUnit";
            this.btnTransportUnit.Size = new System.Drawing.Size(170, 41);
            this.btnTransportUnit.TabIndex = 5;
            this.btnTransportUnit.Text = "Transport Unit";
            this.btnTransportUnit.UseVisualStyleBackColor = true;
            // 
            // btnProducts
            // 
            this.btnProducts.Location = new System.Drawing.Point(19, 383);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(170, 41);
            this.btnProducts.TabIndex = 4;
            this.btnProducts.Text = "Products";
            this.btnProducts.UseVisualStyleBackColor = true;
            // 
            // btnLoads
            // 
            this.btnLoads.Location = new System.Drawing.Point(19, 318);
            this.btnLoads.Name = "btnLoads";
            this.btnLoads.Size = new System.Drawing.Size(170, 41);
            this.btnLoads.TabIndex = 3;
            this.btnLoads.Text = "Loads";
            this.btnLoads.UseVisualStyleBackColor = true;
            // 
            // btnJobs
            // 
            this.btnJobs.Location = new System.Drawing.Point(19, 251);
            this.btnJobs.Name = "btnJobs";
            this.btnJobs.Size = new System.Drawing.Size(170, 41);
            this.btnJobs.TabIndex = 2;
            this.btnJobs.Text = "Jobs";
            this.btnJobs.UseVisualStyleBackColor = true;
            // 
            // btnCustomers
            // 
            this.btnCustomers.Location = new System.Drawing.Point(19, 186);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(170, 41);
            this.btnCustomers.TabIndex = 1;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.UseVisualStyleBackColor = true;
            // 
            // btnDashboard
            // 
            this.btnDashboard.Location = new System.Drawing.Point(19, 123);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(170, 41);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(242, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Handle Transport Requests";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Requested Jobs";
            // 
            // dgvRequestedJobs
            // 
            this.dgvRequestedJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequestedJobs.Location = new System.Drawing.Point(245, 141);
            this.dgvRequestedJobs.Name = "dgvRequestedJobs";
            this.dgvRequestedJobs.RowHeadersWidth = 51;
            this.dgvRequestedJobs.RowTemplate.Height = 24;
            this.dgvRequestedJobs.Size = new System.Drawing.Size(789, 404);
            this.dgvRequestedJobs.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(956, 100);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 40;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(754, 100);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(196, 22);
            this.txtSearch.TabIndex = 39;
            // 
            // btnAcceptJob
            // 
            this.btnAcceptJob.Location = new System.Drawing.Point(245, 578);
            this.btnAcceptJob.Name = "btnAcceptJob";
            this.btnAcceptJob.Size = new System.Drawing.Size(104, 33);
            this.btnAcceptJob.TabIndex = 41;
            this.btnAcceptJob.Text = "Accept Job";
            this.btnAcceptJob.UseVisualStyleBackColor = true;
            this.btnAcceptJob.Click += new System.EventHandler(this.btnAcceptJob_Click);
            // 
            // btnDecline
            // 
            this.btnDecline.Location = new System.Drawing.Point(412, 577);
            this.btnDecline.Name = "btnDecline";
            this.btnDecline.Size = new System.Drawing.Size(104, 33);
            this.btnDecline.TabIndex = 42;
            this.btnDecline.Text = "Decline Job";
            this.btnDecline.UseVisualStyleBackColor = true;
            this.btnDecline.Click += new System.EventHandler(this.btnDecline_Click);
            // 
            // btnAssignTU
            // 
            this.btnAssignTU.Location = new System.Drawing.Point(585, 577);
            this.btnAssignTU.Name = "btnAssignTU";
            this.btnAssignTU.Size = new System.Drawing.Size(178, 33);
            this.btnAssignTU.TabIndex = 43;
            this.btnAssignTU.Text = "Assign Transport Unit";
            this.btnAssignTU.UseVisualStyleBackColor = true;
            // 
            // JobsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 653);
            this.Controls.Add(this.btnAssignTU);
            this.Controls.Add(this.btnDecline);
            this.Controls.Add(this.btnAcceptJob);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvRequestedJobs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "JobsForm";
            this.Text = "JobsForm";
            this.Load += new System.EventHandler(this.JobsForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequestedJobs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAdminSettings;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnTransportUnit;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnLoads;
        private System.Windows.Forms.Button btnJobs;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvRequestedJobs;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnAcceptJob;
        private System.Windows.Forms.Button btnDecline;
        private System.Windows.Forms.Button btnAssignTU;
    }
}