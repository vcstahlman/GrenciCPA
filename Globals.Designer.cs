namespace GrenciCPA
{
    partial class Globals
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Globals));
            this.btnDone = new System.Windows.Forms.Button();
            this.lblServices = new System.Windows.Forms.Label();
            this.btnSaveFee = new System.Windows.Forms.Button();
            this.dgvServices = new System.Windows.Forms.DataGridView();
            this.lblCategorys = new System.Windows.Forms.Label();
            this.dgvFees = new System.Windows.Forms.DataGridView();
            this.txtServiceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceFormat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryLabel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BaseFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MinimumFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtAssociatedService = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFees)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDone
            // 
            this.btnDone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDone.Location = new System.Drawing.Point(1080, 587);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(137, 34);
            this.btnDone.TabIndex = 27;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // lblServices
            // 
            this.lblServices.AutoSize = true;
            this.lblServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServices.Location = new System.Drawing.Point(8, 9);
            this.lblServices.Name = "lblServices";
            this.lblServices.Size = new System.Drawing.Size(88, 20);
            this.lblServices.TabIndex = 17;
            this.lblServices.Text = "Services:";
            this.lblServices.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSaveFee
            // 
            this.btnSaveFee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSaveFee.Location = new System.Drawing.Point(937, 588);
            this.btnSaveFee.Name = "btnSaveFee";
            this.btnSaveFee.Size = new System.Drawing.Size(137, 33);
            this.btnSaveFee.TabIndex = 37;
            this.btnSaveFee.Text = "Save";
            this.btnSaveFee.UseVisualStyleBackColor = true;
            this.btnSaveFee.Click += new System.EventHandler(this.btnSaveFee_Click);
            // 
            // dgvServices
            // 
            this.dgvServices.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtServiceName,
            this.InvoiceFormat});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvServices.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvServices.Location = new System.Drawing.Point(12, 32);
            this.dgvServices.Name = "dgvServices";
            this.dgvServices.RowHeadersWidth = 51;
            this.dgvServices.RowTemplate.Height = 24;
            this.dgvServices.Size = new System.Drawing.Size(482, 548);
            this.dgvServices.TabIndex = 36;
            // 
            // lblCategorys
            // 
            this.lblCategorys.AutoSize = true;
            this.lblCategorys.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategorys.Location = new System.Drawing.Point(513, 9);
            this.lblCategorys.Name = "lblCategorys";
            this.lblCategorys.Size = new System.Drawing.Size(100, 20);
            this.lblCategorys.TabIndex = 35;
            this.lblCategorys.Text = "Categorys:";
            this.lblCategorys.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvFees
            // 
            this.dgvFees.AllowUserToOrderColumns = true;
            this.dgvFees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CategoryLabel,
            this.BaseFee,
            this.MinimumFee,
            this.txtAssociatedService});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFees.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvFees.Location = new System.Drawing.Point(517, 31);
            this.dgvFees.Name = "dgvFees";
            this.dgvFees.RowHeadersWidth = 51;
            this.dgvFees.RowTemplate.Height = 24;
            this.dgvFees.Size = new System.Drawing.Size(700, 549);
            this.dgvFees.TabIndex = 32;
            // 
            // txtServiceName
            // 
            this.txtServiceName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.txtServiceName.DefaultCellStyle = dataGridViewCellStyle1;
            this.txtServiceName.FillWeight = 126.9036F;
            this.txtServiceName.HeaderText = "Service";
            this.txtServiceName.MinimumWidth = 100;
            this.txtServiceName.Name = "txtServiceName";
            // 
            // InvoiceFormat
            // 
            this.InvoiceFormat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.InvoiceFormat.FillWeight = 150F;
            this.InvoiceFormat.HeaderText = "Invoice Format";
            this.InvoiceFormat.MinimumWidth = 150;
            this.InvoiceFormat.Name = "InvoiceFormat";
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.CategoryLabel.DefaultCellStyle = dataGridViewCellStyle3;
            this.CategoryLabel.HeaderText = "Category";
            this.CategoryLabel.MinimumWidth = 100;
            this.CategoryLabel.Name = "CategoryLabel";
            // 
            // BaseFee
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.BaseFee.DefaultCellStyle = dataGridViewCellStyle4;
            this.BaseFee.FillWeight = 75F;
            this.BaseFee.HeaderText = "Base Fee";
            this.BaseFee.MinimumWidth = 75;
            this.BaseFee.Name = "BaseFee";
            this.BaseFee.Width = 75;
            // 
            // MinimumFee
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            this.MinimumFee.DefaultCellStyle = dataGridViewCellStyle5;
            this.MinimumFee.FillWeight = 85F;
            this.MinimumFee.HeaderText = "Minimum";
            this.MinimumFee.MinimumWidth = 85;
            this.MinimumFee.Name = "MinimumFee";
            this.MinimumFee.Width = 85;
            // 
            // txtAssociatedService
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.txtAssociatedService.DefaultCellStyle = dataGridViewCellStyle6;
            this.txtAssociatedService.FillWeight = 150F;
            this.txtAssociatedService.HeaderText = "Associated Service";
            this.txtAssociatedService.MinimumWidth = 150;
            this.txtAssociatedService.Name = "txtAssociatedService";
            this.txtAssociatedService.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.txtAssociatedService.Width = 150;
            // 
            // Globals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 633);
            this.Controls.Add(this.btnSaveFee);
            this.Controls.Add(this.dgvServices);
            this.Controls.Add(this.lblCategorys);
            this.Controls.Add(this.dgvFees);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.lblServices);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Globals";
            this.Text = "Globals";
            this.Load += new System.EventHandler(this.Fees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Label lblServices;
        private System.Windows.Forms.Button btnSaveFee;
        private System.Windows.Forms.DataGridView dgvServices;
        private System.Windows.Forms.Label lblCategorys;
        private System.Windows.Forms.DataGridView dgvFees;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtServiceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceFormat;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn BaseFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn MinimumFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtAssociatedService;
    }
}