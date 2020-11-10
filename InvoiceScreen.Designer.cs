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
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtAmtOwed = new System.Windows.Forms.TextBox();
            this.btnMakeInvoice = new System.Windows.Forms.Button();
            this.lblService = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnEmail = new System.Windows.Forms.Button();
            this.rtbServices = new System.Windows.Forms.RichTextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.rtbPrices = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEdit.Location = new System.Drawing.Point(10, 395);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(79, 29);
            this.btnEdit.TabIndex = 33;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtAmtOwed
            // 
            this.txtAmtOwed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtAmtOwed.Location = new System.Drawing.Point(11, 365);
            this.txtAmtOwed.Margin = new System.Windows.Forms.Padding(2);
            this.txtAmtOwed.Name = "txtAmtOwed";
            this.txtAmtOwed.ReadOnly = true;
            this.txtAmtOwed.Size = new System.Drawing.Size(72, 20);
            this.txtAmtOwed.TabIndex = 31;
            this.txtAmtOwed.Text = "$275";
            // 
            // btnMakeInvoice
            // 
            this.btnMakeInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMakeInvoice.Location = new System.Drawing.Point(10, 428);
            this.btnMakeInvoice.Margin = new System.Windows.Forms.Padding(2);
            this.btnMakeInvoice.Name = "btnMakeInvoice";
            this.btnMakeInvoice.Size = new System.Drawing.Size(79, 40);
            this.btnMakeInvoice.TabIndex = 29;
            this.btnMakeInvoice.Text = "Create Invoice";
            this.btnMakeInvoice.UseVisualStyleBackColor = true;
            this.btnMakeInvoice.Click += new System.EventHandler(this.btnMakeInvoice_Click_1);
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Location = new System.Drawing.Point(8, 53);
            this.lblService.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(0, 13);
            this.lblService.TabIndex = 27;
            // 
            // lblAmount
            // 
            this.lblAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(7, 344);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(75, 13);
            this.lblAmount.TabIndex = 26;
            this.lblAmount.Text = "Amount owed:";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(642, 436);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(77, 35);
            this.btnClose.TabIndex = 24;
            this.btnClose.Text = "Cancel";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Location = new System.Drawing.Point(642, 380);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(77, 35);
            this.btnPrint.TabIndex = 23;
            this.btnPrint.Text = "Print Invoice";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnEmail
            // 
            this.btnEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEmail.Location = new System.Drawing.Point(642, 340);
            this.btnEmail.Margin = new System.Windows.Forms.Padding(2);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(77, 35);
            this.btnEmail.TabIndex = 22;
            this.btnEmail.Text = "Email Invoice";
            this.btnEmail.UseVisualStyleBackColor = true;
            this.btnEmail.Click += new System.EventHandler(this.btnEmail_Click);
            // 
            // rtbServices
            // 
            this.rtbServices.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbServices.Location = new System.Drawing.Point(10, 50);
            this.rtbServices.Name = "rtbServices";
            this.rtbServices.ReadOnly = true;
            this.rtbServices.Size = new System.Drawing.Size(573, 280);
            this.rtbServices.TabIndex = 34;
            this.rtbServices.Text = "";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(10, 24);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(237, 20);
            this.txtName.TabIndex = 35;
            // 
            // rtbPrices
            // 
            this.rtbPrices.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbPrices.Location = new System.Drawing.Point(648, 50);
            this.rtbPrices.Name = "rtbPrices";
            this.rtbPrices.ReadOnly = true;
            this.rtbPrices.Size = new System.Drawing.Size(71, 280);
            this.rtbPrices.TabIndex = 36;
            this.rtbPrices.Text = "";
            // 
            // InvoiceScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 481);
            this.Controls.Add(this.rtbPrices);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.rtbServices);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txtAmtOwed);
            this.Controls.Add(this.btnMakeInvoice);
            this.Controls.Add(this.lblService);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnEmail);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "InvoiceScreen";
            this.Text = "InvoiceScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtAmtOwed;
        private System.Windows.Forms.Button btnMakeInvoice;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnEmail;
        private System.Windows.Forms.RichTextBox rtbServices;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.RichTextBox rtbPrices;
    }
}