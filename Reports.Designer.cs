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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblReports = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalBilled = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalOwed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Invoice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(942, 730);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(130, 44);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(447, 17);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(101, 43);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
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
            this.clbLabels.Location = new System.Drawing.Point(16, 12);
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
            "Date rand:",
            "Active Labels:"});
            this.lbxReport.Location = new System.Drawing.Point(16, 594);
            this.lbxReport.Name = "lbxReport";
            this.lbxReport.Size = new System.Drawing.Size(650, 180);
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
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FirstName,
            this.LastName,
            this.Company,
            this.TotalBilled,
            this.TotalPaid,
            this.TotalOwed,
            this.Invoice,
            this.Date});
            this.dataGridView1.Location = new System.Drawing.Point(16, 141);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1056, 430);
            this.dataGridView1.TabIndex = 9;
            // 
            // lblReports
            // 
            this.lblReports.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblReports.AutoSize = true;
            this.lblReports.Location = new System.Drawing.Point(13, 574);
            this.lblReports.Name = "lblReports";
            this.lblReports.Size = new System.Drawing.Size(55, 17);
            this.lblReports.TabIndex = 10;
            this.lblReports.Text = "Report:";
            // 
            // FirstName
            // 
            this.FirstName.FillWeight = 125F;
            this.FirstName.HeaderText = "FirstName";
            this.FirstName.MinimumWidth = 125;
            this.FirstName.Name = "FirstName";
            this.FirstName.Width = 125;
            // 
            // LastName
            // 
            this.LastName.FillWeight = 125F;
            this.LastName.HeaderText = "LastName";
            this.LastName.MinimumWidth = 125;
            this.LastName.Name = "LastName";
            this.LastName.Width = 125;
            // 
            // Company
            // 
            this.Company.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Company.FillWeight = 150F;
            this.Company.HeaderText = "Company";
            this.Company.MinimumWidth = 150;
            this.Company.Name = "Company";
            // 
            // TotalBilled
            // 
            this.TotalBilled.HeaderText = "Billed";
            this.TotalBilled.MinimumWidth = 100;
            this.TotalBilled.Name = "TotalBilled";
            // 
            // TotalPaid
            // 
            this.TotalPaid.HeaderText = "Paid";
            this.TotalPaid.MinimumWidth = 100;
            this.TotalPaid.Name = "TotalPaid";
            // 
            // TotalOwed
            // 
            this.TotalOwed.HeaderText = "Owed";
            this.TotalOwed.MinimumWidth = 100;
            this.TotalOwed.Name = "TotalOwed";
            // 
            // Invoice
            // 
            this.Invoice.HeaderText = "Invoice";
            this.Invoice.MinimumWidth = 100;
            this.Invoice.Name = "Invoice";
            // 
            // Date
            // 
            this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Date.FillWeight = 125F;
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 125;
            this.Date.Name = "Date";
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 786);
            this.Controls.Add(this.lblReports);
            this.Controls.Add(this.dataGridView1);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblReports;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Company;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalBilled;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalOwed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Invoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
    }
}