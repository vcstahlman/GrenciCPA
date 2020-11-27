namespace GrenciCPA
{
    partial class Invoices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Invoices));
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.dgvInvoices = new System.Windows.Forms.DataGridView();
            this.View = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ClientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountOwed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientFile = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Payment = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cbxOverdue = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(1194, 687);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(148, 64);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(296, 15);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(84, 26);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search ";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(14, 15);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(139, 24);
            this.tbxSearch.TabIndex = 7;
            // 
            // dgvInvoices
            // 
            this.dgvInvoices.AllowUserToAddRows = false;
            this.dgvInvoices.AllowUserToDeleteRows = false;
            this.dgvInvoices.AllowUserToOrderColumns = true;
            this.dgvInvoices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.View,
            this.ClientID,
            this.LastName,
            this.FirstName,
            this.Company,
            this.AmountOwed,
            this.ClientFile,
            this.Payment});
            this.dgvInvoices.Location = new System.Drawing.Point(10, 61);
            this.dgvInvoices.Name = "dgvInvoices";
            this.dgvInvoices.ReadOnly = true;
            this.dgvInvoices.RowHeadersWidth = 51;
            this.dgvInvoices.RowTemplate.Height = 24;
            this.dgvInvoices.Size = new System.Drawing.Size(1330, 584);
            this.dgvInvoices.TabIndex = 6;
            this.dgvInvoices.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInvoices_CellContentClick_1);
            // 
            // View
            // 
            this.View.HeaderText = "View";
            this.View.MinimumWidth = 6;
            this.View.Name = "View";
            this.View.ReadOnly = true;
            this.View.Width = 90;
            // 
            // ClientID
            // 
            this.ClientID.HeaderText = "ID";
            this.ClientID.MinimumWidth = 6;
            this.ClientID.Name = "ClientID";
            this.ClientID.ReadOnly = true;
            this.ClientID.Visible = false;
            this.ClientID.Width = 125;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Last Name";
            this.LastName.MinimumWidth = 6;
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            this.LastName.Width = 125;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "First Name";
            this.FirstName.MinimumWidth = 6;
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            this.FirstName.Width = 125;
            // 
            // Company
            // 
            this.Company.HeaderText = "Company";
            this.Company.MinimumWidth = 6;
            this.Company.Name = "Company";
            this.Company.ReadOnly = true;
            this.Company.Width = 125;
            // 
            // AmountOwed
            // 
            this.AmountOwed.HeaderText = "Amount Owed";
            this.AmountOwed.MinimumWidth = 6;
            this.AmountOwed.Name = "AmountOwed";
            this.AmountOwed.ReadOnly = true;
            this.AmountOwed.Width = 125;
            // 
            // ClientFile
            // 
            this.ClientFile.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ClientFile.DefaultCellStyle = dataGridViewCellStyle1;
            this.ClientFile.HeaderText = "Client File";
            this.ClientFile.MinimumWidth = 6;
            this.ClientFile.Name = "ClientFile";
            this.ClientFile.ReadOnly = true;
            this.ClientFile.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ClientFile.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Payment
            // 
            this.Payment.HeaderText = "Payment";
            this.Payment.MinimumWidth = 6;
            this.Payment.Name = "Payment";
            this.Payment.ReadOnly = true;
            this.Payment.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Payment.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Payment.Width = 125;
            // 
            // cbxOverdue
            // 
            this.cbxOverdue.AutoSize = true;
            this.cbxOverdue.Location = new System.Drawing.Point(159, 18);
            this.cbxOverdue.Name = "cbxOverdue";
            this.cbxOverdue.Size = new System.Drawing.Size(100, 22);
            this.cbxOverdue.TabIndex = 12;
            this.cbxOverdue.Text = "All Invoices";
            this.cbxOverdue.UseVisualStyleBackColor = true;
            this.cbxOverdue.CheckedChanged += new System.EventHandler(this.cbxOverdue_CheckedChanged);
            // 
            // Invoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 768);
            this.Controls.Add(this.cbxOverdue);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.dgvInvoices);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Invoices";
            this.Text = "Invoices";
            this.Load += new System.EventHandler(this.Invoices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.DataGridView dgvInvoices;
        private System.Windows.Forms.CheckBox cbxOverdue;
        private System.Windows.Forms.DataGridViewButtonColumn View;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Company;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountOwed;
        private System.Windows.Forms.DataGridViewButtonColumn ClientFile;
        private System.Windows.Forms.DataGridViewButtonColumn Payment;
    }
}