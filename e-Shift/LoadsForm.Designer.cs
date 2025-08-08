namespace e_Shift
{
    partial class LoadsForm
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
            this.cmbJobID = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLoadDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbAddProduct = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtItemWeight = new System.Windows.Forms.TextBox();
            this.btnAddToLoad = new System.Windows.Forms.Button();
            this.txtTotalWeight = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbLoadStatus = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvLoadProducts = new System.Windows.Forms.DataGridView();
            this.btnSaveLoad = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoadProducts)).BeginInit();
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
            this.panel1.Location = new System.Drawing.Point(5, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 647);
            this.panel1.TabIndex = 1;
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
            this.label1.Location = new System.Drawing.Point(253, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Manage Loads";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select Job ID";
            // 
            // cmbJobID
            // 
            this.cmbJobID.FormattingEnabled = true;
            this.cmbJobID.Location = new System.Drawing.Point(386, 85);
            this.cmbJobID.Name = "cmbJobID";
            this.cmbJobID.Size = new System.Drawing.Size(244, 24);
            this.cmbJobID.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(256, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Load Description";
            // 
            // txtLoadDescription
            // 
            this.txtLoadDescription.Location = new System.Drawing.Point(386, 144);
            this.txtLoadDescription.Multiline = true;
            this.txtLoadDescription.Name = "txtLoadDescription";
            this.txtLoadDescription.Size = new System.Drawing.Size(244, 56);
            this.txtLoadDescription.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(256, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Add Product";
            // 
            // cmbAddProduct
            // 
            this.cmbAddProduct.FormattingEnabled = true;
            this.cmbAddProduct.Location = new System.Drawing.Point(386, 225);
            this.cmbAddProduct.Name = "cmbAddProduct";
            this.cmbAddProduct.Size = new System.Drawing.Size(244, 24);
            this.cmbAddProduct.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(657, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(657, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Weight (in kg)";
            // 
            // txtItemWeight
            // 
            this.txtItemWeight.Location = new System.Drawing.Point(787, 138);
            this.txtItemWeight.Name = "txtItemWeight";
            this.txtItemWeight.Size = new System.Drawing.Size(244, 22);
            this.txtItemWeight.TabIndex = 12;
            // 
            // btnAddToLoad
            // 
            this.btnAddToLoad.Location = new System.Drawing.Point(651, 225);
            this.btnAddToLoad.Name = "btnAddToLoad";
            this.btnAddToLoad.Size = new System.Drawing.Size(191, 24);
            this.btnAddToLoad.TabIndex = 13;
            this.btnAddToLoad.Text = "Add product to Load";
            this.btnAddToLoad.UseVisualStyleBackColor = true;
            this.btnAddToLoad.Click += new System.EventHandler(this.btnAddToLoad_Click);
            // 
            // txtTotalWeight
            // 
            this.txtTotalWeight.Location = new System.Drawing.Point(342, 536);
            this.txtTotalWeight.Name = "txtTotalWeight";
            this.txtTotalWeight.Size = new System.Drawing.Size(142, 22);
            this.txtTotalWeight.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(253, 539);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Total Weight";
            // 
            // cmbLoadStatus
            // 
            this.cmbLoadStatus.FormattingEnabled = true;
            this.cmbLoadStatus.Location = new System.Drawing.Point(605, 534);
            this.cmbLoadStatus.Name = "cmbLoadStatus";
            this.cmbLoadStatus.Size = new System.Drawing.Size(139, 24);
            this.cmbLoadStatus.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(521, 539);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Load Status";
            // 
            // dgvLoadProducts
            // 
            this.dgvLoadProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoadProducts.Location = new System.Drawing.Point(256, 277);
            this.dgvLoadProducts.Name = "dgvLoadProducts";
            this.dgvLoadProducts.RowHeadersWidth = 51;
            this.dgvLoadProducts.RowTemplate.Height = 24;
            this.dgvLoadProducts.Size = new System.Drawing.Size(775, 228);
            this.dgvLoadProducts.TabIndex = 20;
            this.dgvLoadProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoadProducts_CellClick);
            // 
            // btnSaveLoad
            // 
            this.btnSaveLoad.Location = new System.Drawing.Point(259, 588);
            this.btnSaveLoad.Name = "btnSaveLoad";
            this.btnSaveLoad.Size = new System.Drawing.Size(169, 30);
            this.btnSaveLoad.TabIndex = 21;
            this.btnSaveLoad.Text = "Save Load";
            this.btnSaveLoad.UseVisualStyleBackColor = true;
            this.btnSaveLoad.Click += new System.EventHandler(this.btnSaveLoad_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(502, 588);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(169, 30);
            this.btnEdit.TabIndex = 22;
            this.btnEdit.Text = "Edit Load";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(741, 588);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(169, 30);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "Delete Load";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(787, 87);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(132, 22);
            this.txtQuantity.TabIndex = 24;
            // 
            // LoadsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 653);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSaveLoad);
            this.Controls.Add(this.dgvLoadProducts);
            this.Controls.Add(this.cmbLoadStatus);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTotalWeight);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnAddToLoad);
            this.Controls.Add(this.txtItemWeight);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbAddProduct);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLoadDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbJobID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "LoadsForm";
            this.Text = "LoadsForm";
            this.Load += new System.EventHandler(this.LoadsForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoadProducts)).EndInit();
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
        private System.Windows.Forms.ComboBox cmbJobID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLoadDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbAddProduct;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtItemWeight;
        private System.Windows.Forms.Button btnAddToLoad;
        private System.Windows.Forms.TextBox txtTotalWeight;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbLoadStatus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvLoadProducts;
        private System.Windows.Forms.Button btnSaveLoad;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtQuantity;
    }
}