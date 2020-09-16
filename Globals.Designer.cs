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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Globals));
            this.btnDone = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveFee = new System.Windows.Forms.Button();
            this.dgvServices = new System.Windows.Forms.DataGridView();
            this.txtServiceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Minimum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSaveServ = new System.Windows.Forms.Button();
            this.lblFees = new System.Windows.Forms.Label();
            this.dgvFees = new System.Windows.Forms.DataGridView();
            this.FeeLabel = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.btnDone.Size = new System.Drawing.Size(105, 34);
            this.btnDone.TabIndex = 27;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Services:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSaveFee
            // 
            this.btnSaveFee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSaveFee.Location = new System.Drawing.Point(12, 587);
            this.btnSaveFee.Name = "btnSaveFee";
            this.btnSaveFee.Size = new System.Drawing.Size(125, 34);
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
            this.txtCost,
            this.Minimum});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvServices.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvServices.Location = new System.Drawing.Point(12, 32);
            this.dgvServices.Name = "dgvServices";
            this.dgvServices.RowHeadersWidth = 51;
            this.dgvServices.RowTemplate.Height = 24;
            this.dgvServices.Size = new System.Drawing.Size(482, 548);
            this.dgvServices.TabIndex = 36;
            // 
            // txtServiceName
            // 
            this.txtServiceName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtServiceName.HeaderText = "Service";
            this.txtServiceName.MinimumWidth = 100;
            this.txtServiceName.Name = "txtServiceName";
            // 
            // txtCost
            // 
            this.txtCost.HeaderText = "Cost";
            this.txtCost.MinimumWidth = 100;
            this.txtCost.Name = "txtCost";
            // 
            // Minimum
            // 
            this.Minimum.HeaderText = "Minimum";
            this.Minimum.MinimumWidth = 100;
            this.Minimum.Name = "Minimum";
            // 
            // btnSaveServ
            // 
            this.btnSaveServ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSaveServ.Location = new System.Drawing.Point(515, 586);
            this.btnSaveServ.Name = "btnSaveServ";
            this.btnSaveServ.Size = new System.Drawing.Size(127, 34);
            this.btnSaveServ.TabIndex = 34;
            this.btnSaveServ.Text = "Save";
            this.btnSaveServ.UseVisualStyleBackColor = true;
            this.btnSaveServ.Click += new System.EventHandler(this.btnSaveServ_Click);
            // 
            // lblFees
            // 
            this.lblFees.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblFees.AutoSize = true;
            this.lblFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFees.Location = new System.Drawing.Point(589, 9);
            this.lblFees.Name = "lblFees";
            this.lblFees.Size = new System.Drawing.Size(71, 20);
            this.lblFees.TabIndex = 35;
            this.lblFees.Text = "Labels:";
            this.lblFees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvFees
            // 
            this.dgvFees.AllowUserToOrderColumns = true;
            this.dgvFees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FeeLabel,
            this.BaseFee,
            this.MinimumFee,
            this.txtAssociatedService});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFees.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvFees.Location = new System.Drawing.Point(517, 31);
            this.dgvFees.Name = "dgvFees";
            this.dgvFees.RowHeadersWidth = 51;
            this.dgvFees.RowTemplate.Height = 24;
            this.dgvFees.Size = new System.Drawing.Size(700, 549);
            this.dgvFees.TabIndex = 32;
            // 
            // FeeLabel
            // 
            this.FeeLabel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FeeLabel.HeaderText = "Label";
            this.FeeLabel.MinimumWidth = 100;
            this.FeeLabel.Name = "FeeLabel";
            // 
            // BaseFee
            // 
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.BaseFee.DefaultCellStyle = dataGridViewCellStyle2;
            this.BaseFee.FillWeight = 75F;
            this.BaseFee.HeaderText = "Base Fee";
            this.BaseFee.MinimumWidth = 75;
            this.BaseFee.Name = "BaseFee";
            this.BaseFee.Width = 75;
            // 
            // MinimumFee
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.MinimumFee.DefaultCellStyle = dataGridViewCellStyle3;
            this.MinimumFee.FillWeight = 85F;
            this.MinimumFee.HeaderText = "Minimum";
            this.MinimumFee.MinimumWidth = 85;
            this.MinimumFee.Name = "MinimumFee";
            this.MinimumFee.Width = 85;
            // 
            // txtAssociatedService
            // 
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
            this.Controls.Add(this.lblFees);
            this.Controls.Add(this.btnSaveServ);
            this.Controls.Add(this.dgvFees);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaveFee;
        private System.Windows.Forms.DataGridView dgvServices;
        private System.Windows.Forms.Button btnSaveServ;
        private System.Windows.Forms.Label lblFees;
        private System.Windows.Forms.DataGridView dgvFees;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtServiceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Minimum;
        private System.Windows.Forms.DataGridViewTextBoxColumn FeeLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn BaseFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn MinimumFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtAssociatedService;
    }
}