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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Globals));
            this.btnDone = new System.Windows.Forms.Button();
            this.lblServices = new System.Windows.Forms.Label();
            this.dgvServices = new System.Windows.Forms.DataGridView();
            this.Service_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtServiceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceFormat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaveService = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteService = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblCharacteristics = new System.Windows.Forms.Label();
            this.dgvFees = new System.Windows.Forms.DataGridView();
            this.CharacteristicID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CharacteristicLabel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BaseFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MinimumFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtAssociatedService = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.AssociatedServName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaveFee = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteFee = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFees)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDone
            // 
            this.btnDone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDone.Location = new System.Drawing.Point(1289, 570);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(154, 39);
            this.btnDone.TabIndex = 27;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // lblServices
            // 
            this.lblServices.AutoSize = true;
            this.lblServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServices.Location = new System.Drawing.Point(3, 18);
            this.lblServices.Name = "lblServices";
            this.lblServices.Size = new System.Drawing.Size(75, 17);
            this.lblServices.TabIndex = 17;
            this.lblServices.Text = "Services:";
            this.lblServices.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvServices
            // 
            this.dgvServices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Service_ID,
            this.txtServiceName,
            this.InvoiceFormat,
            this.SaveService,
            this.DeleteService});
            this.dgvServices.Location = new System.Drawing.Point(8, 44);
            this.dgvServices.Name = "dgvServices";
            this.dgvServices.RowHeadersVisible = false;
            this.dgvServices.RowHeadersWidth = 51;
            this.dgvServices.RowTemplate.Height = 24;
            this.dgvServices.Size = new System.Drawing.Size(658, 510);
            this.dgvServices.TabIndex = 36;
            this.dgvServices.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServices_CellContentClick);
            this.dgvServices.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvServices_DefaultValuesNeeded);
            // 
            // Service_ID
            // 
            this.Service_ID.HeaderText = "Service_ID";
            this.Service_ID.Name = "Service_ID";
            this.Service_ID.Visible = false;
            // 
            // txtServiceName
            // 
            this.txtServiceName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.txtServiceName.DefaultCellStyle = dataGridViewCellStyle1;
            this.txtServiceName.FillWeight = 125F;
            this.txtServiceName.HeaderText = "Service";
            this.txtServiceName.MinimumWidth = 125;
            this.txtServiceName.Name = "txtServiceName";
            this.txtServiceName.Width = 125;
            // 
            // InvoiceFormat
            // 
            this.InvoiceFormat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.InvoiceFormat.FillWeight = 150F;
            this.InvoiceFormat.HeaderText = "Invoice Format";
            this.InvoiceFormat.MinimumWidth = 150;
            this.InvoiceFormat.Name = "InvoiceFormat";
            // 
            // SaveService
            // 
            this.SaveService.FillWeight = 85F;
            this.SaveService.HeaderText = "Save";
            this.SaveService.MinimumWidth = 85;
            this.SaveService.Name = "SaveService";
            this.SaveService.Width = 85;
            // 
            // DeleteService
            // 
            this.DeleteService.FillWeight = 85F;
            this.DeleteService.HeaderText = "Delete";
            this.DeleteService.MinimumWidth = 85;
            this.DeleteService.Name = "DeleteService";
            this.DeleteService.Width = 85;
            // 
            // lblCharacteristics
            // 
            this.lblCharacteristics.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCharacteristics.AutoSize = true;
            this.lblCharacteristics.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharacteristics.Location = new System.Drawing.Point(669, 18);
            this.lblCharacteristics.Name = "lblCharacteristics";
            this.lblCharacteristics.Size = new System.Drawing.Size(121, 17);
            this.lblCharacteristics.TabIndex = 35;
            this.lblCharacteristics.Text = "Characteristics:";
            this.lblCharacteristics.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvFees
            // 
            this.dgvFees.AllowUserToOrderColumns = true;
            this.dgvFees.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CharacteristicID,
            this.CharacteristicLabel,
            this.BaseFee,
            this.MinimumFee,
            this.txtAssociatedService,
            this.AssociatedServName,
            this.SaveFee,
            this.DeleteFee});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFees.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvFees.Location = new System.Drawing.Point(672, 44);
            this.dgvFees.Name = "dgvFees";
            this.dgvFees.RowHeadersVisible = false;
            this.dgvFees.RowHeadersWidth = 51;
            this.dgvFees.RowTemplate.Height = 24;
            this.dgvFees.ShowEditingIcon = false;
            this.dgvFees.Size = new System.Drawing.Size(779, 510);
            this.dgvFees.TabIndex = 32;
            this.dgvFees.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFees_CellContentClick);
            this.dgvFees.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvFees_DefaultValuesNeeded);
            // 
            // CharacteristicID
            // 
            this.CharacteristicID.HeaderText = "CharacteristicID";
            this.CharacteristicID.Name = "CharacteristicID";
            this.CharacteristicID.Visible = false;
            // 
            // CharacteristicLabel
            // 
            this.CharacteristicLabel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.CharacteristicLabel.DefaultCellStyle = dataGridViewCellStyle2;
            this.CharacteristicLabel.HeaderText = "Characteristic";
            this.CharacteristicLabel.MinimumWidth = 100;
            this.CharacteristicLabel.Name = "CharacteristicLabel";
            // 
            // BaseFee
            // 
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.BaseFee.DefaultCellStyle = dataGridViewCellStyle3;
            this.BaseFee.FillWeight = 75F;
            this.BaseFee.HeaderText = "Base Fee";
            this.BaseFee.MinimumWidth = 75;
            this.BaseFee.Name = "BaseFee";
            this.BaseFee.Width = 75;
            // 
            // MinimumFee
            // 
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.MinimumFee.DefaultCellStyle = dataGridViewCellStyle4;
            this.MinimumFee.FillWeight = 85F;
            this.MinimumFee.HeaderText = "Minimum";
            this.MinimumFee.MinimumWidth = 85;
            this.MinimumFee.Name = "MinimumFee";
            this.MinimumFee.Visible = false;
            this.MinimumFee.Width = 85;
            // 
            // txtAssociatedService
            // 
            this.txtAssociatedService.FillWeight = 150F;
            this.txtAssociatedService.HeaderText = "Associated Service";
            this.txtAssociatedService.MinimumWidth = 150;
            this.txtAssociatedService.Name = "txtAssociatedService";
            this.txtAssociatedService.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.txtAssociatedService.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.txtAssociatedService.Width = 150;
            // 
            // AssociatedServName
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.AssociatedServName.DefaultCellStyle = dataGridViewCellStyle5;
            this.AssociatedServName.FillWeight = 150F;
            this.AssociatedServName.HeaderText = "AssociatedServName";
            this.AssociatedServName.MinimumWidth = 150;
            this.AssociatedServName.Name = "AssociatedServName";
            this.AssociatedServName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AssociatedServName.Visible = false;
            this.AssociatedServName.Width = 150;
            // 
            // SaveFee
            // 
            this.SaveFee.FillWeight = 85F;
            this.SaveFee.HeaderText = "Save";
            this.SaveFee.MinimumWidth = 85;
            this.SaveFee.Name = "SaveFee";
            this.SaveFee.Width = 85;
            // 
            // DeleteFee
            // 
            this.DeleteFee.FillWeight = 85F;
            this.DeleteFee.HeaderText = "Delete";
            this.DeleteFee.MinimumWidth = 85;
            this.DeleteFee.Name = "DeleteFee";
            this.DeleteFee.Width = 85;
            // 
            // Globals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1460, 620);
            this.Controls.Add(this.dgvServices);
            this.Controls.Add(this.lblCharacteristics);
            this.Controls.Add(this.dgvFees);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.lblServices);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
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
        private System.Windows.Forms.DataGridView dgvServices;
        private System.Windows.Forms.Label lblCharacteristics;
        private System.Windows.Forms.DataGridView dgvFees;
        private System.Windows.Forms.DataGridViewTextBoxColumn Service_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtServiceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceFormat;
        private System.Windows.Forms.DataGridViewButtonColumn SaveService;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteService;
        private System.Windows.Forms.DataGridViewTextBoxColumn CharacteristicID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CharacteristicLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn BaseFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn MinimumFee;
        private System.Windows.Forms.DataGridViewComboBoxColumn txtAssociatedService;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssociatedServName;
        private System.Windows.Forms.DataGridViewButtonColumn SaveFee;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteFee;
    }
}