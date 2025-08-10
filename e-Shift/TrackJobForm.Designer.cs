namespace e_Shift
{
    partial class TrackJobForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrackJobForm));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvJobs = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtJobID = new System.Windows.Forms.TextBox();
            this.txtPickup = new System.Windows.Forms.TextBox();
            this.txtDelivery = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.pbProgress = new System.Windows.Forms.ProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.pnlTrackingDetails = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnTrackJob = new System.Windows.Forms.Button();
            this.btnMyJobs = new System.Windows.Forms.Button();
            this.btnReqShift = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.pnlTrackingDetails.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(256, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Track My Job";
            // 
            // dgvJobs
            // 
            this.dgvJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJobs.Location = new System.Drawing.Point(259, 74);
            this.dgvJobs.Name = "dgvJobs";
            this.dgvJobs.RowHeadersWidth = 51;
            this.dgvJobs.RowTemplate.Height = 24;
            this.dgvJobs.Size = new System.Drawing.Size(776, 130);
            this.dgvJobs.TabIndex = 3;
            this.dgvJobs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvJobs_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Job ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(411, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Start Location";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Destination";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(411, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Status";
            // 
            // txtJobID
            // 
            this.txtJobID.Location = new System.Drawing.Point(148, 14);
            this.txtJobID.Name = "txtJobID";
            this.txtJobID.Size = new System.Drawing.Size(186, 22);
            this.txtJobID.TabIndex = 8;
            this.txtJobID.TextChanged += new System.EventHandler(this.txtJobID_TextChanged);
            // 
            // txtPickup
            // 
            this.txtPickup.Location = new System.Drawing.Point(558, 14);
            this.txtPickup.Name = "txtPickup";
            this.txtPickup.Size = new System.Drawing.Size(186, 22);
            this.txtPickup.TabIndex = 9;
            // 
            // txtDelivery
            // 
            this.txtDelivery.Location = new System.Drawing.Point(148, 79);
            this.txtDelivery.Name = "txtDelivery";
            this.txtDelivery.Size = new System.Drawing.Size(186, 22);
            this.txtDelivery.TabIndex = 10;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(558, 76);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(186, 22);
            this.txtStatus.TabIndex = 11;
            // 
            // pbProgress
            // 
            this.pbProgress.ForeColor = System.Drawing.Color.IndianRed;
            this.pbProgress.Location = new System.Drawing.Point(259, 403);
            this.pbProgress.Name = "pbProgress";
            this.pbProgress.Size = new System.Drawing.Size(774, 23);
            this.pbProgress.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(259, 364);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Job Progress";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(262, 463);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Products in Load";
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(265, 499);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.RowTemplate.Height = 24;
            this.dgvProducts.Size = new System.Drawing.Size(770, 122);
            this.dgvProducts.TabIndex = 15;
            // 
            // pnlTrackingDetails
            // 
            this.pnlTrackingDetails.Controls.Add(this.label2);
            this.pnlTrackingDetails.Controls.Add(this.label3);
            this.pnlTrackingDetails.Controls.Add(this.label4);
            this.pnlTrackingDetails.Controls.Add(this.label5);
            this.pnlTrackingDetails.Controls.Add(this.txtJobID);
            this.pnlTrackingDetails.Controls.Add(this.txtStatus);
            this.pnlTrackingDetails.Controls.Add(this.txtPickup);
            this.pnlTrackingDetails.Controls.Add(this.txtDelivery);
            this.pnlTrackingDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlTrackingDetails.Location = new System.Drawing.Point(259, 220);
            this.pnlTrackingDetails.Name = "pnlTrackingDetails";
            this.pnlTrackingDetails.Size = new System.Drawing.Size(776, 125);
            this.pnlTrackingDetails.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnProfile);
            this.panel1.Controls.Add(this.btnTrackJob);
            this.panel1.Controls.Add(this.btnMyJobs);
            this.panel1.Controls.Add(this.btnReqShift);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 639);
            this.panel1.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(32, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(13, 542);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(199, 38);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.Location = new System.Drawing.Point(13, 488);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(199, 38);
            this.btnProfile.TabIndex = 4;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = false;
            // 
            // btnTrackJob
            // 
            this.btnTrackJob.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnTrackJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrackJob.Location = new System.Drawing.Point(13, 431);
            this.btnTrackJob.Name = "btnTrackJob";
            this.btnTrackJob.Size = new System.Drawing.Size(199, 38);
            this.btnTrackJob.TabIndex = 3;
            this.btnTrackJob.Text = "Track Job";
            this.btnTrackJob.UseVisualStyleBackColor = false;
            // 
            // btnMyJobs
            // 
            this.btnMyJobs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnMyJobs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMyJobs.Location = new System.Drawing.Point(13, 374);
            this.btnMyJobs.Name = "btnMyJobs";
            this.btnMyJobs.Size = new System.Drawing.Size(199, 38);
            this.btnMyJobs.TabIndex = 2;
            this.btnMyJobs.Text = "My Jobs";
            this.btnMyJobs.UseVisualStyleBackColor = false;
            // 
            // btnReqShift
            // 
            this.btnReqShift.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnReqShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReqShift.Location = new System.Drawing.Point(13, 320);
            this.btnReqShift.Name = "btnReqShift";
            this.btnReqShift.Size = new System.Drawing.Size(199, 38);
            this.btnReqShift.TabIndex = 1;
            this.btnReqShift.Text = "Request new Job";
            this.btnReqShift.UseVisualStyleBackColor = false;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(10, 266);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(199, 38);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            // 
            // TrackJobForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1062, 653);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTrackingDetails);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pbProgress);
            this.Controls.Add(this.dgvJobs);
            this.Controls.Add(this.label1);
            this.Name = "TrackJobForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrackJobForm";
            this.Load += new System.EventHandler(this.TrackJobForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.pnlTrackingDetails.ResumeLayout(false);
            this.pnlTrackingDetails.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvJobs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtJobID;
        private System.Windows.Forms.TextBox txtPickup;
        private System.Windows.Forms.TextBox txtDelivery;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.ProgressBar pbProgress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Panel pnlTrackingDetails;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnTrackJob;
        private System.Windows.Forms.Button btnMyJobs;
        private System.Windows.Forms.Button btnReqShift;
        private System.Windows.Forms.Button btnHome;
    }
}