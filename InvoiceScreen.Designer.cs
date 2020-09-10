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
            this.btnEmail = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblService = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMakeInvoice = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEmail
            // 
            this.btnEmail.Location = new System.Drawing.Point(685, 277);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(103, 43);
            this.btnEmail.TabIndex = 0;
            this.btnEmail.Text = "Email Invoice";
            this.btnEmail.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(685, 326);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(103, 43);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "Print Invoice";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(685, 395);
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
            this.lblName.Location = new System.Drawing.Point(12, 34);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(125, 17);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Joe and Jan Smith";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(12, 83);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(153, 17);
            this.lblAmount.TabIndex = 4;
            this.lblAmount.Text = "Amount owed: $275.00";
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Location = new System.Drawing.Point(12, 134);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(236, 17);
            this.lblService.TabIndex = 5;
            this.lblService.Text = "Services: Income Tax and Sales Tax";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GrenciCPA.Properties.Resources.AA_invoice_2019_page_001;
            this.pictureBox1.Location = new System.Drawing.Point(343, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(336, 426);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnMakeInvoice
            // 
            this.btnMakeInvoice.Location = new System.Drawing.Point(12, 389);
            this.btnMakeInvoice.Name = "btnMakeInvoice";
            this.btnMakeInvoice.Size = new System.Drawing.Size(105, 49);
            this.btnMakeInvoice.TabIndex = 7;
            this.btnMakeInvoice.Text = "Create Invoice";
            this.btnMakeInvoice.UseVisualStyleBackColor = true;
            // 
            // InvoiceScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMakeInvoice);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblService);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnEmail);
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
    }
}