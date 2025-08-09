namespace e_Shift
{
    partial class CompleteJob
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtJobID = new System.Windows.Forms.TextBox();
            this.txtDistance = new System.Windows.Forms.TextBox();
            this.txtTotalCost = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnCompleteJob = new System.Windows.Forms.Button();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStartLocation = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(239, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Complete Job";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Job ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Travel Distance";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total Cost";
            // 
            // txtJobID
            // 
            this.txtJobID.Location = new System.Drawing.Point(255, 88);
            this.txtJobID.Name = "txtJobID";
            this.txtJobID.Size = new System.Drawing.Size(139, 22);
            this.txtJobID.TabIndex = 4;
            // 
            // txtDistance
            // 
            this.txtDistance.Location = new System.Drawing.Point(254, 213);
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.Size = new System.Drawing.Size(139, 22);
            this.txtDistance.TabIndex = 5;
            // 
            // txtTotalCost
            // 
            this.txtTotalCost.Location = new System.Drawing.Point(254, 251);
            this.txtTotalCost.Name = "txtTotalCost";
            this.txtTotalCost.Size = new System.Drawing.Size(139, 22);
            this.txtTotalCost.TabIndex = 6;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(413, 251);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnCompleteJob
            // 
            this.btnCompleteJob.Location = new System.Drawing.Point(207, 291);
            this.btnCompleteJob.Name = "btnCompleteJob";
            this.btnCompleteJob.Size = new System.Drawing.Size(133, 52);
            this.btnCompleteJob.TabIndex = 8;
            this.btnCompleteJob.Text = "Complete Job";
            this.btnCompleteJob.UseVisualStyleBackColor = true;
            this.btnCompleteJob.Click += new System.EventHandler(this.btnCompleteJob_Click);
            // 
            // txtDestination
            // 
            this.txtDestination.Location = new System.Drawing.Point(254, 176);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(139, 22);
            this.txtDestination.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Destination";
            // 
            // txtStartLocation
            // 
            this.txtStartLocation.Location = new System.Drawing.Point(254, 132);
            this.txtStartLocation.Name = "txtStartLocation";
            this.txtStartLocation.Size = new System.Drawing.Size(139, 22);
            this.txtStartLocation.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Started Location";
            // 
            // CompleteJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 380);
            this.Controls.Add(this.txtStartLocation);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDestination);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCompleteJob);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtTotalCost);
            this.Controls.Add(this.txtDistance);
            this.Controls.Add(this.txtJobID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CompleteJob";
            this.Text = "CompleteJob";
            this.Load += new System.EventHandler(this.CompleteJob_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtJobID;
        private System.Windows.Forms.TextBox txtDistance;
        private System.Windows.Forms.TextBox txtTotalCost;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnCompleteJob;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStartLocation;
        private System.Windows.Forms.Label label6;
    }
}