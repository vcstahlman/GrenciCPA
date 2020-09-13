namespace GrenciCPA
{
    partial class ClientView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientView));
            this.button3 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnEditClient = new System.Windows.Forms.Button();
            this.lblSSN = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblAddressCSZ = new System.Windows.Forms.Label();
            this.lblAddressSt = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.dgvClientPast = new System.Windows.Forms.DataGridView();
            this.Service = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateInvoices = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountBilled = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountPaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ViewInvoice = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNewJob = new System.Windows.Forms.Button();
            this.lblOverdue = new System.Windows.Forms.Label();
            this.btnActive = new System.Windows.Forms.Button();
            this.lbxLabels = new System.Windows.Forms.ListBox();
            this.lblLabel = new System.Windows.Forms.Label();
            this.btnAddLabels = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientPast)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(836, 409);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(172, 53);
            this.button3.TabIndex = 28;
            this.button3.Text = "Close";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(583, 6);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(425, 180);
            this.richTextBox1.TabIndex = 23;
            this.richTextBox1.Text = "Notes:";
            // 
            // btnEditClient
            // 
            this.btnEditClient.Location = new System.Drawing.Point(10, 155);
            this.btnEditClient.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditClient.Name = "btnEditClient";
            this.btnEditClient.Size = new System.Drawing.Size(125, 28);
            this.btnEditClient.TabIndex = 22;
            this.btnEditClient.Text = "Edit Client Info";
            this.btnEditClient.UseVisualStyleBackColor = true;
            this.btnEditClient.Click += new System.EventHandler(this.btnEditClient_Click);
            // 
            // lblSSN
            // 
            this.lblSSN.AutoSize = true;
            this.lblSSN.Location = new System.Drawing.Point(13, 134);
            this.lblSSN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSSN.Name = "lblSSN";
            this.lblSSN.Size = new System.Drawing.Size(90, 17);
            this.lblSSN.TabIndex = 21;
            this.lblSSN.Text = "200-14-3987";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(13, 117);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(131, 17);
            this.lblEmail.TabIndex = 20;
            this.lblEmail.Text = "smiths@yahoo.com";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(15, 100);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(98, 17);
            this.lblPhone.TabIndex = 19;
            this.lblPhone.Text = "814-393-2500";
            // 
            // lblAddressCSZ
            // 
            this.lblAddressCSZ.AutoSize = true;
            this.lblAddressCSZ.Location = new System.Drawing.Point(13, 60);
            this.lblAddressCSZ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddressCSZ.Name = "lblAddressCSZ";
            this.lblAddressCSZ.Size = new System.Drawing.Size(122, 17);
            this.lblAddressCSZ.TabIndex = 18;
            this.lblAddressCSZ.Text = "Clarion, PA 16214";
            // 
            // lblAddressSt
            // 
            this.lblAddressSt.AutoSize = true;
            this.lblAddressSt.Location = new System.Drawing.Point(13, 43);
            this.lblAddressSt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddressSt.Name = "lblAddressSt";
            this.lblAddressSt.Size = new System.Drawing.Size(108, 17);
            this.lblAddressSt.TabIndex = 17;
            this.lblAddressSt.Text = "123 Main Street";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(13, 9);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(133, 17);
            this.lblName.TabIndex = 16;
            this.lblName.Text = "Joe and Joan Smith";
            // 
            // dgvClientPast
            // 
            this.dgvClientPast.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvClientPast.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientPast.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Service,
            this.StartDate,
            this.DateInvoices,
            this.AmountBilled,
            this.AmountPaid,
            this.ViewInvoice});
            this.dgvClientPast.Location = new System.Drawing.Point(12, 193);
            this.dgvClientPast.Name = "dgvClientPast";
            this.dgvClientPast.RowHeadersWidth = 51;
            this.dgvClientPast.RowTemplate.Height = 24;
            this.dgvClientPast.Size = new System.Drawing.Size(996, 208);
            this.dgvClientPast.TabIndex = 29;
            this.dgvClientPast.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientPast_CellContentClick);
            // 
            // Service
            // 
            this.Service.HeaderText = "Service";
            this.Service.MinimumWidth = 6;
            this.Service.Name = "Service";
            this.Service.Width = 125;
            // 
            // StartDate
            // 
            this.StartDate.HeaderText = "Start Date";
            this.StartDate.MinimumWidth = 6;
            this.StartDate.Name = "StartDate";
            this.StartDate.Width = 125;
            // 
            // DateInvoices
            // 
            this.DateInvoices.HeaderText = "Date Invoices";
            this.DateInvoices.MinimumWidth = 6;
            this.DateInvoices.Name = "DateInvoices";
            this.DateInvoices.Width = 125;
            // 
            // AmountBilled
            // 
            this.AmountBilled.HeaderText = "Amount Billed";
            this.AmountBilled.MinimumWidth = 6;
            this.AmountBilled.Name = "AmountBilled";
            this.AmountBilled.Width = 125;
            // 
            // AmountPaid
            // 
            this.AmountPaid.HeaderText = "Amount Paid";
            this.AmountPaid.MinimumWidth = 6;
            this.AmountPaid.Name = "AmountPaid";
            this.AmountPaid.Width = 125;
            // 
            // ViewInvoice
            // 
            this.ViewInvoice.HeaderText = "View Invoice";
            this.ViewInvoice.MinimumWidth = 6;
            this.ViewInvoice.Name = "ViewInvoice";
            this.ViewInvoice.Width = 125;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(451, 154);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(125, 31);
            this.btnSave.TabIndex = 30;
            this.btnSave.Text = "Save Notes";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnNewJob
            // 
            this.btnNewJob.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNewJob.Location = new System.Drawing.Point(10, 407);
            this.btnNewJob.Name = "btnNewJob";
            this.btnNewJob.Size = new System.Drawing.Size(160, 55);
            this.btnNewJob.TabIndex = 31;
            this.btnNewJob.Text = "New Job";
            this.btnNewJob.UseVisualStyleBackColor = true;
            this.btnNewJob.Click += new System.EventHandler(this.btnNewJob_Click);
            // 
            // lblOverdue
            // 
            this.lblOverdue.AutoSize = true;
            this.lblOverdue.Location = new System.Drawing.Point(280, 6);
            this.lblOverdue.Name = "lblOverdue";
            this.lblOverdue.Size = new System.Drawing.Size(123, 17);
            this.lblOverdue.TabIndex = 32;
            this.lblOverdue.Text = "Overdue: $100.00";
            // 
            // btnActive
            // 
            this.btnActive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnActive.Location = new System.Drawing.Point(176, 409);
            this.btnActive.Name = "btnActive";
            this.btnActive.Size = new System.Drawing.Size(148, 53);
            this.btnActive.TabIndex = 34;
            this.btnActive.Text = "Active Jobs";
            this.btnActive.UseVisualStyleBackColor = true;
            this.btnActive.Click += new System.EventHandler(this.btnActive_Click);
            // 
            // lbxLabels
            // 
            this.lbxLabels.FormattingEnabled = true;
            this.lbxLabels.ItemHeight = 16;
            this.lbxLabels.Items.AddRange(new object[] {
            "Joint",
            "Schedule C",
            "Dependents"});
            this.lbxLabels.Location = new System.Drawing.Point(283, 49);
            this.lbxLabels.Name = "lbxLabels";
            this.lbxLabels.Size = new System.Drawing.Size(293, 100);
            this.lbxLabels.TabIndex = 35;
            // 
            // lblLabel
            // 
            this.lblLabel.AutoSize = true;
            this.lblLabel.Location = new System.Drawing.Point(280, 29);
            this.lblLabel.Name = "lblLabel";
            this.lblLabel.Size = new System.Drawing.Size(93, 17);
            this.lblLabel.TabIndex = 36;
            this.lblLabel.Text = "Client Labels:";
            // 
            // btnAddLabels
            // 
            this.btnAddLabels.Location = new System.Drawing.Point(283, 155);
            this.btnAddLabels.Name = "btnAddLabels";
            this.btnAddLabels.Size = new System.Drawing.Size(120, 30);
            this.btnAddLabels.TabIndex = 37;
            this.btnAddLabels.Text = "Add/Edit Labels";
            this.btnAddLabels.UseVisualStyleBackColor = true;
            // 
            // ClientView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 475);
            this.Controls.Add(this.btnAddLabels);
            this.Controls.Add(this.lblLabel);
            this.Controls.Add(this.lbxLabels);
            this.Controls.Add(this.btnActive);
            this.Controls.Add(this.lblOverdue);
            this.Controls.Add(this.btnNewJob);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvClientPast);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnEditClient);
            this.Controls.Add(this.lblSSN);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblAddressCSZ);
            this.Controls.Add(this.lblAddressSt);
            this.Controls.Add(this.lblName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClientView";
            this.Text = "ClientView";
            this.Load += new System.EventHandler(this.ClientView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientPast)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnEditClient;
        private System.Windows.Forms.Label lblSSN;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblAddressCSZ;
        private System.Windows.Forms.Label lblAddressSt;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DataGridView dgvClientPast;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNewJob;
        private System.Windows.Forms.Label lblOverdue;
        private System.Windows.Forms.Button btnActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn Service;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateInvoices;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountBilled;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountPaid;
        private System.Windows.Forms.DataGridViewButtonColumn ViewInvoice;
        private System.Windows.Forms.ListBox lbxLabels;
        private System.Windows.Forms.Label lblLabel;
        private System.Windows.Forms.Button btnAddLabels;
    }
}