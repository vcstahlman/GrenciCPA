namespace GrenciCPA
{
    partial class Payments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payments));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblSSN = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblAddressCSZ = new System.Windows.Forms.Label();
            this.lblAddressSt = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnProcess = new System.Windows.Forms.Button();
            this.txbOverride = new System.Windows.Forms.TextBox();
            this.lblOverride = new System.Windows.Forms.Label();
            this.dgvPayments = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInvoice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Check",
            "Cash",
            "Credit",
            "Debit"});
            this.comboBox1.Location = new System.Drawing.Point(12, 234);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(300, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "Method of Payment";
            // 
            // lblSSN
            // 
            this.lblSSN.AutoSize = true;
            this.lblSSN.Location = new System.Drawing.Point(10, 72);
            this.lblSSN.Name = "lblSSN";
            this.lblSSN.Size = new System.Drawing.Size(67, 13);
            this.lblSSN.TabIndex = 27;
            this.lblSSN.Text = "200-14-3987";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(10, 59);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(99, 13);
            this.lblEmail.TabIndex = 26;
            this.lblEmail.Text = "smiths@yahoo.com";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(10, 46);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(73, 13);
            this.lblPhone.TabIndex = 25;
            this.lblPhone.Text = "814-393-2500";
            // 
            // lblAddressCSZ
            // 
            this.lblAddressCSZ.AutoSize = true;
            this.lblAddressCSZ.Location = new System.Drawing.Point(10, 33);
            this.lblAddressCSZ.Name = "lblAddressCSZ";
            this.lblAddressCSZ.Size = new System.Drawing.Size(92, 13);
            this.lblAddressCSZ.TabIndex = 24;
            this.lblAddressCSZ.Text = "Clarion, PA 16214";
            // 
            // lblAddressSt
            // 
            this.lblAddressSt.AutoSize = true;
            this.lblAddressSt.Location = new System.Drawing.Point(10, 20);
            this.lblAddressSt.Name = "lblAddressSt";
            this.lblAddressSt.Size = new System.Drawing.Size(82, 13);
            this.lblAddressSt.TabIndex = 23;
            this.lblAddressSt.Text = "123 Main Street";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(10, 7);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(100, 13);
            this.lblName.TabIndex = 22;
            this.lblName.Text = "Joe and Joan Smith";
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(10, 256);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(77, 13);
            this.lblTotal.TabIndex = 28;
            this.lblTotal.Text = "Amount Owed:";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnClose.Location = new System.Drawing.Point(212, 301);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(99, 46);
            this.btnClose.TabIndex = 29;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnProcess
            // 
            this.btnProcess.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnProcess.Location = new System.Drawing.Point(103, 301);
            this.btnProcess.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(99, 46);
            this.btnProcess.TabIndex = 30;
            this.btnProcess.Text = "Process Payment";
            this.btnProcess.UseVisualStyleBackColor = true;
            // 
            // txbOverride
            // 
            this.txbOverride.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txbOverride.Location = new System.Drawing.Point(103, 275);
            this.txbOverride.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbOverride.Name = "txbOverride";
            this.txbOverride.Size = new System.Drawing.Size(100, 20);
            this.txbOverride.TabIndex = 31;
            // 
            // lblOverride
            // 
            this.lblOverride.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblOverride.AutoSize = true;
            this.lblOverride.Location = new System.Drawing.Point(10, 277);
            this.lblOverride.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOverride.Name = "lblOverride";
            this.lblOverride.Size = new System.Drawing.Size(89, 13);
            this.lblOverride.TabIndex = 32;
            this.lblOverride.Text = "Payment amount:";
            // 
            // dgvPayments
            // 
            this.dgvPayments.AllowUserToAddRows = false;
            this.dgvPayments.AllowUserToDeleteRows = false;
            this.dgvPayments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtInvoice,
            this.txtAmount});
            this.dgvPayments.Location = new System.Drawing.Point(12, 103);
            this.dgvPayments.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvPayments.Name = "dgvPayments";
            this.dgvPayments.ReadOnly = true;
            this.dgvPayments.RowHeadersWidth = 51;
            this.dgvPayments.RowTemplate.Height = 24;
            this.dgvPayments.Size = new System.Drawing.Size(298, 122);
            this.dgvPayments.TabIndex = 33;
            this.dgvPayments.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPayments_CellContentClick);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox1.Location = new System.Drawing.Point(250, 275);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(61, 20);
            this.textBox1.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 277);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Check #";
            // 
            // txtInvoice
            // 
            this.txtInvoice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtInvoice.DataPropertyName = "Invoice";
            this.txtInvoice.HeaderText = "Invoice";
            this.txtInvoice.MinimumWidth = 40;
            this.txtInvoice.Name = "txtInvoice";
            this.txtInvoice.ReadOnly = true;
            // 
            // txtAmount
            // 
            this.txtAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtAmount.DataPropertyName = "Amount";
            this.txtAmount.HeaderText = "Amount";
            this.txtAmount.MinimumWidth = 40;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = true;
            // 
            // Payments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 360);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dgvPayments);
            this.Controls.Add(this.lblOverride);
            this.Controls.Add(this.txbOverride);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblSSN);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblAddressCSZ);
            this.Controls.Add(this.lblAddressSt);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.comboBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Payments";
            this.Text = "Payments";
            this.Load += new System.EventHandler(this.Payments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblSSN;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblAddressCSZ;
        private System.Windows.Forms.Label lblAddressSt;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.TextBox txbOverride;
        private System.Windows.Forms.Label lblOverride;
        private System.Windows.Forms.DataGridView dgvPayments;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtInvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtAmount;
    }
}