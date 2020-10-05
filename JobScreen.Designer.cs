namespace GrenciCPA
{
    partial class JobScreen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JobScreen));
            this.button3 = new System.Windows.Forms.Button();
            this.btnEditClient = new System.Windows.Forms.Button();
            this.lblSSN = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblAddressCSZ = new System.Windows.Forms.Label();
            this.lblAddressSt = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.dgvFees = new System.Windows.Forms.DataGridView();
            this.FeeName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.FeeCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Multiplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtLabel = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.txtLabelCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtLabelMultiplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MiniTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Started = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ended = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnComplete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblStaff = new System.Windows.Forms.Label();
            this.btnClient = new System.Windows.Forms.Button();
            this.dgvTime = new System.Windows.Forms.DataGridView();
            this.TimeLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartedTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndedTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSubtract = new System.Windows.Forms.TextBox();
            this.lblSubtractTime = new System.Windows.Forms.Label();
            this.btnEditTime = new System.Windows.Forms.Button();
            this.lblAddTime = new System.Windows.Forms.Label();
            this.txtAddTime = new System.Windows.Forms.TextBox();
            this.cmboAddTime = new System.Windows.Forms.ComboBox();
            this.lblAddMinutes = new System.Windows.Forms.Label();
            this.btnTimer = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblNotes = new System.Windows.Forms.Label();
            this.rtbNotes = new System.Windows.Forms.RichTextBox();
            this.lbxLabels = new System.Windows.Forms.ListBox();
            this.btnPastCharges = new System.Windows.Forms.Button();
            this.txtDateTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTime)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(1129, 492);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(77, 43);
            this.button3.TabIndex = 28;
            this.button3.Text = "Close";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnEditClient
            // 
            this.btnEditClient.Location = new System.Drawing.Point(8, 150);
            this.btnEditClient.Name = "btnEditClient";
            this.btnEditClient.Size = new System.Drawing.Size(87, 23);
            this.btnEditClient.TabIndex = 22;
            this.btnEditClient.Text = "Edit Client Info";
            this.btnEditClient.UseVisualStyleBackColor = true;
            this.btnEditClient.Click += new System.EventHandler(this.btnEditClient_Click);
            // 
            // lblSSN
            // 
            this.lblSSN.AutoSize = true;
            this.lblSSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSSN.Location = new System.Drawing.Point(10, 124);
            this.lblSSN.Name = "lblSSN";
            this.lblSSN.Size = new System.Drawing.Size(78, 13);
            this.lblSSN.TabIndex = 21;
            this.lblSSN.Text = "200-14-3987";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(10, 111);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(115, 13);
            this.lblEmail.TabIndex = 20;
            this.lblEmail.Text = "smiths@yahoo.com";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(10, 98);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(85, 13);
            this.lblPhone.TabIndex = 19;
            this.lblPhone.Text = "814-393-2500";
            // 
            // lblAddressCSZ
            // 
            this.lblAddressCSZ.AutoSize = true;
            this.lblAddressCSZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressCSZ.Location = new System.Drawing.Point(8, 76);
            this.lblAddressCSZ.Name = "lblAddressCSZ";
            this.lblAddressCSZ.Size = new System.Drawing.Size(109, 13);
            this.lblAddressCSZ.TabIndex = 18;
            this.lblAddressCSZ.Text = "Clarion, PA 16214";
            // 
            // lblAddressSt
            // 
            this.lblAddressSt.AutoSize = true;
            this.lblAddressSt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressSt.Location = new System.Drawing.Point(8, 62);
            this.lblAddressSt.Name = "lblAddressSt";
            this.lblAddressSt.Size = new System.Drawing.Size(97, 13);
            this.lblAddressSt.TabIndex = 17;
            this.lblAddressSt.Text = "123 Main Street";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(8, 39);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(118, 13);
            this.lblName.TabIndex = 16;
            this.lblName.Text = "Joe and Joan Smith";
            // 
            // dgvFees
            // 
            this.dgvFees.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvFees.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FeeName,
            this.FeeCost,
            this.Multiplier,
            this.txtLabel,
            this.txtLabelCost,
            this.txtLabelMultiplier,
            this.MiniTotal,
            this.Started,
            this.Ended});
            this.dgvFees.Location = new System.Drawing.Point(218, 37);
            this.dgvFees.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvFees.Name = "dgvFees";
            this.dgvFees.RowHeadersWidth = 51;
            this.dgvFees.RowTemplate.Height = 24;
            this.dgvFees.Size = new System.Drawing.Size(988, 339);
            this.dgvFees.TabIndex = 29;
            this.dgvFees.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFees_CellContentClick);
            // 
            // FeeName
            // 
            this.FeeName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.FeeName.DefaultCellStyle = dataGridViewCellStyle2;
            this.FeeName.FillWeight = 125F;
            this.FeeName.HeaderText = "Service";
            this.FeeName.Items.AddRange(new object[] {
            "Income Taxes",
            "Payroll"});
            this.FeeName.MinimumWidth = 125;
            this.FeeName.Name = "FeeName";
            this.FeeName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.FeeName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.FeeName.Width = 125;
            // 
            // FeeCost
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.FeeCost.DefaultCellStyle = dataGridViewCellStyle3;
            this.FeeCost.FillWeight = 85F;
            this.FeeCost.HeaderText = "Service Cost";
            this.FeeCost.MinimumWidth = 85;
            this.FeeCost.Name = "FeeCost";
            this.FeeCost.Width = 85;
            // 
            // Multiplier
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Multiplier.DefaultCellStyle = dataGridViewCellStyle4;
            this.Multiplier.FillWeight = 75F;
            this.Multiplier.HeaderText = "Multiplier";
            this.Multiplier.MinimumWidth = 75;
            this.Multiplier.Name = "Multiplier";
            this.Multiplier.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Multiplier.Width = 75;
            // 
            // txtLabel
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.txtLabel.DefaultCellStyle = dataGridViewCellStyle5;
            this.txtLabel.FillWeight = 125F;
            this.txtLabel.HeaderText = "Label";
            this.txtLabel.Items.AddRange(new object[] {
            "Dependents",
            "Dependents At College",
            "Amended Return",
            "Schedule C",
            "Earned Income Credit",
            "Employees",
            "Tipped Employees",
            "Payroll Tax Returns"});
            this.txtLabel.MinimumWidth = 125;
            this.txtLabel.Name = "txtLabel";
            this.txtLabel.Width = 125;
            // 
            // txtLabelCost
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.txtLabelCost.DefaultCellStyle = dataGridViewCellStyle6;
            this.txtLabelCost.FillWeight = 85F;
            this.txtLabelCost.HeaderText = "Label Cost";
            this.txtLabelCost.MinimumWidth = 85;
            this.txtLabelCost.Name = "txtLabelCost";
            this.txtLabelCost.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.txtLabelCost.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.txtLabelCost.Width = 85;
            // 
            // txtLabelMultiplier
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.Format = "N2";
            this.txtLabelMultiplier.DefaultCellStyle = dataGridViewCellStyle7;
            this.txtLabelMultiplier.FillWeight = 75F;
            this.txtLabelMultiplier.HeaderText = "Label Multiplier";
            this.txtLabelMultiplier.MinimumWidth = 75;
            this.txtLabelMultiplier.Name = "txtLabelMultiplier";
            this.txtLabelMultiplier.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.txtLabelMultiplier.Width = 75;
            // 
            // MiniTotal
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "N2";
            dataGridViewCellStyle8.NullValue = null;
            this.MiniTotal.DefaultCellStyle = dataGridViewCellStyle8;
            this.MiniTotal.FillWeight = 75F;
            this.MiniTotal.HeaderText = "Min/Total";
            this.MiniTotal.MinimumWidth = 75;
            this.MiniTotal.Name = "MiniTotal";
            this.MiniTotal.Width = 75;
            // 
            // Started
            // 
            this.Started.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.Format = "t";
            dataGridViewCellStyle9.NullValue = null;
            this.Started.DefaultCellStyle = dataGridViewCellStyle9;
            this.Started.FillWeight = 125F;
            this.Started.HeaderText = "Start Date";
            this.Started.MinimumWidth = 125;
            this.Started.Name = "Started";
            this.Started.ReadOnly = true;
            // 
            // Ended
            // 
            this.Ended.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.Format = "t";
            dataGridViewCellStyle10.NullValue = null;
            this.Ended.DefaultCellStyle = dataGridViewCellStyle10;
            this.Ended.FillWeight = 125F;
            this.Ended.HeaderText = "End Date";
            this.Ended.MinimumWidth = 125;
            this.Ended.Name = "Ended";
            this.Ended.ReadOnly = true;
            // 
            // btnComplete
            // 
            this.btnComplete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnComplete.Location = new System.Drawing.Point(1129, 397);
            this.btnComplete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(77, 43);
            this.btnComplete.TabIndex = 30;
            this.btnComplete.Text = "Complete";
            this.btnComplete.UseVisualStyleBackColor = true;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(1129, 445);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(77, 43);
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // lblStaff
            // 
            this.lblStaff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStaff.AutoSize = true;
            this.lblStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaff.Location = new System.Drawing.Point(1042, 7);
            this.lblStaff.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStaff.Name = "lblStaff";
            this.lblStaff.Size = new System.Drawing.Size(172, 13);
            this.lblStaff.TabIndex = 43;
            this.lblStaff.Text = "Assigned To: Anthony Grenci";
            // 
            // btnClient
            // 
            this.btnClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClient.Location = new System.Drawing.Point(24, 333);
            this.btnClient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(112, 43);
            this.btnClient.TabIndex = 44;
            this.btnClient.Text = "Calculate";
            this.btnClient.UseVisualStyleBackColor = true;
            // 
            // dgvTime
            // 
            this.dgvTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTime.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TimeLength,
            this.StartedTime,
            this.EndedTime,
            this.Desc});
            this.dgvTime.Location = new System.Drawing.Point(505, 414);
            this.dgvTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvTime.Name = "dgvTime";
            this.dgvTime.RowHeadersWidth = 51;
            this.dgvTime.RowTemplate.Height = 24;
            this.dgvTime.Size = new System.Drawing.Size(564, 114);
            this.dgvTime.TabIndex = 58;
            // 
            // TimeLength
            // 
            this.TimeLength.DataPropertyName = "Time";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.Format = "g";
            dataGridViewCellStyle11.NullValue = null;
            this.TimeLength.DefaultCellStyle = dataGridViewCellStyle11;
            this.TimeLength.HeaderText = "Time";
            this.TimeLength.MinimumWidth = 6;
            this.TimeLength.Name = "TimeLength";
            this.TimeLength.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TimeLength.Width = 70;
            // 
            // StartedTime
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.Format = "t";
            dataGridViewCellStyle12.NullValue = null;
            this.StartedTime.DefaultCellStyle = dataGridViewCellStyle12;
            this.StartedTime.HeaderText = "Start";
            this.StartedTime.MinimumWidth = 6;
            this.StartedTime.Name = "StartedTime";
            this.StartedTime.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.StartedTime.Width = 110;
            // 
            // EndedTime
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.Format = "t";
            dataGridViewCellStyle13.NullValue = null;
            this.EndedTime.DefaultCellStyle = dataGridViewCellStyle13;
            this.EndedTime.HeaderText = "End";
            this.EndedTime.MinimumWidth = 6;
            this.EndedTime.Name = "EndedTime";
            this.EndedTime.Width = 110;
            // 
            // Desc
            // 
            this.Desc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Desc.HeaderText = "Description";
            this.Desc.MinimumWidth = 90;
            this.Desc.Name = "Desc";
            // 
            // txtSubtract
            // 
            this.txtSubtract.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSubtract.Location = new System.Drawing.Point(406, 508);
            this.txtSubtract.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSubtract.Name = "txtSubtract";
            this.txtSubtract.Size = new System.Drawing.Size(72, 20);
            this.txtSubtract.TabIndex = 67;
            this.txtSubtract.Visible = false;
            // 
            // lblSubtractTime
            // 
            this.lblSubtractTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSubtractTime.AutoSize = true;
            this.lblSubtractTime.Location = new System.Drawing.Point(327, 508);
            this.lblSubtractTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSubtractTime.Name = "lblSubtractTime";
            this.lblSubtractTime.Size = new System.Drawing.Size(76, 13);
            this.lblSubtractTime.TabIndex = 66;
            this.lblSubtractTime.Text = "Subtract Time:";
            this.lblSubtractTime.Visible = false;
            // 
            // btnEditTime
            // 
            this.btnEditTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditTime.Location = new System.Drawing.Point(328, 414);
            this.btnEditTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEditTime.Name = "btnEditTime";
            this.btnEditTime.Size = new System.Drawing.Size(80, 37);
            this.btnEditTime.TabIndex = 65;
            this.btnEditTime.Text = "Edit Time";
            this.btnEditTime.UseVisualStyleBackColor = true;
            this.btnEditTime.Click += new System.EventHandler(this.btnEditTime_Click);
            // 
            // lblAddTime
            // 
            this.lblAddTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAddTime.AutoSize = true;
            this.lblAddTime.Location = new System.Drawing.Point(348, 488);
            this.lblAddTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddTime.Name = "lblAddTime";
            this.lblAddTime.Size = new System.Drawing.Size(55, 13);
            this.lblAddTime.TabIndex = 64;
            this.lblAddTime.Text = "Add Time:";
            this.lblAddTime.Visible = false;
            // 
            // txtAddTime
            // 
            this.txtAddTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtAddTime.Location = new System.Drawing.Point(406, 485);
            this.txtAddTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAddTime.Name = "txtAddTime";
            this.txtAddTime.Size = new System.Drawing.Size(72, 20);
            this.txtAddTime.TabIndex = 63;
            this.txtAddTime.Visible = false;
            // 
            // cmboAddTime
            // 
            this.cmboAddTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmboAddTime.FormattingEnabled = true;
            this.cmboAddTime.Items.AddRange(new object[] {
            "10 minutes",
            "20 minutes",
            "30 minutes",
            "40 minutes",
            "50 minutes",
            "1 hour"});
            this.cmboAddTime.Location = new System.Drawing.Point(406, 461);
            this.cmboAddTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmboAddTime.Name = "cmboAddTime";
            this.cmboAddTime.Size = new System.Drawing.Size(72, 21);
            this.cmboAddTime.TabIndex = 61;
            this.cmboAddTime.Visible = false;
            // 
            // lblAddMinutes
            // 
            this.lblAddMinutes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAddMinutes.AutoSize = true;
            this.lblAddMinutes.Location = new System.Drawing.Point(334, 466);
            this.lblAddMinutes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddMinutes.Name = "lblAddMinutes";
            this.lblAddMinutes.Size = new System.Drawing.Size(69, 13);
            this.lblAddMinutes.TabIndex = 60;
            this.lblAddMinutes.Text = "Add Minutes:";
            this.lblAddMinutes.Visible = false;
            this.lblAddMinutes.Click += new System.EventHandler(this.lblAddMinutes_Click);
            // 
            // btnTimer
            // 
            this.btnTimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTimer.Location = new System.Drawing.Point(413, 414);
            this.btnTimer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTimer.Name = "btnTimer";
            this.btnTimer.Size = new System.Drawing.Size(80, 37);
            this.btnTimer.TabIndex = 59;
            this.btnTimer.Text = "Start Timer";
            this.btnTimer.UseVisualStyleBackColor = true;
            this.btnTimer.Click += new System.EventHandler(this.btnTimer_Click);
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(502, 393);
            this.lblTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(48, 17);
            this.lblTime.TabIndex = 62;
            this.lblTime.Text = "Time:";
            // 
            // lblNotes
            // 
            this.lblNotes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotes.Location = new System.Drawing.Point(5, 379);
            this.lblNotes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(44, 13);
            this.lblNotes.TabIndex = 69;
            this.lblNotes.Text = "Notes:";
            // 
            // rtbNotes
            // 
            this.rtbNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rtbNotes.Location = new System.Drawing.Point(10, 393);
            this.rtbNotes.Name = "rtbNotes";
            this.rtbNotes.Size = new System.Drawing.Size(293, 136);
            this.rtbNotes.TabIndex = 68;
            this.rtbNotes.Text = "Their child Jake just graduated High School\nThey also have a child out of Collage" +
    " and out of state\n\n";
            // 
            // lbxLabels
            // 
            this.lbxLabels.FormattingEnabled = true;
            this.lbxLabels.Items.AddRange(new object[] {
            "Dependents",
            "Schedule C",
            "Joint"});
            this.lbxLabels.Location = new System.Drawing.Point(13, 207);
            this.lbxLabels.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbxLabels.Name = "lbxLabels";
            this.lbxLabels.Size = new System.Drawing.Size(161, 108);
            this.lbxLabels.TabIndex = 71;
            // 
            // btnPastCharges
            // 
            this.btnPastCharges.Location = new System.Drawing.Point(8, 179);
            this.btnPastCharges.Name = "btnPastCharges";
            this.btnPastCharges.Size = new System.Drawing.Size(112, 23);
            this.btnPastCharges.TabIndex = 72;
            this.btnPastCharges.Text = "View Past Charges";
            this.btnPastCharges.UseVisualStyleBackColor = true;
            this.btnPastCharges.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDateTime
            // 
            this.txtDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDateTime.Location = new System.Drawing.Point(555, 393);
            this.txtDateTime.Name = "txtDateTime";
            this.txtDateTime.ReadOnly = true;
            this.txtDateTime.Size = new System.Drawing.Size(135, 20);
            this.txtDateTime.TabIndex = 73;
            this.txtDateTime.TabStop = false;
            // 
            // JobScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 538);
            this.Controls.Add(this.txtDateTime);
            this.Controls.Add(this.btnPastCharges);
            this.Controls.Add(this.lbxLabels);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.rtbNotes);
            this.Controls.Add(this.txtSubtract);
            this.Controls.Add(this.lblSubtractTime);
            this.Controls.Add(this.btnEditTime);
            this.Controls.Add(this.lblAddTime);
            this.Controls.Add(this.txtAddTime);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.cmboAddTime);
            this.Controls.Add(this.lblAddMinutes);
            this.Controls.Add(this.btnTimer);
            this.Controls.Add(this.dgvTime);
            this.Controls.Add(this.btnClient);
            this.Controls.Add(this.lblStaff);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.dgvFees);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnEditClient);
            this.Controls.Add(this.lblSSN);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblAddressCSZ);
            this.Controls.Add(this.lblAddressSt);
            this.Controls.Add(this.lblName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "JobScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JobScreen";
            this.Load += new System.EventHandler(this.JobScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnEditClient;
        private System.Windows.Forms.Label lblSSN;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblAddressCSZ;
        private System.Windows.Forms.Label lblAddressSt;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DataGridView dgvFees;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblStaff;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.DataGridView dgvTime;
        private System.Windows.Forms.TextBox txtSubtract;
        private System.Windows.Forms.Label lblSubtractTime;
        private System.Windows.Forms.Button btnEditTime;
        private System.Windows.Forms.Label lblAddTime;
        private System.Windows.Forms.TextBox txtAddTime;
        private System.Windows.Forms.ComboBox cmboAddTime;
        private System.Windows.Forms.Label lblAddMinutes;
        private System.Windows.Forms.Button btnTimer;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.RichTextBox rtbNotes;
        private System.Windows.Forms.ListBox lbxLabels;
        private System.Windows.Forms.DataGridViewComboBoxColumn FeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FeeCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Multiplier;
        private System.Windows.Forms.DataGridViewComboBoxColumn txtLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtLabelCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtLabelMultiplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn MiniTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Started;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ended;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeLength;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartedTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndedTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desc;
        private System.Windows.Forms.Button btnPastCharges;
        private System.Windows.Forms.TextBox txtDateTime;
    }
}