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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.clbLabels = new System.Windows.Forms.CheckedListBox();
            this.cboService = new System.Windows.Forms.ComboBox();
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
            this.TotalPaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalOwed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Invoice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblReports = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.tbxFrom = new System.Windows.Forms.TextBox();
            this.tbxTo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(1049, 724);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(130, 44);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(508, 82);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(101, 43);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // clbLabels
            // 
            this.clbLabels.CheckOnClick = true;
            this.clbLabels.FormattingEnabled = true;
            this.clbLabels.Items.AddRange(new object[] {
            "Dependents",
            "Schedule C",
            "Schedule E",
            "Joint",
            "Individual"});
            this.clbLabels.Location = new System.Drawing.Point(16, 12);
            this.clbLabels.MultiColumn = true;
            this.clbLabels.Name = "clbLabels";
            this.clbLabels.Size = new System.Drawing.Size(204, 123);
            this.clbLabels.TabIndex = 2;
            // 
            // cboService
            // 
            this.cboService.FormattingEnabled = true;
            this.cboService.Items.AddRange(new object[] {
            "Income Taxes",
            "Payroll",
            "Book Keeping",
            "Audit",
            "Sales Tax",
            "Merchantile Tax"});
            this.cboService.Location = new System.Drawing.Point(230, 101);
            this.cboService.Name = "cboService";
            this.cboService.Size = new System.Drawing.Size(191, 24);
            this.cboService.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(227, 17);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 17);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name:";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(279, 17);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(142, 22);
            this.tbxName.TabIndex = 5;
            // 
            // tbxMisc
            // 
            this.tbxMisc.Location = new System.Drawing.Point(279, 59);
            this.tbxMisc.Name = "tbxMisc";
            this.tbxMisc.Size = new System.Drawing.Size(142, 22);
            this.tbxMisc.TabIndex = 6;
            // 
            // lbxReport
            // 
            this.lbxReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbxReport.FormattingEnabled = true;
            this.lbxReport.ItemHeight = 16;
            this.lbxReport.Items.AddRange(new object[] {
            "Names:",
            "Total gains:",
            "Date range:",
            "Active Labels:"});
            this.lbxReport.Location = new System.Drawing.Point(16, 608);
            this.lbxReport.Name = "lbxReport";
            this.lbxReport.Size = new System.Drawing.Size(650, 148);
            this.lbxReport.TabIndex = 7;
            // 
            // lblMisc
            // 
            this.lblMisc.AutoSize = true;
            this.lblMisc.Location = new System.Drawing.Point(227, 59);
            this.lblMisc.Name = "lblMisc";
            this.lblMisc.Size = new System.Drawing.Size(40, 17);
            this.lblMisc.TabIndex = 8;
            this.lblMisc.Text = "Misc:";
            // 
            // dgvReports
            // 
            this.dgvReports.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReports.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FirstName,
            this.LastName,
            this.Company,
            this.Service,
            this.TotalBilled,
            this.TotalPaid,
            this.TotalOwed,
            this.Invoice,
            this.Date});
            this.dgvReports.Location = new System.Drawing.Point(16, 141);
            this.dgvReports.Name = "dgvReports";
            this.dgvReports.RowHeadersWidth = 51;
            this.dgvReports.RowTemplate.Height = 24;
            this.dgvReports.Size = new System.Drawing.Size(1163, 431);
            this.dgvReports.TabIndex = 9;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "FirstName";
            this.FirstName.MinimumWidth = 6;
            this.FirstName.Name = "FirstName";
            this.FirstName.Width = 90;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "LastName";
            this.LastName.MinimumWidth = 6;
            this.LastName.Name = "LastName";
            this.LastName.Width = 90;
            // 
            // Company
            // 
            this.Company.HeaderText = "Company";
            this.Company.MinimumWidth = 6;
            this.Company.Name = "Company";
            this.Company.Width = 90;
            // 
            // Service
            // 
            this.Service.HeaderText = "Service";
            this.Service.MinimumWidth = 6;
            this.Service.Name = "Service";
            this.Service.Width = 125;
            // 
            // TotalBilled
            // 
            this.TotalBilled.HeaderText = "Billed";
            this.TotalBilled.MinimumWidth = 6;
            this.TotalBilled.Name = "TotalBilled";
            this.TotalBilled.Width = 80;
            // 
            // TotalPaid
            // 
            this.TotalPaid.HeaderText = "Paid";
            this.TotalPaid.MinimumWidth = 6;
            this.TotalPaid.Name = "TotalPaid";
            this.TotalPaid.Width = 80;
            // 
            // TotalOwed
            // 
            this.TotalOwed.HeaderText = "Owed";
            this.TotalOwed.MinimumWidth = 6;
            this.TotalOwed.Name = "TotalOwed";
            this.TotalOwed.Width = 80;
            // 
            // Invoice
            // 
            this.Invoice.HeaderText = "Invoice";
            this.Invoice.MinimumWidth = 6;
            this.Invoice.Name = "Invoice";
            this.Invoice.Width = 80;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.Width = 80;
            // 
            // lblReports
            // 
            this.lblReports.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblReports.AutoSize = true;
            this.lblReports.Location = new System.Drawing.Point(13, 588);
            this.lblReports.Name = "lblReports";
            this.lblReports.Size = new System.Drawing.Size(55, 17);
            this.lblReports.TabIndex = 10;
            this.lblReports.Text = "Report:";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(441, 20);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(44, 17);
            this.lblFrom.TabIndex = 11;
            this.lblFrom.Text = "From:";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(441, 46);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(29, 17);
            this.lblTo.TabIndex = 12;
            this.lblTo.Text = "To:";
            // 
            // tbxFrom
            // 
            this.tbxFrom.Location = new System.Drawing.Point(509, 17);
            this.tbxFrom.Name = "tbxFrom";
            this.tbxFrom.Size = new System.Drawing.Size(100, 22);
            this.tbxFrom.TabIndex = 13;
            // 
            // tbxTo
            // 
            this.tbxTo.Location = new System.Drawing.Point(509, 43);
            this.tbxTo.Name = "tbxTo";
            this.tbxTo.Size = new System.Drawing.Size(100, 22);
            this.tbxTo.TabIndex = 14;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 780);
            this.Controls.Add(this.tbxTo);
            this.Controls.Add(this.tbxFrom);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.lblReports);
            this.Controls.Add(this.dgvReports);
            this.Controls.Add(this.lblMisc);
            this.Controls.Add(this.lbxReport);
            this.Controls.Add(this.tbxMisc);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.cboService);
            this.Controls.Add(this.clbLabels);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnClose);
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
        private System.Windows.Forms.ComboBox cboService;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalOwed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Invoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.TextBox tbxFrom;
        private System.Windows.Forms.TextBox tbxTo;
    }
}