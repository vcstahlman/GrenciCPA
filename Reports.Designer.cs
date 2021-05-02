namespace GrenciCPA
{
    partial class Reports
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.clbLabels = new System.Windows.Forms.CheckedListBox();
            this.lblName = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxMisc = new System.Windows.Forms.TextBox();
            this.lbxReport = new System.Windows.Forms.ListBox();
            this.lblMisc = new System.Windows.Forms.Label();
            this.dgvReports = new System.Windows.Forms.DataGridView();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Service = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalBilled = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalOwed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblReports = new System.Windows.Forms.Label();
            this.lblNameDis = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.lblTo = new System.Windows.Forms.Label();
            this.tbxMisc2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(1357, 606);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(147, 50);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(338, 105);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(136, 48);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // clbLabels
            // 
            this.clbLabels.FormattingEnabled = true;
            this.clbLabels.Items.AddRange(new object[] {
            "Dependents",
            "Schedule C",
            "Schedule E",
            "Joint",
            "Individual"});
            this.clbLabels.Location = new System.Drawing.Point(18, 14);
            this.clbLabels.Name = "clbLabels";
            this.clbLabels.Size = new System.Drawing.Size(229, 137);
            this.clbLabels.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(255, 19);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 18);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name:";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(314, 19);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(160, 24);
            this.tbxName.TabIndex = 5;
            // 
            // tbxMisc
            // 
            this.tbxMisc.Location = new System.Drawing.Point(314, 66);
            this.tbxMisc.Name = "tbxMisc";
            this.tbxMisc.Size = new System.Drawing.Size(160, 24);
            this.tbxMisc.TabIndex = 6;
            // 
            // lbxReport
            // 
            this.lbxReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbxReport.FormattingEnabled = true;
            this.lbxReport.ItemHeight = 18;
            this.lbxReport.Items.AddRange(new object[] {
            "Names:",
            "Total gains:",
            "Date range:",
            "Active Labels:"});
            this.lbxReport.Location = new System.Drawing.Point(18, 544);
            this.lbxReport.Name = "lbxReport";
            this.lbxReport.Size = new System.Drawing.Size(1015, 112);
            this.lbxReport.TabIndex = 7;
            // 
            // lblMisc
            // 
            this.lblMisc.AutoSize = true;
            this.lblMisc.Location = new System.Drawing.Point(255, 66);
            this.lblMisc.Name = "lblMisc";
            this.lblMisc.Size = new System.Drawing.Size(47, 18);
            this.lblMisc.TabIndex = 8;
            this.lblMisc.Text = "Date: ";
            // 
            // dgvReports
            // 
            this.dgvReports.AllowUserToAddRows = false;
            this.dgvReports.AllowUserToDeleteRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReports.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvReports.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReports.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReports.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FirstName,
            this.LastName,
            this.Company,
            this.Service,
            this.TotalBilled,
            this.TotalOwed,
            this.TotalPaid,
            this.Date});
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReports.DefaultCellStyle = dataGridViewCellStyle20;
            this.dgvReports.Location = new System.Drawing.Point(18, 159);
            this.dgvReports.Name = "dgvReports";
            this.dgvReports.ReadOnly = true;
            this.dgvReports.RowHeadersWidth = 51;
            this.dgvReports.RowTemplate.Height = 24;
            this.dgvReports.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReports.Size = new System.Drawing.Size(1484, 350);
            this.dgvReports.TabIndex = 9;
            // 
            // FirstName
            // 
            this.FirstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.FirstName.DefaultCellStyle = dataGridViewCellStyle12;
            this.FirstName.FillWeight = 125F;
            this.FirstName.HeaderText = "FirstName";
            this.FirstName.MinimumWidth = 125;
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.LastName.DefaultCellStyle = dataGridViewCellStyle13;
            this.LastName.FillWeight = 125F;
            this.LastName.HeaderText = "LastName";
            this.LastName.MinimumWidth = 125;
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // Company
            // 
            this.Company.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Company.DefaultCellStyle = dataGridViewCellStyle14;
            this.Company.FillWeight = 150F;
            this.Company.HeaderText = "Company";
            this.Company.MinimumWidth = 100;
            this.Company.Name = "Company";
            this.Company.ReadOnly = true;
            // 
            // Service
            // 
            this.Service.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Service.DefaultCellStyle = dataGridViewCellStyle15;
            this.Service.HeaderText = "Service";
            this.Service.MinimumWidth = 90;
            this.Service.Name = "Service";
            this.Service.ReadOnly = true;
            // 
            // TotalBilled
            // 
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.TotalBilled.DefaultCellStyle = dataGridViewCellStyle16;
            this.TotalBilled.HeaderText = "Billed";
            this.TotalBilled.MinimumWidth = 70;
            this.TotalBilled.Name = "TotalBilled";
            this.TotalBilled.ReadOnly = true;
            this.TotalBilled.Width = 125;
            // 
            // TotalOwed
            // 
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.TotalOwed.DefaultCellStyle = dataGridViewCellStyle17;
            this.TotalOwed.HeaderText = "Owed";
            this.TotalOwed.MinimumWidth = 70;
            this.TotalOwed.Name = "TotalOwed";
            this.TotalOwed.ReadOnly = true;
            this.TotalOwed.Width = 125;
            // 
            // TotalPaid
            // 
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.TotalPaid.DefaultCellStyle = dataGridViewCellStyle18;
            this.TotalPaid.HeaderText = "Paid";
            this.TotalPaid.MinimumWidth = 70;
            this.TotalPaid.Name = "TotalPaid";
            this.TotalPaid.ReadOnly = true;
            this.TotalPaid.Width = 125;
            // 
            // Date
            // 
            this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Date.DefaultCellStyle = dataGridViewCellStyle19;
            this.Date.FillWeight = 125F;
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 100;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // lblReports
            // 
            this.lblReports.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblReports.AutoSize = true;
            this.lblReports.Location = new System.Drawing.Point(15, 523);
            this.lblReports.Name = "lblReports";
            this.lblReports.Size = new System.Drawing.Size(57, 18);
            this.lblReports.TabIndex = 10;
            this.lblReports.Text = "Report:";
            // 
            // lblNameDis
            // 
            this.lblNameDis.AutoSize = true;
            this.lblNameDis.Location = new System.Drawing.Point(490, 25);
            this.lblNameDis.Name = "lblNameDis";
            this.lblNameDis.Size = new System.Drawing.Size(212, 18);
            this.lblNameDis.TabIndex = 11;
            this.lblNameDis.Text = "(First, last and company name)";
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.Location = new System.Drawing.Point(1203, 606);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(148, 50);
            this.btnExport.TabIndex = 24;
            this.btnExport.Text = "Export displayed";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(480, 69);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(26, 18);
            this.lblTo.TabIndex = 25;
            this.lblTo.Text = "To";
            // 
            // tbxMisc2
            // 
            this.tbxMisc2.Location = new System.Drawing.Point(512, 66);
            this.tbxMisc2.Name = "tbxMisc2";
            this.tbxMisc2.Size = new System.Drawing.Size(162, 24);
            this.tbxMisc2.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(680, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 18);
            this.label1.TabIndex = 27;
            this.label1.Text = "YYYY-MM-DD for dates";
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1517, 670);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxMisc2);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.lblNameDis);
            this.Controls.Add(this.lblReports);
            this.Controls.Add(this.dgvReports);
            this.Controls.Add(this.lblMisc);
            this.Controls.Add(this.lbxReport);
            this.Controls.Add(this.tbxMisc);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.clbLabels);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnClose);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Name = "Reports";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.Reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.CheckedListBox clbLabels;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxMisc;
        private System.Windows.Forms.ListBox lbxReport;
        private System.Windows.Forms.Label lblMisc;
        private System.Windows.Forms.DataGridView dgvReports;
        private System.Windows.Forms.Label lblReports;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Company;
        private System.Windows.Forms.DataGridViewTextBoxColumn Service;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalBilled;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalOwed;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.Label lblNameDis;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.TextBox tbxMisc2;
        private System.Windows.Forms.Label label1;
    }
}