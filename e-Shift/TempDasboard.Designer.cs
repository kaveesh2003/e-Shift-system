namespace e_Shift
{
    partial class TempDasboard
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
            this.btnCompleteProfile = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
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
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 639);
            this.panel1.TabIndex = 2;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(13, 435);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(199, 38);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnProfile
            // 
            this.btnProfile.Location = new System.Drawing.Point(13, 381);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(199, 38);
            this.btnProfile.TabIndex = 4;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            // 
            // btnTrackJob
            // 
            this.btnTrackJob.Location = new System.Drawing.Point(13, 324);
            this.btnTrackJob.Name = "btnTrackJob";
            this.btnTrackJob.Size = new System.Drawing.Size(199, 38);
            this.btnTrackJob.TabIndex = 3;
            this.btnTrackJob.Text = "Track Job";
            this.btnTrackJob.UseVisualStyleBackColor = true;
            // 
            // btnMyJobs
            // 
            this.btnMyJobs.Location = new System.Drawing.Point(13, 267);
            this.btnMyJobs.Name = "btnMyJobs";
            this.btnMyJobs.Size = new System.Drawing.Size(199, 38);
            this.btnMyJobs.TabIndex = 2;
            this.btnMyJobs.Text = "My Jobs";
            this.btnMyJobs.UseVisualStyleBackColor = true;
            // 
            // btnReqShift
            // 
            this.btnReqShift.Location = new System.Drawing.Point(13, 213);
            this.btnReqShift.Name = "btnReqShift";
            this.btnReqShift.Size = new System.Drawing.Size(199, 38);
            this.btnReqShift.TabIndex = 1;
            this.btnReqShift.Text = "Request new Shift";
            this.btnReqShift.UseVisualStyleBackColor = true;
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
            this.lblWelcome.Location = new System.Drawing.Point(601, 108);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(44, 16);
            this.lblWelcome.TabIndex = 3;
            this.lblWelcome.Text = "label1";
            // 
            // btnCompleteProfile
            // 
            this.btnCompleteProfile.Location = new System.Drawing.Point(548, 330);
            this.btnCompleteProfile.Name = "btnCompleteProfile";
            this.btnCompleteProfile.Size = new System.Drawing.Size(164, 47);
            this.btnCompleteProfile.TabIndex = 4;
            this.btnCompleteProfile.Text = "Complete Profile";
            this.btnCompleteProfile.UseVisualStyleBackColor = true;
            this.btnCompleteProfile.Click += new System.EventHandler(this.btnCompleteProfile_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(604, 203);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(44, 16);
            this.lblMessage.TabIndex = 5;
            this.lblMessage.Text = "label1";
            // 
            // TempDasboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 653);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnCompleteProfile);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.panel1);
            this.Name = "TempDasboard";
            this.Text = "TempDasboard";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnTrackJob;
        private System.Windows.Forms.Button btnMyJobs;
        private System.Windows.Forms.Button btnReqShift;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnCompleteProfile;
        private System.Windows.Forms.Label lblMessage;
    }
}