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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(759, 724);
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
            this.lbxReport.FormattingEnabled = true;
            this.lbxReport.ItemHeight = 16;
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 141);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(873, 431);
            this.dataGridView1.TabIndex = 9;
            // 
            // lblReports
            // 
            this.lblReports.AutoSize = true;
            this.lblReports.Location = new System.Drawing.Point(13, 588);
            this.lblReports.Name = "lblReports";
            this.lblReports.Size = new System.Drawing.Size(46, 17);
            this.lblReports.TabIndex = 10;
            this.lblReports.Text = "label1";
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 780);
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
    }
}