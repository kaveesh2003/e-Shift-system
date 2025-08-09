namespace e_Shift
{
    partial class CustomerDashboard
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
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnTrackJob = new System.Windows.Forms.Button();
            this.btnMyJobs = new System.Windows.Forms.Button();
            this.btnReqShift = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalJobs = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblActivateJobs = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCompletedJobs = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnProfile);
            this.panel1.Controls.Add(this.btnTrackJob);
            this.panel1.Controls.Add(this.btnMyJobs);
            this.panel1.Controls.Add(this.btnReqShift);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 639);
            this.panel1.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(13, 435);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(199, 38);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.Location = new System.Drawing.Point(13, 381);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(199, 38);
            this.btnProfile.TabIndex = 4;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnTrackJob
            // 
            this.btnTrackJob.Location = new System.Drawing.Point(13, 324);
            this.btnTrackJob.Name = "btnTrackJob";
            this.btnTrackJob.Size = new System.Drawing.Size(199, 38);
            this.btnTrackJob.TabIndex = 3;
            this.btnTrackJob.Text = "Track Job";
            this.btnTrackJob.UseVisualStyleBackColor = true;
            this.btnTrackJob.Click += new System.EventHandler(this.btnTrackJob_Click);
            // 
            // btnMyJobs
            // 
            this.btnMyJobs.Location = new System.Drawing.Point(13, 267);
            this.btnMyJobs.Name = "btnMyJobs";
            this.btnMyJobs.Size = new System.Drawing.Size(199, 38);
            this.btnMyJobs.TabIndex = 2;
            this.btnMyJobs.Text = "My Jobs";
            this.btnMyJobs.UseVisualStyleBackColor = true;
            this.btnMyJobs.Click += new System.EventHandler(this.btnMyJobs_Click);
            // 
            // btnReqShift
            // 
            this.btnReqShift.Location = new System.Drawing.Point(13, 213);
            this.btnReqShift.Name = "btnReqShift";
            this.btnReqShift.Size = new System.Drawing.Size(199, 38);
            this.btnReqShift.TabIndex = 1;
            this.btnReqShift.Text = "Request new Shift";
            this.btnReqShift.UseVisualStyleBackColor = true;
            this.btnReqShift.Click += new System.EventHandler(this.btnReqShift_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(10, 159);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(199, 38);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(261, 54);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(44, 16);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "label1";
            this.lblWelcome.Click += new System.EventHandler(this.lblWelcome_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblTotalJobs);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(264, 134);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(143, 100);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Jobs";
            // 
            // lblTotalJobs
            // 
            this.lblTotalJobs.AutoSize = true;
            this.lblTotalJobs.Location = new System.Drawing.Point(59, 54);
            this.lblTotalJobs.Name = "lblTotalJobs";
            this.lblTotalJobs.Size = new System.Drawing.Size(44, 16);
            this.lblTotalJobs.TabIndex = 1;
            this.lblTotalJobs.Text = "label2";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblActivateJobs);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(538, 134);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(143, 100);
            this.panel3.TabIndex = 3;
            // 
            // lblActivateJobs
            // 
            this.lblActivateJobs.AutoSize = true;
            this.lblActivateJobs.Location = new System.Drawing.Point(59, 54);
            this.lblActivateJobs.Name = "lblActivateJobs";
            this.lblActivateJobs.Size = new System.Drawing.Size(44, 16);
            this.lblActivateJobs.TabIndex = 1;
            this.lblActivateJobs.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Activate Jobs";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.lblCompletedJobs);
            this.panel4.Location = new System.Drawing.Point(811, 134);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(143, 100);
            this.panel4.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // lblCompletedJobs
            // 
            this.lblCompletedJobs.AutoSize = true;
            this.lblCompletedJobs.Location = new System.Drawing.Point(19, 18);
            this.lblCompletedJobs.Name = "lblCompletedJobs";
            this.lblCompletedJobs.Size = new System.Drawing.Size(106, 16);
            this.lblCompletedJobs.TabIndex = 0;
            this.lblCompletedJobs.Text = "Completed Jobs";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(264, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Recent Activities";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.listView1);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(267, 327);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(374, 272);
            this.panel5.TabIndex = 6;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(19, 57);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(333, 188);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Recent Job Updates";
            // 
            // CustomerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1062, 653);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.panel1);
            this.Name = "CustomerDashboard";
            this.Text = "CustomerDashboard";
            this.Load += new System.EventHandler(this.CustomerDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnTrackJob;
        private System.Windows.Forms.Button btnMyJobs;
        private System.Windows.Forms.Button btnReqShift;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTotalJobs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblActivateJobs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCompletedJobs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label5;
    }
}