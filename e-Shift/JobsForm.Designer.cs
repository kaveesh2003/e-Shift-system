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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JobsForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvRequestedJobs = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnAcceptJob = new System.Windows.Forms.Button();
            this.btnDecline = new System.Windows.Forms.Button();
            this.btnAssignTU = new System.Windows.Forms.Button();
            this.btnComplete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAdminSettings = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnTransportUnit = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnLoads = new System.Windows.Forms.Button();
            this.btnJobs = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequestedJobs)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(242, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Handle Job Requests";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(242, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 16);
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
            this.btnSearch.BackColor = System.Drawing.Color.DarkRed;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(937, 91);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(93, 31);
            this.btnSearch.TabIndex = 40;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(722, 100);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(196, 22);
            this.txtSearch.TabIndex = 39;
            // 
            // btnAcceptJob
            // 
            this.btnAcceptJob.BackColor = System.Drawing.Color.DarkRed;
            this.btnAcceptJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcceptJob.ForeColor = System.Drawing.Color.White;
            this.btnAcceptJob.Location = new System.Drawing.Point(245, 578);
            this.btnAcceptJob.Name = "btnAcceptJob";
            this.btnAcceptJob.Size = new System.Drawing.Size(141, 33);
            this.btnAcceptJob.TabIndex = 41;
            this.btnAcceptJob.Text = "Accept Job";
            this.btnAcceptJob.UseVisualStyleBackColor = false;
            this.btnAcceptJob.Click += new System.EventHandler(this.btnAcceptJob_Click);
            // 
            // btnDecline
            // 
            this.btnDecline.BackColor = System.Drawing.Color.DarkRed;
            this.btnDecline.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecline.ForeColor = System.Drawing.Color.White;
            this.btnDecline.Location = new System.Drawing.Point(422, 578);
            this.btnDecline.Name = "btnDecline";
            this.btnDecline.Size = new System.Drawing.Size(133, 33);
            this.btnDecline.TabIndex = 42;
            this.btnDecline.Text = "Decline Job";
            this.btnDecline.UseVisualStyleBackColor = false;
            this.btnDecline.Click += new System.EventHandler(this.btnDecline_Click);
            // 
            // btnAssignTU
            // 
            this.btnAssignTU.BackColor = System.Drawing.Color.DarkRed;
            this.btnAssignTU.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssignTU.ForeColor = System.Drawing.Color.White;
            this.btnAssignTU.Location = new System.Drawing.Point(804, 578);
            this.btnAssignTU.Name = "btnAssignTU";
            this.btnAssignTU.Size = new System.Drawing.Size(226, 33);
            this.btnAssignTU.TabIndex = 43;
            this.btnAssignTU.Text = "Assign Transport Unit";
            this.btnAssignTU.UseVisualStyleBackColor = false;
            this.btnAssignTU.Click += new System.EventHandler(this.btnAssignTU_Click);
            // 
            // btnComplete
            // 
            this.btnComplete.BackColor = System.Drawing.Color.DarkRed;
            this.btnComplete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComplete.ForeColor = System.Drawing.Color.White;
            this.btnComplete.Location = new System.Drawing.Point(589, 578);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(161, 33);
            this.btnComplete.TabIndex = 44;
            this.btnComplete.Text = "Complete Job";
            this.btnComplete.UseVisualStyleBackColor = false;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnAdminSettings);
            this.panel1.Controls.Add(this.btnReports);
            this.panel1.Controls.Add(this.btnTransportUnit);
            this.panel1.Controls.Add(this.btnProducts);
            this.panel1.Controls.Add(this.btnLoads);
            this.panel1.Controls.Add(this.btnJobs);
            this.panel1.Controls.Add(this.btnCustomers);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Location = new System.Drawing.Point(0, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 647);
            this.panel1.TabIndex = 45;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(46, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // btnAdminSettings
            // 
            this.btnAdminSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnAdminSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminSettings.Location = new System.Drawing.Point(19, 595);
            this.btnAdminSettings.Name = "btnAdminSettings";
            this.btnAdminSettings.Size = new System.Drawing.Size(170, 41);
            this.btnAdminSettings.TabIndex = 7;
            this.btnAdminSettings.Text = "Admin Settings";
            this.btnAdminSettings.UseVisualStyleBackColor = false;
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.Location = new System.Drawing.Point(19, 532);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(170, 41);
            this.btnReports.TabIndex = 6;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = false;
            // 
            // btnTransportUnit
            // 
            this.btnTransportUnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnTransportUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransportUnit.Location = new System.Drawing.Point(19, 471);
            this.btnTransportUnit.Name = "btnTransportUnit";
            this.btnTransportUnit.Size = new System.Drawing.Size(170, 41);
            this.btnTransportUnit.TabIndex = 5;
            this.btnTransportUnit.Text = "Transport Unit";
            this.btnTransportUnit.UseVisualStyleBackColor = false;
            // 
            // btnProducts
            // 
            this.btnProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducts.Location = new System.Drawing.Point(19, 404);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(170, 41);
            this.btnProducts.TabIndex = 4;
            this.btnProducts.Text = "Products";
            this.btnProducts.UseVisualStyleBackColor = false;
            // 
            // btnLoads
            // 
            this.btnLoads.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnLoads.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoads.Location = new System.Drawing.Point(19, 339);
            this.btnLoads.Name = "btnLoads";
            this.btnLoads.Size = new System.Drawing.Size(170, 41);
            this.btnLoads.TabIndex = 3;
            this.btnLoads.Text = "Loads";
            this.btnLoads.UseVisualStyleBackColor = false;
            // 
            // btnJobs
            // 
            this.btnJobs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnJobs.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJobs.Location = new System.Drawing.Point(19, 272);
            this.btnJobs.Name = "btnJobs";
            this.btnJobs.Size = new System.Drawing.Size(170, 41);
            this.btnJobs.TabIndex = 2;
            this.btnJobs.Text = "Jobs";
            this.btnJobs.UseVisualStyleBackColor = false;
            // 
            // btnCustomers
            // 
            this.btnCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomers.Location = new System.Drawing.Point(19, 207);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(170, 41);
            this.btnCustomers.TabIndex = 1;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.UseVisualStyleBackColor = false;
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.Location = new System.Drawing.Point(19, 144);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(170, 41);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            // 
            // JobsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1062, 653);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.btnAssignTU);
            this.Controls.Add(this.btnDecline);
            this.Controls.Add(this.btnAcceptJob);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvRequestedJobs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "JobsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JobsForm";
            this.Load += new System.EventHandler(this.JobsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequestedJobs)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvRequestedJobs;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnAcceptJob;
        private System.Windows.Forms.Button btnDecline;
        private System.Windows.Forms.Button btnAssignTU;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAdminSettings;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnTransportUnit;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnLoads;
        private System.Windows.Forms.Button btnJobs;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnDashboard;
    }
}