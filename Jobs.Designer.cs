namespace GrenciCPA
{
    partial class Jobs
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Jobs));
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.dgvJobs = new System.Windows.Forms.DataGridView();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParentClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Service = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssignedTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.View = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ClientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JobID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Invoice = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cbxToInvoice = new System.Windows.Forms.CheckBox();
            this.cbxUnassigned = new System.Windows.Forms.CheckBox();
            this.cbxProgress = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobs)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(1017, 591);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(99, 46);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(379, 7);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(74, 30);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Search ";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(9, 13);
            this.tbxSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(126, 20);
            this.tbxSearch.TabIndex = 12;
            // 
            // dgvJobs
            // 
            this.dgvJobs.AllowUserToAddRows = false;
            this.dgvJobs.AllowUserToDeleteRows = false;
            this.dgvJobs.AllowUserToOrderColumns = true;
            this.dgvJobs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJobs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FirstName,
            this.LastName,
            this.Company,
            this.ParentClient,
            this.Service,
            this.AssignedTo,
            this.View,
            this.ClientID,
            this.JobID,
            this.Invoice});
            this.dgvJobs.Location = new System.Drawing.Point(9, 48);
            this.dgvJobs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvJobs.Name = "dgvJobs";
            this.dgvJobs.ReadOnly = true;
            this.dgvJobs.RowHeadersWidth = 51;
            this.dgvJobs.RowTemplate.Height = 24;
            this.dgvJobs.Size = new System.Drawing.Size(1107, 518);
            this.dgvJobs.TabIndex = 11;
            this.dgvJobs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvJobs_CellContentClick);
            // 
            // FirstName
            // 
            this.FirstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.FirstName.DefaultCellStyle = dataGridViewCellStyle1;
            this.FirstName.FillWeight = 125F;
            this.FirstName.HeaderText = "First Name";
            this.FirstName.MinimumWidth = 125;
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            this.FirstName.Width = 125;
            // 
            // LastName
            // 
            this.LastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.LastName.DefaultCellStyle = dataGridViewCellStyle2;
            this.LastName.FillWeight = 125F;
            this.LastName.HeaderText = "Last Name";
            this.LastName.MinimumWidth = 125;
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            this.LastName.Width = 125;
            // 
            // Company
            // 
            this.Company.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Company.DefaultCellStyle = dataGridViewCellStyle3;
            this.Company.FillWeight = 125F;
            this.Company.HeaderText = "Company";
            this.Company.MinimumWidth = 125;
            this.Company.Name = "Company";
            this.Company.ReadOnly = true;
            // 
            // ParentClient
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.ParentClient.DefaultCellStyle = dataGridViewCellStyle4;
            this.ParentClient.HeaderText = "Parent Client";
            this.ParentClient.MinimumWidth = 100;
            this.ParentClient.Name = "ParentClient";
            this.ParentClient.ReadOnly = true;
            this.ParentClient.Width = 125;
            // 
            // Service
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Service.DefaultCellStyle = dataGridViewCellStyle5;
            this.Service.HeaderText = "Services";
            this.Service.MinimumWidth = 100;
            this.Service.Name = "Service";
            this.Service.ReadOnly = true;
            this.Service.Width = 125;
            // 
            // AssignedTo
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.AssignedTo.DefaultCellStyle = dataGridViewCellStyle6;
            this.AssignedTo.HeaderText = "Assigned To";
            this.AssignedTo.MinimumWidth = 100;
            this.AssignedTo.Name = "AssignedTo";
            this.AssignedTo.ReadOnly = true;
            this.AssignedTo.Width = 125;
            // 
            // View
            // 
            this.View.FillWeight = 95F;
            this.View.HeaderText = "View Job";
            this.View.MinimumWidth = 95;
            this.View.Name = "View";
            this.View.ReadOnly = true;
            this.View.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.View.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.View.Width = 95;
            // 
            // ClientID
            // 
            this.ClientID.HeaderText = "ClientID";
            this.ClientID.MinimumWidth = 6;
            this.ClientID.Name = "ClientID";
            this.ClientID.ReadOnly = true;
            this.ClientID.Visible = false;
            this.ClientID.Width = 125;
            // 
            // JobID
            // 
            this.JobID.HeaderText = "JobID";
            this.JobID.MinimumWidth = 6;
            this.JobID.Name = "JobID";
            this.JobID.ReadOnly = true;
            this.JobID.Visible = false;
            this.JobID.Width = 125;
            // 
            // Invoice
            // 
            this.Invoice.FillWeight = 95F;
            this.Invoice.HeaderText = "Invoice";
            this.Invoice.MinimumWidth = 95;
            this.Invoice.Name = "Invoice";
            this.Invoice.ReadOnly = true;
            this.Invoice.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Invoice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Invoice.Width = 95;
            // 
            // cbxToInvoice
            // 
            this.cbxToInvoice.AutoSize = true;
            this.cbxToInvoice.Location = new System.Drawing.Point(222, 15);
            this.cbxToInvoice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxToInvoice.Name = "cbxToInvoice";
            this.cbxToInvoice.Size = new System.Drawing.Size(77, 17);
            this.cbxToInvoice.TabIndex = 16;
            this.cbxToInvoice.Text = "To Invoice";
            this.cbxToInvoice.UseVisualStyleBackColor = true;
            // 
            // cbxUnassigned
            // 
            this.cbxUnassigned.AutoSize = true;
            this.cbxUnassigned.Checked = true;
            this.cbxUnassigned.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxUnassigned.Location = new System.Drawing.Point(139, 15);
            this.cbxUnassigned.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxUnassigned.Name = "cbxUnassigned";
            this.cbxUnassigned.Size = new System.Drawing.Size(82, 17);
            this.cbxUnassigned.TabIndex = 17;
            this.cbxUnassigned.Text = "Unassigned";
            this.cbxUnassigned.UseVisualStyleBackColor = true;
            // 
            // cbxProgress
            // 
            this.cbxProgress.AutoSize = true;
            this.cbxProgress.Checked = true;
            this.cbxProgress.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxProgress.Location = new System.Drawing.Point(298, 15);
            this.cbxProgress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxProgress.Name = "cbxProgress";
            this.cbxProgress.Size = new System.Drawing.Size(79, 17);
            this.cbxProgress.TabIndex = 19;
            this.cbxProgress.Text = "In Progress";
            this.cbxProgress.UseVisualStyleBackColor = true;
            // 
            // Jobs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 646);
            this.Controls.Add(this.cbxProgress);
            this.Controls.Add(this.cbxUnassigned);
            this.Controls.Add(this.cbxToInvoice);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.dgvJobs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Jobs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jobs";
            this.Load += new System.EventHandler(this.Jobs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.DataGridView dgvJobs;
        private System.Windows.Forms.CheckBox cbxToInvoice;
        private System.Windows.Forms.CheckBox cbxUnassigned;
        private System.Windows.Forms.CheckBox cbxProgress;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Company;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParentClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn Service;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssignedTo;
        private System.Windows.Forms.DataGridViewButtonColumn View;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobID;
        private System.Windows.Forms.DataGridViewButtonColumn Invoice;
    }
}