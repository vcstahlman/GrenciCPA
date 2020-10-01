namespace GrenciCPA
{
    partial class InvoiceScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceScreen));
            this.btnEmail = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblService = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMakeInvoice = new System.Windows.Forms.Button();
            this.txtClient = new System.Windows.Forms.TextBox();
            this.txtAmtOwed = new System.Windows.Forms.TextBox();
            this.txtServices = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEmail
            // 
            this.btnEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEmail.Location = new System.Drawing.Point(869, 474);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(103, 43);
            this.btnEmail.TabIndex = 0;
            this.btnEmail.Text = "Email Invoice";
            this.btnEmail.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Location = new System.Drawing.Point(869, 523);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(103, 43);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "Print Invoice";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(869, 592);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(103, 43);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Cancel";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(9, 36);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(47, 17);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Client:";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(9, 87);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(97, 17);
            this.lblAmount.TabIndex = 4;
            this.lblAmount.Text = "Amount owed:";
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Location = new System.Drawing.Point(9, 143);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(66, 17);
            this.lblService.TabIndex = 5;
            this.lblService.Text = "Services:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::GrenciCPA.Properties.Resources.AA_invoice_2019_page_001;
            this.pictureBox1.Location = new System.Drawing.Point(343, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(520, 623);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnMakeInvoice
            // 
            this.btnMakeInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMakeInvoice.Location = new System.Drawing.Point(12, 586);
            this.btnMakeInvoice.Name = "btnMakeInvoice";
            this.btnMakeInvoice.Size = new System.Drawing.Size(105, 49);
            this.btnMakeInvoice.TabIndex = 7;
            this.btnMakeInvoice.Text = "Create Invoice";
            this.btnMakeInvoice.UseVisualStyleBackColor = true;
            this.btnMakeInvoice.Click += new System.EventHandler(this.btnMakeInvoice_Click);
            // 
            // txtClient
            // 
            this.txtClient.Location = new System.Drawing.Point(49, 56);
            this.txtClient.Name = "txtClient";
            this.txtClient.ReadOnly = true;
            this.txtClient.Size = new System.Drawing.Size(169, 22);
            this.txtClient.TabIndex = 8;
            this.txtClient.Text = "Joe and Jan Smith";
            // 
            // txtAmtOwed
            // 
            this.txtAmtOwed.Location = new System.Drawing.Point(49, 107);
            this.txtAmtOwed.Name = "txtAmtOwed";
            this.txtAmtOwed.ReadOnly = true;
            this.txtAmtOwed.Size = new System.Drawing.Size(169, 22);
            this.txtAmtOwed.TabIndex = 9;
            this.txtAmtOwed.Text = "$275";
            // 
            // txtServices
            // 
            this.txtServices.Location = new System.Drawing.Point(49, 163);
            this.txtServices.Name = "txtServices";
            this.txtServices.ReadOnly = true;
            this.txtServices.Size = new System.Drawing.Size(169, 22);
            this.txtServices.TabIndex = 10;
            this.txtServices.Text = "Income Tax, Sales Tax";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(12, 208);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(109, 36);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // InvoiceScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 647);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txtServices);
            this.Controls.Add(this.txtAmtOwed);
            this.Controls.Add(this.txtClient);
            this.Controls.Add(this.btnMakeInvoice);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblService);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnEmail);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InvoiceScreen";
            this.Text = "InvoiceScreen";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEmail;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnMakeInvoice;
        private System.Windows.Forms.TextBox txtClient;
        private System.Windows.Forms.TextBox txtAmtOwed;
        private System.Windows.Forms.TextBox txtServices;
        private System.Windows.Forms.Button btnEdit;
    }
}