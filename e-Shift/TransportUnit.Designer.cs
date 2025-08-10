namespace e_Shift
{
    partial class TransportUnit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransportUnit));
            this.label1 = new System.Windows.Forms.Label();
            this.btnMngDriver = new System.Windows.Forms.Button();
            this.btnMngAssistant = new System.Windows.Forms.Button();
            this.btnmngLorries = new System.Windows.Forms.Button();
            this.btnMngContainers = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbLorryNo = new System.Windows.Forms.ComboBox();
            this.cmbDriver = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbAssistant = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbContainer = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbLoadID = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpPickup = new System.Windows.Forms.DateTimePicker();
            this.dtpDelivery = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvTransportUnit = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransportUnit)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(250, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Manage Transport Units";
            // 
            // btnMngDriver
            // 
            this.btnMngDriver.BackColor = System.Drawing.Color.DarkRed;
            this.btnMngDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMngDriver.ForeColor = System.Drawing.Color.White;
            this.btnMngDriver.Location = new System.Drawing.Point(253, 95);
            this.btnMngDriver.Name = "btnMngDriver";
            this.btnMngDriver.Size = new System.Drawing.Size(170, 40);
            this.btnMngDriver.TabIndex = 6;
            this.btnMngDriver.Text = "Manage Drivers";
            this.btnMngDriver.UseVisualStyleBackColor = false;
            this.btnMngDriver.Click += new System.EventHandler(this.btnMngDriver_Click);
            // 
            // btnMngAssistant
            // 
            this.btnMngAssistant.BackColor = System.Drawing.Color.DarkRed;
            this.btnMngAssistant.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMngAssistant.ForeColor = System.Drawing.Color.White;
            this.btnMngAssistant.Location = new System.Drawing.Point(445, 95);
            this.btnMngAssistant.Name = "btnMngAssistant";
            this.btnMngAssistant.Size = new System.Drawing.Size(162, 40);
            this.btnMngAssistant.TabIndex = 7;
            this.btnMngAssistant.Text = "Manage Assistant";
            this.btnMngAssistant.UseVisualStyleBackColor = false;
            this.btnMngAssistant.Click += new System.EventHandler(this.btnMngAssistant_Click);
            // 
            // btnmngLorries
            // 
            this.btnmngLorries.BackColor = System.Drawing.Color.DarkRed;
            this.btnmngLorries.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmngLorries.ForeColor = System.Drawing.Color.White;
            this.btnmngLorries.Location = new System.Drawing.Point(636, 95);
            this.btnmngLorries.Name = "btnmngLorries";
            this.btnmngLorries.Size = new System.Drawing.Size(161, 40);
            this.btnmngLorries.TabIndex = 8;
            this.btnmngLorries.Text = "Manage Lorries";
            this.btnmngLorries.UseVisualStyleBackColor = false;
            this.btnmngLorries.Click += new System.EventHandler(this.btnmngLorries_Click);
            // 
            // btnMngContainers
            // 
            this.btnMngContainers.BackColor = System.Drawing.Color.DarkRed;
            this.btnMngContainers.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMngContainers.ForeColor = System.Drawing.Color.White;
            this.btnMngContainers.Location = new System.Drawing.Point(834, 95);
            this.btnMngContainers.Name = "btnMngContainers";
            this.btnMngContainers.Size = new System.Drawing.Size(172, 40);
            this.btnMngContainers.TabIndex = 9;
            this.btnMngContainers.Text = "Manage Containers";
            this.btnMngContainers.UseVisualStyleBackColor = false;
            this.btnMngContainers.Click += new System.EventHandler(this.btnMngContainers_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(253, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Assign Transport Unit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(253, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Lorry Number";
            // 
            // cmbLorryNo
            // 
            this.cmbLorryNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLorryNo.FormattingEnabled = true;
            this.cmbLorryNo.Location = new System.Drawing.Point(378, 258);
            this.cmbLorryNo.Name = "cmbLorryNo";
            this.cmbLorryNo.Size = new System.Drawing.Size(229, 24);
            this.cmbLorryNo.TabIndex = 12;
            // 
            // cmbDriver
            // 
            this.cmbDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDriver.FormattingEnabled = true;
            this.cmbDriver.Location = new System.Drawing.Point(378, 311);
            this.cmbDriver.Name = "cmbDriver";
            this.cmbDriver.Size = new System.Drawing.Size(229, 24);
            this.cmbDriver.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(253, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Driver";
            // 
            // cmbAssistant
            // 
            this.cmbAssistant.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAssistant.FormattingEnabled = true;
            this.cmbAssistant.Location = new System.Drawing.Point(378, 366);
            this.cmbAssistant.Name = "cmbAssistant";
            this.cmbAssistant.Size = new System.Drawing.Size(229, 24);
            this.cmbAssistant.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(253, 374);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Assistant";
            // 
            // cmbContainer
            // 
            this.cmbContainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbContainer.FormattingEnabled = true;
            this.cmbContainer.Location = new System.Drawing.Point(791, 201);
            this.cmbContainer.Name = "cmbContainer";
            this.cmbContainer.Size = new System.Drawing.Size(251, 24);
            this.cmbContainer.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(633, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Container";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(633, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "PickUp Date";
            // 
            // cmbLoadID
            // 
            this.cmbLoadID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLoadID.FormattingEnabled = true;
            this.cmbLoadID.Location = new System.Drawing.Point(378, 206);
            this.cmbLoadID.Name = "cmbLoadID";
            this.cmbLoadID.Size = new System.Drawing.Size(229, 24);
            this.cmbLoadID.TabIndex = 21;
            this.cmbLoadID.SelectedIndexChanged += new System.EventHandler(this.cmbLoadID_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(253, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "Load ID";
            // 
            // dtpPickup
            // 
            this.dtpPickup.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPickup.Location = new System.Drawing.Point(791, 269);
            this.dtpPickup.Name = "dtpPickup";
            this.dtpPickup.Size = new System.Drawing.Size(251, 22);
            this.dtpPickup.TabIndex = 22;
            // 
            // dtpDelivery
            // 
            this.dtpDelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDelivery.Location = new System.Drawing.Point(791, 321);
            this.dtpDelivery.Name = "dtpDelivery";
            this.dtpDelivery.Size = new System.Drawing.Size(251, 22);
            this.dtpDelivery.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(633, 321);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 16);
            this.label9.TabIndex = 23;
            this.label9.Text = "Delivery Date ";
            // 
            // dgvTransportUnit
            // 
            this.dgvTransportUnit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransportUnit.Location = new System.Drawing.Point(241, 428);
            this.dgvTransportUnit.Name = "dgvTransportUnit";
            this.dgvTransportUnit.RowHeadersWidth = 51;
            this.dgvTransportUnit.RowTemplate.Height = 24;
            this.dgvTransportUnit.Size = new System.Drawing.Size(801, 190);
            this.dgvTransportUnit.TabIndex = 25;
            this.dgvTransportUnit.SelectionChanged += new System.EventHandler(this.dgvTransportUnit_SelectionChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DarkRed;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(855, 366);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 33);
            this.btnDelete.TabIndex = 102;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DarkRed;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(731, 366);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 33);
            this.btnSave.TabIndex = 100;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.panel1.Location = new System.Drawing.Point(5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 647);
            this.panel1.TabIndex = 103;
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
            this.btnTransportUnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
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
            this.btnJobs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
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
            // TransportUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1062, 653);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvTransportUnit);
            this.Controls.Add(this.dtpDelivery);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtpPickup);
            this.Controls.Add(this.cmbLoadID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbContainer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbAssistant);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbDriver);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbLorryNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnMngContainers);
            this.Controls.Add(this.btnmngLorries);
            this.Controls.Add(this.btnMngAssistant);
            this.Controls.Add(this.btnMngDriver);
            this.Controls.Add(this.label1);
            this.Name = "TransportUnit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TransportUnit";
            this.Load += new System.EventHandler(this.TransportUnit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransportUnit)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMngDriver;
        private System.Windows.Forms.Button btnMngAssistant;
        private System.Windows.Forms.Button btnmngLorries;
        private System.Windows.Forms.Button btnMngContainers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbLorryNo;
        private System.Windows.Forms.ComboBox cmbDriver;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbAssistant;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbContainer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbLoadID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpPickup;
        private System.Windows.Forms.DateTimePicker dtpDelivery;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvTransportUnit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
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