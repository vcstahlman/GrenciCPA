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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientView));
            this.button3 = new System.Windows.Forms.Button();
            this.rtbNotes = new System.Windows.Forms.RichTextBox();
            this.btnEditClient = new System.Windows.Forms.Button();
            this.lblSSN = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblAddressCSZ = new System.Windows.Forms.Label();
            this.lblAddressSt = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.dgvClientPast = new System.Windows.Forms.DataGridView();
            this.txtDateInvoiced = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Service = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtAmountCharged = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtAmountPaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNewJob = new System.Windows.Forms.Button();
            this.btnActive = new System.Windows.Forms.Button();
            this.lblNotes = new System.Windows.Forms.Label();
            this.lblChar = new System.Windows.Forms.Label();
            this.lbxLabels = new System.Windows.Forms.ListBox();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblBirthdate = new System.Windows.Forms.Label();
            this.lblCounty = new System.Windows.Forms.Label();
            this.lblSchool = new System.Windows.Forms.Label();
            this.lblParent = new System.Windows.Forms.Label();
            this.btnPayments = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientPast)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(909, 591);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(194, 62);
            this.button3.TabIndex = 28;
            this.button3.Text = "Close";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // rtbNotes
            // 
            this.rtbNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbNotes.Location = new System.Drawing.Point(625, 26);
            this.rtbNotes.Margin = new System.Windows.Forms.Padding(4);
            this.rtbNotes.Name = "rtbNotes";
            this.rtbNotes.ReadOnly = true;
            this.rtbNotes.Size = new System.Drawing.Size(478, 223);
            this.rtbNotes.TabIndex = 23;
            this.rtbNotes.Text = ". Kids just left for college\n. Recently moved to 123 Main Street\n";
            // 
            // btnEditClient
            // 
            this.btnEditClient.Location = new System.Drawing.Point(351, 204);
            this.btnEditClient.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditClient.Name = "btnEditClient";
            this.btnEditClient.Size = new System.Drawing.Size(141, 32);
            this.btnEditClient.TabIndex = 22;
            this.btnEditClient.Text = "Edit Client Info";
            this.btnEditClient.UseVisualStyleBackColor = true;
            this.btnEditClient.Click += new System.EventHandler(this.btnEditClient_Click);
            // 
            // lblSSN
            // 
            this.lblSSN.AutoSize = true;
            this.lblSSN.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblSSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSSN.Location = new System.Drawing.Point(15, 230);
            this.lblSSN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSSN.Name = "lblSSN";
            this.lblSSN.Size = new System.Drawing.Size(101, 18);
            this.lblSSN.TabIndex = 21;
            this.lblSSN.Text = "200-14-3987";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(15, 210);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(158, 18);
            this.lblEmail.TabIndex = 20;
            this.lblEmail.Text = "smiths@yahoo.com";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(15, 191);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(110, 18);
            this.lblPhone.TabIndex = 19;
            this.lblPhone.Text = "814-393-2500";
            // 
            // lblAddressCSZ
            // 
            this.lblAddressCSZ.AutoSize = true;
            this.lblAddressCSZ.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblAddressCSZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressCSZ.Location = new System.Drawing.Point(15, 83);
            this.lblAddressCSZ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddressCSZ.Name = "lblAddressCSZ";
            this.lblAddressCSZ.Size = new System.Drawing.Size(143, 18);
            this.lblAddressCSZ.TabIndex = 18;
            this.lblAddressCSZ.Text = "Clarion, PA 16214";
            // 
            // lblAddressSt
            // 
            this.lblAddressSt.AutoSize = true;
            this.lblAddressSt.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblAddressSt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressSt.Location = new System.Drawing.Point(15, 64);
            this.lblAddressSt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddressSt.Name = "lblAddressSt";
            this.lblAddressSt.Size = new System.Drawing.Size(126, 18);
            this.lblAddressSt.TabIndex = 17;
            this.lblAddressSt.Text = "123 Main Street";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(15, 26);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(158, 18);
            this.lblName.TabIndex = 16;
            this.lblName.Text = "Joe and Joan Smith";
            // 
            // dgvClientPast
            // 
            this.dgvClientPast.AllowUserToAddRows = false;
            this.dgvClientPast.AllowUserToDeleteRows = false;
            this.dgvClientPast.AllowUserToResizeColumns = false;
            this.dgvClientPast.AllowUserToResizeRows = false;
            this.dgvClientPast.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvClientPast.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvClientPast.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientPast.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtDateInvoiced,
            this.Service,
            this.txtAmountCharged,
            this.txtAmountPaid});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientPast.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvClientPast.Location = new System.Drawing.Point(12, 256);
            this.dgvClientPast.Name = "dgvClientPast";
            this.dgvClientPast.ReadOnly = true;
            this.dgvClientPast.RowHeadersWidth = 51;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvClientPast.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvClientPast.RowTemplate.Height = 24;
            this.dgvClientPast.Size = new System.Drawing.Size(1091, 313);
            this.dgvClientPast.TabIndex = 0;
            this.dgvClientPast.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientPast_CellContentClick);
            // 
            // txtDateInvoiced
            // 
            this.txtDateInvoiced.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.txtDateInvoiced.DataPropertyName = "DateInvoiced";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.txtDateInvoiced.DefaultCellStyle = dataGridViewCellStyle1;
            this.txtDateInvoiced.HeaderText = "Date Invoiced";
            this.txtDateInvoiced.MinimumWidth = 100;
            this.txtDateInvoiced.Name = "txtDateInvoiced";
            this.txtDateInvoiced.ReadOnly = true;
            this.txtDateInvoiced.Width = 147;
            // 
            // Service
            // 
            this.Service.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Service.DataPropertyName = "Services";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Service.DefaultCellStyle = dataGridViewCellStyle2;
            this.Service.HeaderText = "Services";
            this.Service.MinimumWidth = 100;
            this.Service.Name = "Service";
            this.Service.ReadOnly = true;
            // 
            // txtAmountCharged
            // 
            this.txtAmountCharged.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.txtAmountCharged.DataPropertyName = "AmountOwed";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.txtAmountCharged.DefaultCellStyle = dataGridViewCellStyle3;
            this.txtAmountCharged.HeaderText = "Amount Owed";
            this.txtAmountCharged.MinimumWidth = 100;
            this.txtAmountCharged.Name = "txtAmountCharged";
            this.txtAmountCharged.ReadOnly = true;
            this.txtAmountCharged.Width = 125;
            // 
            // txtAmountPaid
            // 
            this.txtAmountPaid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.txtAmountPaid.DataPropertyName = "AmountPaid";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.txtAmountPaid.DefaultCellStyle = dataGridViewCellStyle4;
            this.txtAmountPaid.HeaderText = "Amount Paid";
            this.txtAmountPaid.MinimumWidth = 100;
            this.txtAmountPaid.Name = "txtAmountPaid";
            this.txtAmountPaid.ReadOnly = true;
            this.txtAmountPaid.Width = 125;
            // 
            // btnNewJob
            // 
            this.btnNewJob.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNewJob.Location = new System.Drawing.Point(12, 591);
            this.btnNewJob.Name = "btnNewJob";
            this.btnNewJob.Size = new System.Drawing.Size(180, 62);
            this.btnNewJob.TabIndex = 31;
            this.btnNewJob.Text = "New Job";
            this.btnNewJob.UseVisualStyleBackColor = true;
            this.btnNewJob.Click += new System.EventHandler(this.btnNewJob_Click);
            // 
            // btnActive
            // 
            this.btnActive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnActive.Location = new System.Drawing.Point(200, 591);
            this.btnActive.Name = "btnActive";
            this.btnActive.Size = new System.Drawing.Size(180, 62);
            this.btnActive.TabIndex = 34;
            this.btnActive.Text = "Active Jobs";
            this.btnActive.UseVisualStyleBackColor = true;
            this.btnActive.Click += new System.EventHandler(this.btnActive_Click);
            // 
            // lblNotes
            // 
            this.lblNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(621, 7);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(52, 18);
            this.lblNotes.TabIndex = 35;
            this.lblNotes.Text = "Notes:";
            // 
            // lblChar
            // 
            this.lblChar.AutoSize = true;
            this.lblChar.Location = new System.Drawing.Point(346, 62);
            this.lblChar.Name = "lblChar";
            this.lblChar.Size = new System.Drawing.Size(152, 18);
            this.lblChar.TabIndex = 41;
            this.lblChar.Text = "Client Characteristics:";
            // 
            // lbxLabels
            // 
            this.lbxLabels.FormattingEnabled = true;
            this.lbxLabels.ItemHeight = 18;
            this.lbxLabels.Items.AddRange(new object[] {
            "Joint",
            "Schedule C",
            "Dependents"});
            this.lbxLabels.Location = new System.Drawing.Point(351, 83);
            this.lbxLabels.Name = "lbxLabels";
            this.lbxLabels.Size = new System.Drawing.Size(254, 112);
            this.lbxLabels.TabIndex = 40;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(348, 8);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(121, 18);
            this.lblBalance.TabIndex = 39;
            this.lblBalance.Text = "Balance: $100.00";
            // 
            // lblBirthdate
            // 
            this.lblBirthdate.AutoSize = true;
            this.lblBirthdate.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblBirthdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthdate.Location = new System.Drawing.Point(15, 172);
            this.lblBirthdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBirthdate.Name = "lblBirthdate";
            this.lblBirthdate.Size = new System.Drawing.Size(92, 18);
            this.lblBirthdate.TabIndex = 44;
            this.lblBirthdate.Text = "1997-10-01";
            // 
            // lblCounty
            // 
            this.lblCounty.AutoSize = true;
            this.lblCounty.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblCounty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCounty.Location = new System.Drawing.Point(15, 115);
            this.lblCounty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCounty.Name = "lblCounty";
            this.lblCounty.Size = new System.Drawing.Size(52, 18);
            this.lblCounty.TabIndex = 43;
            this.lblCounty.Text = "Butler";
            // 
            // lblSchool
            // 
            this.lblSchool.AutoSize = true;
            this.lblSchool.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblSchool.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchool.Location = new System.Drawing.Point(15, 134);
            this.lblSchool.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSchool.Name = "lblSchool";
            this.lblSchool.Size = new System.Drawing.Size(78, 18);
            this.lblSchool.TabIndex = 42;
            this.lblSchool.Text = "North BC";
            // 
            // lblParent
            // 
            this.lblParent.AutoSize = true;
            this.lblParent.Location = new System.Drawing.Point(350, 32);
            this.lblParent.Name = "lblParent";
            this.lblParent.Size = new System.Drawing.Size(90, 18);
            this.lblParent.TabIndex = 45;
            this.lblParent.Text = "Juana Smith";
            // 
            // btnPayments
            // 
            this.btnPayments.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPayments.Location = new System.Drawing.Point(387, 590);
            this.btnPayments.Margin = new System.Windows.Forms.Padding(4);
            this.btnPayments.Name = "btnPayments";
            this.btnPayments.Size = new System.Drawing.Size(180, 62);
            this.btnPayments.TabIndex = 46;
            this.btnPayments.Text = "Payments";
            this.btnPayments.UseVisualStyleBackColor = true;
            this.btnPayments.Click += new System.EventHandler(this.btnPayments_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Location = new System.Drawing.Point(779, 591);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(124, 61);
            this.btnRefresh.TabIndex = 47;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // ClientView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 665);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnPayments);
            this.Controls.Add(this.lblParent);
            this.Controls.Add(this.lblBirthdate);
            this.Controls.Add(this.lblCounty);
            this.Controls.Add(this.lblSchool);
            this.Controls.Add(this.lblChar);
            this.Controls.Add(this.lbxLabels);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.btnActive);
            this.Controls.Add(this.btnNewJob);
            this.Controls.Add(this.dgvClientPast);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.rtbNotes);
            this.Controls.Add(this.btnEditClient);
            this.Controls.Add(this.lblSSN);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblAddressCSZ);
            this.Controls.Add(this.lblAddressSt);
            this.Controls.Add(this.lblName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClientView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientView";
            this.Load += new System.EventHandler(this.ClientView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientPast)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RichTextBox rtbNotes;
        private System.Windows.Forms.Button btnEditClient;
        private System.Windows.Forms.Label lblSSN;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblAddressCSZ;
        private System.Windows.Forms.Label lblAddressSt;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DataGridView dgvClientPast;
        private System.Windows.Forms.Button btnNewJob;
        private System.Windows.Forms.Button btnActive;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Label lblChar;
        private System.Windows.Forms.ListBox lbxLabels;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblBirthdate;
        private System.Windows.Forms.Label lblCounty;
        private System.Windows.Forms.Label lblSchool;
        private System.Windows.Forms.Label lblParent;
        private System.Windows.Forms.Button btnPayments;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDateInvoiced;
        private System.Windows.Forms.DataGridViewTextBoxColumn Service;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtAmountCharged;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtAmountPaid;
        private System.Windows.Forms.Button btnRefresh;
    }
}