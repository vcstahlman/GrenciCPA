namespace GrenciCPA
{
    partial class ServiceSelect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceSelect));
            this.lblService = new System.Windows.Forms.Label();
            this.lblStaff = new System.Windows.Forms.Label();
            this.cboService = new System.Windows.Forms.ComboBox();
            this.cboStaff = new System.Windows.Forms.ComboBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.tbxDate = new System.Windows.Forms.TextBox();
            this.btnContinue = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblService
            // 
            this.lblService.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblService.AutoSize = true;
            this.lblService.Location = new System.Drawing.Point(31, 36);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(59, 17);
            this.lblService.TabIndex = 0;
            this.lblService.Text = "Service:";
            // 
            // lblStaff
            // 
            this.lblStaff.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblStaff.AutoSize = true;
            this.lblStaff.Location = new System.Drawing.Point(31, 76);
            this.lblStaff.Name = "lblStaff";
            this.lblStaff.Size = new System.Drawing.Size(41, 17);
            this.lblStaff.TabIndex = 1;
            this.lblStaff.Text = "Staff:";
            // 
            // cboService
            // 
            this.cboService.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboService.FormattingEnabled = true;
            this.cboService.Items.AddRange(new object[] {
            "Income Tax",
            "Payroll",
            "Book Keeping",
            "Audit",
            "Sales Tax",
            "Merchantile Tax"});
            this.cboService.Location = new System.Drawing.Point(126, 33);
            this.cboService.Name = "cboService";
            this.cboService.Size = new System.Drawing.Size(181, 24);
            this.cboService.TabIndex = 2;
            this.cboService.SelectedIndexChanged += new System.EventHandler(this.cboService_SelectedIndexChanged);
            // 
            // cboStaff
            // 
            this.cboStaff.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboStaff.FormattingEnabled = true;
            this.cboStaff.Items.AddRange(new object[] {
            "Dr. Grenci",
            "Mrs. Grenci"});
            this.cboStaff.Location = new System.Drawing.Point(126, 73);
            this.cboStaff.Name = "cboStaff";
            this.cboStaff.Size = new System.Drawing.Size(181, 24);
            this.cboStaff.TabIndex = 3;
            // 
            // lblDate
            // 
            this.lblDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(31, 116);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(42, 17);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Date:";
            // 
            // tbxDate
            // 
            this.tbxDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbxDate.Location = new System.Drawing.Point(126, 113);
            this.tbxDate.Name = "tbxDate";
            this.tbxDate.Size = new System.Drawing.Size(181, 22);
            this.tbxDate.TabIndex = 5;
            // 
            // btnContinue
            // 
            this.btnContinue.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnContinue.Location = new System.Drawing.Point(34, 158);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(132, 61);
            this.btnContinue.TabIndex = 6;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnClose.Location = new System.Drawing.Point(172, 158);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(135, 61);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Cancel";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ServiceSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 231);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.tbxDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.cboStaff);
            this.Controls.Add(this.cboService);
            this.Controls.Add(this.lblStaff);
            this.Controls.Add(this.lblService);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ServiceSelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ServiceSelect";
            this.Load += new System.EventHandler(this.ServiceSelect_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.Label lblStaff;
        private System.Windows.Forms.ComboBox cboService;
        private System.Windows.Forms.ComboBox cboStaff;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox tbxDate;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Button btnClose;
    }
}