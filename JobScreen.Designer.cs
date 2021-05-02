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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JobScreen));
            this.button3 = new System.Windows.Forms.Button();
            this.btnEditClient = new System.Windows.Forms.Button();
            this.dgvFees = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboService = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cboCharacteristics = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.txtCharCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCharMultiplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMiniTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnComplete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblStaff = new System.Windows.Forms.Label();
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
            this.btnTimer = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblNotes = new System.Windows.Forms.Label();
            this.rtbNotes = new System.Windows.Forms.RichTextBox();
            this.cmboStaff = new System.Windows.Forms.ComboBox();
            this.lblParent = new System.Windows.Forms.Label();
            this.lblBirthdate = new System.Windows.Forms.Label();
            this.lblCounty = new System.Windows.Forms.Label();
            this.lblSchool = new System.Windows.Forms.Label();
            this.lblChar = new System.Windows.Forms.Label();
            this.lbxChar = new System.Windows.Forms.ListBox();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblSSN = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblAddressCSZ = new System.Windows.Forms.Label();
            this.lblAddressSt = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTime)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(1426, 587);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 60);
            this.button3.TabIndex = 28;
            this.button3.Text = "Close";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnEditClient
            // 
            this.btnEditClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnEditClient.Location = new System.Drawing.Point(350, 10);
            this.btnEditClient.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditClient.Name = "btnEditClient";
            this.btnEditClient.Size = new System.Drawing.Size(140, 25);
            this.btnEditClient.TabIndex = 22;
            this.btnEditClient.Text = "View Client Info";
            this.btnEditClient.UseVisualStyleBackColor = true;
            this.btnEditClient.Click += new System.EventHandler(this.btnEditClient_Click);
            // 
            // dgvFees
            // 
            this.dgvFees.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvFees.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.cboService,
            this.cboCharacteristics,
            this.txtCharCost,
            this.txtCharMultiplier,
            this.txtMiniTotal});
            this.dgvFees.Location = new System.Drawing.Point(350, 44);
            this.dgvFees.MultiSelect = false;
            this.dgvFees.Name = "dgvFees";
            this.dgvFees.RowHeadersWidth = 51;
            this.dgvFees.RowTemplate.Height = 24;
            this.dgvFees.Size = new System.Drawing.Size(1197, 350);
            this.dgvFees.TabIndex = 29;
            this.dgvFees.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFees_CellContentClick);
            this.dgvFees.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFees_CellContentClick);
            this.dgvFees.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFees_RowEnter);
            this.dgvFees.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvFees_RowsAdded);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Visible = false;
            this.ID.Width = 125;
            // 
            // cboService
            // 
            this.cboService.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.cboService.DefaultCellStyle = dataGridViewCellStyle2;
            this.cboService.HeaderText = "Service";
            this.cboService.MaxDropDownItems = 100;
            this.cboService.MinimumWidth = 100;
            this.cboService.Name = "cboService";
            this.cboService.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // cboCharacteristics
            // 
            this.cboCharacteristics.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.cboCharacteristics.DefaultCellStyle = dataGridViewCellStyle3;
            this.cboCharacteristics.HeaderText = "Characteristics";
            this.cboCharacteristics.MaxDropDownItems = 100;
            this.cboCharacteristics.MinimumWidth = 100;
            this.cboCharacteristics.Name = "cboCharacteristics";
            // 
            // txtCharCost
            // 
            this.txtCharCost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Gray;
            this.txtCharCost.DefaultCellStyle = dataGridViewCellStyle4;
            this.txtCharCost.FillWeight = 85F;
            this.txtCharCost.HeaderText = "Cost";
            this.txtCharCost.MinimumWidth = 85;
            this.txtCharCost.Name = "txtCharCost";
            this.txtCharCost.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // txtCharMultiplier
            // 
            this.txtCharMultiplier.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.Format = "N2";
            this.txtCharMultiplier.DefaultCellStyle = dataGridViewCellStyle5;
            this.txtCharMultiplier.FillWeight = 75F;
            this.txtCharMultiplier.HeaderText = "Multiplier";
            this.txtCharMultiplier.MinimumWidth = 75;
            this.txtCharMultiplier.Name = "txtCharMultiplier";
            this.txtCharMultiplier.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // txtMiniTotal
            // 
            this.txtMiniTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = null;
            this.txtMiniTotal.DefaultCellStyle = dataGridViewCellStyle6;
            this.txtMiniTotal.FillWeight = 75F;
            this.txtMiniTotal.HeaderText = "Total";
            this.txtMiniTotal.MinimumWidth = 75;
            this.txtMiniTotal.Name = "txtMiniTotal";
            this.txtMiniTotal.ReadOnly = true;
            // 
            // btnComplete
            // 
            this.btnComplete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnComplete.Location = new System.Drawing.Point(1426, 454);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(116, 60);
            this.btnComplete.TabIndex = 30;
            this.btnComplete.Text = "Complete";
            this.btnComplete.UseVisualStyleBackColor = true;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(1426, 520);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(116, 60);
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblStaff
            // 
            this.lblStaff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStaff.AutoSize = true;
            this.lblStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblStaff.Location = new System.Drawing.Point(1261, 14);
            this.lblStaff.Name = "lblStaff";
            this.lblStaff.Size = new System.Drawing.Size(94, 18);
            this.lblStaff.TabIndex = 43;
            this.lblStaff.Text = "Assigned To:";
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
            this.dgvTime.Location = new System.Drawing.Point(698, 441);
            this.dgvTime.MultiSelect = false;
            this.dgvTime.Name = "dgvTime";
            this.dgvTime.RowHeadersWidth = 51;
            this.dgvTime.RowTemplate.Height = 24;
            this.dgvTime.Size = new System.Drawing.Size(708, 206);
            this.dgvTime.TabIndex = 58;
            // 
            // TimeLength
            // 
            this.TimeLength.DataPropertyName = "Time";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Format = "g";
            dataGridViewCellStyle7.NullValue = null;
            this.TimeLength.DefaultCellStyle = dataGridViewCellStyle7;
            this.TimeLength.HeaderText = "Time";
            this.TimeLength.MinimumWidth = 6;
            this.TimeLength.Name = "TimeLength";
            this.TimeLength.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TimeLength.Width = 70;
            // 
            // StartedTime
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Format = "t";
            dataGridViewCellStyle8.NullValue = null;
            this.StartedTime.DefaultCellStyle = dataGridViewCellStyle8;
            this.StartedTime.HeaderText = "Start";
            this.StartedTime.MinimumWidth = 6;
            this.StartedTime.Name = "StartedTime";
            this.StartedTime.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.StartedTime.Width = 110;
            // 
            // EndedTime
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.Format = "t";
            dataGridViewCellStyle9.NullValue = null;
            this.EndedTime.DefaultCellStyle = dataGridViewCellStyle9;
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
            this.txtSubtract.Location = new System.Drawing.Point(573, 619);
            this.txtSubtract.Name = "txtSubtract";
            this.txtSubtract.Size = new System.Drawing.Size(106, 24);
            this.txtSubtract.TabIndex = 67;
            this.txtSubtract.Visible = false;
            // 
            // lblSubtractTime
            // 
            this.lblSubtractTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSubtractTime.AutoSize = true;
            this.lblSubtractTime.Location = new System.Drawing.Point(455, 619);
            this.lblSubtractTime.Name = "lblSubtractTime";
            this.lblSubtractTime.Size = new System.Drawing.Size(104, 18);
            this.lblSubtractTime.TabIndex = 66;
            this.lblSubtractTime.Text = "Subtract Time:";
            this.lblSubtractTime.Visible = false;
            // 
            // btnEditTime
            // 
            this.btnEditTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditTime.Location = new System.Drawing.Point(458, 520);
            this.btnEditTime.Name = "btnEditTime";
            this.btnEditTime.Size = new System.Drawing.Size(221, 51);
            this.btnEditTime.TabIndex = 65;
            this.btnEditTime.Text = "Edit Time";
            this.btnEditTime.UseVisualStyleBackColor = true;
            this.btnEditTime.Click += new System.EventHandler(this.btnEditTime_Click);
            // 
            // lblAddTime
            // 
            this.lblAddTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAddTime.AutoSize = true;
            this.lblAddTime.Location = new System.Drawing.Point(487, 592);
            this.lblAddTime.Name = "lblAddTime";
            this.lblAddTime.Size = new System.Drawing.Size(74, 18);
            this.lblAddTime.TabIndex = 64;
            this.lblAddTime.Text = "Add Time:";
            this.lblAddTime.Visible = false;
            // 
            // txtAddTime
            // 
            this.txtAddTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtAddTime.Location = new System.Drawing.Point(573, 589);
            this.txtAddTime.Name = "txtAddTime";
            this.txtAddTime.Size = new System.Drawing.Size(106, 24);
            this.txtAddTime.TabIndex = 63;
            this.txtAddTime.Visible = false;
            // 
            // btnTimer
            // 
            this.btnTimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTimer.Location = new System.Drawing.Point(458, 463);
            this.btnTimer.Name = "btnTimer";
            this.btnTimer.Size = new System.Drawing.Size(221, 51);
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
            this.lblTime.Location = new System.Drawing.Point(756, 413);
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
            this.lblNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblNotes.Location = new System.Drawing.Point(3, 429);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(52, 18);
            this.lblNotes.TabIndex = 69;
            this.lblNotes.Text = "Notes:";
            // 
            // rtbNotes
            // 
            this.rtbNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rtbNotes.Enabled = false;
            this.rtbNotes.Location = new System.Drawing.Point(6, 456);
            this.rtbNotes.Margin = new System.Windows.Forms.Padding(4);
            this.rtbNotes.Name = "rtbNotes";
            this.rtbNotes.Size = new System.Drawing.Size(438, 187);
            this.rtbNotes.TabIndex = 68;
            this.rtbNotes.Text = "Their child Jake just graduated High School\nThey also have a child out of Collage" +
    " and out of state\n\n";
            // 
            // cmboStaff
            // 
            this.cmboStaff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmboStaff.FormattingEnabled = true;
            this.cmboStaff.Location = new System.Drawing.Point(1401, 10);
            this.cmboStaff.Name = "cmboStaff";
            this.cmboStaff.Size = new System.Drawing.Size(136, 26);
            this.cmboStaff.TabIndex = 72;
            // 
            // lblParent
            // 
            this.lblParent.AutoSize = true;
            this.lblParent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblParent.Location = new System.Drawing.Point(15, 274);
            this.lblParent.Name = "lblParent";
            this.lblParent.Size = new System.Drawing.Size(90, 18);
            this.lblParent.TabIndex = 85;
            this.lblParent.Text = "Juana Smith";
            // 
            // lblBirthdate
            // 
            this.lblBirthdate.AutoSize = true;
            this.lblBirthdate.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblBirthdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblBirthdate.Location = new System.Drawing.Point(15, 169);
            this.lblBirthdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBirthdate.Name = "lblBirthdate";
            this.lblBirthdate.Size = new System.Drawing.Size(82, 18);
            this.lblBirthdate.TabIndex = 84;
            this.lblBirthdate.Text = "1997-10-01";
            // 
            // lblCounty
            // 
            this.lblCounty.AutoSize = true;
            this.lblCounty.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblCounty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblCounty.Location = new System.Drawing.Point(15, 111);
            this.lblCounty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCounty.Name = "lblCounty";
            this.lblCounty.Size = new System.Drawing.Size(46, 18);
            this.lblCounty.TabIndex = 83;
            this.lblCounty.Text = "Butler";
            // 
            // lblSchool
            // 
            this.lblSchool.AutoSize = true;
            this.lblSchool.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblSchool.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblSchool.Location = new System.Drawing.Point(14, 130);
            this.lblSchool.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSchool.Name = "lblSchool";
            this.lblSchool.Size = new System.Drawing.Size(70, 18);
            this.lblSchool.TabIndex = 82;
            this.lblSchool.Text = "North BC";
            // 
            // lblChar
            // 
            this.lblChar.AutoSize = true;
            this.lblChar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblChar.Location = new System.Drawing.Point(15, 300);
            this.lblChar.Name = "lblChar";
            this.lblChar.Size = new System.Drawing.Size(152, 18);
            this.lblChar.TabIndex = 81;
            this.lblChar.Text = "Client Characteristics:";
            // 
            // lbxChar
            // 
            this.lbxChar.Enabled = false;
            this.lbxChar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lbxChar.FormattingEnabled = true;
            this.lbxChar.ItemHeight = 18;
            this.lbxChar.Items.AddRange(new object[] {
            "Joint",
            "Schedule C",
            "Dependents"});
            this.lbxChar.Location = new System.Drawing.Point(18, 321);
            this.lbxChar.Name = "lbxChar";
            this.lbxChar.Size = new System.Drawing.Size(295, 94);
            this.lbxChar.TabIndex = 80;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblBalance.Location = new System.Drawing.Point(15, 258);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(121, 18);
            this.lblBalance.TabIndex = 79;
            this.lblBalance.Text = "Balance: $100.00";
            // 
            // lblSSN
            // 
            this.lblSSN.AutoSize = true;
            this.lblSSN.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblSSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblSSN.Location = new System.Drawing.Point(14, 226);
            this.lblSSN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSSN.Name = "lblSSN";
            this.lblSSN.Size = new System.Drawing.Size(90, 18);
            this.lblSSN.TabIndex = 78;
            this.lblSSN.Text = "200-14-3987";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblEmail.Location = new System.Drawing.Point(14, 208);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(142, 18);
            this.lblEmail.TabIndex = 77;
            this.lblEmail.Text = "smiths@yahoo.com";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblPhone.Location = new System.Drawing.Point(14, 188);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(98, 18);
            this.lblPhone.TabIndex = 76;
            this.lblPhone.Text = "814-393-2500";
            // 
            // lblAddressCSZ
            // 
            this.lblAddressCSZ.AutoSize = true;
            this.lblAddressCSZ.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblAddressCSZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblAddressCSZ.Location = new System.Drawing.Point(14, 80);
            this.lblAddressCSZ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddressCSZ.Name = "lblAddressCSZ";
            this.lblAddressCSZ.Size = new System.Drawing.Size(126, 18);
            this.lblAddressCSZ.TabIndex = 75;
            this.lblAddressCSZ.Text = "Clarion, PA 16214";
            // 
            // lblAddressSt
            // 
            this.lblAddressSt.AutoSize = true;
            this.lblAddressSt.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblAddressSt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblAddressSt.Location = new System.Drawing.Point(14, 61);
            this.lblAddressSt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddressSt.Name = "lblAddressSt";
            this.lblAddressSt.Size = new System.Drawing.Size(111, 18);
            this.lblAddressSt.TabIndex = 74;
            this.lblAddressSt.Text = "123 Main Street";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblName.Location = new System.Drawing.Point(14, 22);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(140, 18);
            this.lblName.TabIndex = 73;
            this.lblName.Text = "Joe and Joan Smith";
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(1139, 413);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(50, 17);
            this.lblTotal.TabIndex = 86;
            this.lblTotal.Text = "Total:";
            // 
            // JobScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1559, 667);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblParent);
            this.Controls.Add(this.lblBirthdate);
            this.Controls.Add(this.lblCounty);
            this.Controls.Add(this.lblSchool);
            this.Controls.Add(this.lblChar);
            this.Controls.Add(this.lbxChar);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblSSN);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblAddressCSZ);
            this.Controls.Add(this.lblAddressSt);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.cmboStaff);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.rtbNotes);
            this.Controls.Add(this.txtSubtract);
            this.Controls.Add(this.lblSubtractTime);
            this.Controls.Add(this.btnEditTime);
            this.Controls.Add(this.lblAddTime);
            this.Controls.Add(this.txtAddTime);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnTimer);
            this.Controls.Add(this.dgvTime);
            this.Controls.Add(this.lblStaff);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.dgvFees);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnEditClient);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.DataGridView dgvFees;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblStaff;
        private System.Windows.Forms.DataGridView dgvTime;
        private System.Windows.Forms.TextBox txtSubtract;
        private System.Windows.Forms.Label lblSubtractTime;
        private System.Windows.Forms.Button btnEditTime;
        private System.Windows.Forms.Label lblAddTime;
        private System.Windows.Forms.TextBox txtAddTime;
        private System.Windows.Forms.Button btnTimer;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.RichTextBox rtbNotes;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeLength;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartedTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndedTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desc;
        private System.Windows.Forms.ComboBox cmboStaff;
        private System.Windows.Forms.Label lblParent;
        private System.Windows.Forms.Label lblBirthdate;
        private System.Windows.Forms.Label lblCounty;
        private System.Windows.Forms.Label lblSchool;
        private System.Windows.Forms.Label lblChar;
        private System.Windows.Forms.ListBox lbxChar;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblSSN;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblAddressCSZ;
        private System.Windows.Forms.Label lblAddressSt;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewComboBoxColumn cboService;
        private System.Windows.Forms.DataGridViewComboBoxColumn cboCharacteristics;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCharCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCharMultiplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtMiniTotal;
    }
}