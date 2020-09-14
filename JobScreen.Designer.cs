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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JobScreen));
            this.button3 = new System.Windows.Forms.Button();
            this.rtbNotes = new System.Windows.Forms.RichTextBox();
            this.btnEditClient = new System.Windows.Forms.Button();
            this.lblSSN = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblAddressCSZ = new System.Windows.Forms.Label();
            this.lblAddressSt = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.dgvFees = new System.Windows.Forms.DataGridView();
            this.btnComplete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblCurrentTime = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.cmboAddTime = new System.Windows.Forms.ComboBox();
            this.lblAddTime = new System.Windows.Forms.Label();
            this.btnTimer = new System.Windows.Forms.Button();
            this.txbOverride = new System.Windows.Forms.TextBox();
            this.lblOverride = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblCatagory = new System.Windows.Forms.Label();
            this.dgvTime = new System.Windows.Forms.DataGridView();
            this.lblStaff = new System.Windows.Forms.Label();
            this.btnClient = new System.Windows.Forms.Button();
            this.lblNotes = new System.Windows.Forms.Label();
            this.FeeName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.FeeCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Multiplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MiniTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Started = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ended = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartedTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndedTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTime)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(1300, 602);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 53);
            this.button3.TabIndex = 28;
            this.button3.Text = "Close";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // rtbNotes
            // 
            this.rtbNotes.Location = new System.Drawing.Point(268, 44);
            this.rtbNotes.Margin = new System.Windows.Forms.Padding(4);
            this.rtbNotes.Name = "rtbNotes";
            this.rtbNotes.Size = new System.Drawing.Size(368, 140);
            this.rtbNotes.TabIndex = 23;
            this.rtbNotes.Text = "";
            // 
            // btnEditClient
            // 
            this.btnEditClient.Location = new System.Drawing.Point(12, 147);
            this.btnEditClient.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditClient.Name = "btnEditClient";
            this.btnEditClient.Size = new System.Drawing.Size(125, 28);
            this.btnEditClient.TabIndex = 22;
            this.btnEditClient.Text = "Edit Client Info";
            this.btnEditClient.UseVisualStyleBackColor = true;
            this.btnEditClient.Click += new System.EventHandler(this.btnEditClient_Click);
            // 
            // lblSSN
            // 
            this.lblSSN.AutoSize = true;
            this.lblSSN.Location = new System.Drawing.Point(15, 127);
            this.lblSSN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSSN.Name = "lblSSN";
            this.lblSSN.Size = new System.Drawing.Size(90, 17);
            this.lblSSN.TabIndex = 21;
            this.lblSSN.Text = "200-14-3987";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(15, 111);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(131, 17);
            this.lblEmail.TabIndex = 20;
            this.lblEmail.Text = "smiths@yahoo.com";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(15, 95);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(98, 17);
            this.lblPhone.TabIndex = 19;
            this.lblPhone.Text = "814-393-2500";
            // 
            // lblAddressCSZ
            // 
            this.lblAddressCSZ.AutoSize = true;
            this.lblAddressCSZ.Location = new System.Drawing.Point(15, 79);
            this.lblAddressCSZ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddressCSZ.Name = "lblAddressCSZ";
            this.lblAddressCSZ.Size = new System.Drawing.Size(122, 17);
            this.lblAddressCSZ.TabIndex = 18;
            this.lblAddressCSZ.Text = "Clarion, PA 16214";
            // 
            // lblAddressSt
            // 
            this.lblAddressSt.AutoSize = true;
            this.lblAddressSt.Location = new System.Drawing.Point(15, 63);
            this.lblAddressSt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddressSt.Name = "lblAddressSt";
            this.lblAddressSt.Size = new System.Drawing.Size(108, 17);
            this.lblAddressSt.TabIndex = 17;
            this.lblAddressSt.Text = "123 Main Street";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(15, 47);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(133, 17);
            this.lblName.TabIndex = 16;
            this.lblName.Text = "Joe and Joan Smith";
            // 
            // dgvFees
            // 
            this.dgvFees.AllowUserToOrderColumns = true;
            this.dgvFees.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvFees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FeeName,
            this.FeeCost,
            this.Multiplier,
            this.MiniTotal,
            this.Started,
            this.Ended});
            this.dgvFees.Location = new System.Drawing.Point(8, 200);
            this.dgvFees.Name = "dgvFees";
            this.dgvFees.RowHeadersWidth = 51;
            this.dgvFees.RowTemplate.Height = 24;
            this.dgvFees.Size = new System.Drawing.Size(762, 428);
            this.dgvFees.TabIndex = 29;
            this.dgvFees.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFees_CellContentClick);
            // 
            // btnComplete
            // 
            this.btnComplete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnComplete.Location = new System.Drawing.Point(1300, 484);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(103, 53);
            this.btnComplete.TabIndex = 30;
            this.btnComplete.Text = "Complete";
            this.btnComplete.UseVisualStyleBackColor = true;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(1300, 543);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(103, 53);
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // lblCurrentTime
            // 
            this.lblCurrentTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurrentTime.AutoSize = true;
            this.lblCurrentTime.Location = new System.Drawing.Point(1024, 336);
            this.lblCurrentTime.Name = "lblCurrentTime";
            this.lblCurrentTime.Size = new System.Drawing.Size(0, 17);
            this.lblCurrentTime.TabIndex = 36;
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(829, 336);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(56, 20);
            this.lblTime.TabIndex = 35;
            this.lblTime.Text = "Time:";
            // 
            // cmboAddTime
            // 
            this.cmboAddTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmboAddTime.FormattingEnabled = true;
            this.cmboAddTime.Items.AddRange(new object[] {
            "10 minutes",
            "20 minutes",
            "30 minutes",
            "40 minutes",
            "50 minutes",
            "1 hour"});
            this.cmboAddTime.Location = new System.Drawing.Point(909, 422);
            this.cmboAddTime.Name = "cmboAddTime";
            this.cmboAddTime.Size = new System.Drawing.Size(60, 24);
            this.cmboAddTime.TabIndex = 34;
            // 
            // lblAddTime
            // 
            this.lblAddTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAddTime.AutoSize = true;
            this.lblAddTime.Location = new System.Drawing.Point(838, 425);
            this.lblAddTime.Name = "lblAddTime";
            this.lblAddTime.Size = new System.Drawing.Size(72, 17);
            this.lblAddTime.TabIndex = 33;
            this.lblAddTime.Text = "Add Time:";
            // 
            // btnTimer
            // 
            this.btnTimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimer.Location = new System.Drawing.Point(833, 359);
            this.btnTimer.Name = "btnTimer";
            this.btnTimer.Size = new System.Drawing.Size(107, 47);
            this.btnTimer.TabIndex = 32;
            this.btnTimer.Text = "Start Timer";
            this.btnTimer.UseVisualStyleBackColor = true;
            this.btnTimer.Click += new System.EventHandler(this.btnTimer_Click);
            // 
            // txbOverride
            // 
            this.txbOverride.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txbOverride.Location = new System.Drawing.Point(909, 455);
            this.txbOverride.Name = "txbOverride";
            this.txbOverride.Size = new System.Drawing.Size(60, 22);
            this.txbOverride.TabIndex = 37;
            // 
            // lblOverride
            // 
            this.lblOverride.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOverride.AutoSize = true;
            this.lblOverride.Location = new System.Drawing.Point(838, 458);
            this.lblOverride.Name = "lblOverride";
            this.lblOverride.Size = new System.Drawing.Size(63, 17);
            this.lblOverride.TabIndex = 38;
            this.lblOverride.Text = "Override";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(1019, 425);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 43);
            this.button1.TabIndex = 39;
            this.button1.Text = "Add/Override";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblCatagory
            // 
            this.lblCatagory.AutoSize = true;
            this.lblCatagory.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatagory.Location = new System.Drawing.Point(14, 9);
            this.lblCatagory.Name = "lblCatagory";
            this.lblCatagory.Size = new System.Drawing.Size(152, 17);
            this.lblCatagory.TabIndex = 40;
            this.lblCatagory.Text = "Catagory: Individual";
            // 
            // dgvTime
            // 
            this.dgvTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTime.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TimeLength,
            this.StartedTime,
            this.EndedTime,
            this.Desc});
            this.dgvTime.Location = new System.Drawing.Point(833, 12);
            this.dgvTime.Name = "dgvTime";
            this.dgvTime.RowHeadersWidth = 51;
            this.dgvTime.RowTemplate.Height = 24;
            this.dgvTime.Size = new System.Drawing.Size(570, 309);
            this.dgvTime.TabIndex = 42;
            // 
            // lblStaff
            // 
            this.lblStaff.AutoSize = true;
            this.lblStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaff.Location = new System.Drawing.Point(15, 641);
            this.lblStaff.Name = "lblStaff";
            this.lblStaff.Size = new System.Drawing.Size(220, 17);
            this.lblStaff.TabIndex = 43;
            this.lblStaff.Text = "Assigned To: Anthony Grenci";
            // 
            // btnClient
            // 
            this.btnClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClient.Location = new System.Drawing.Point(953, 582);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(113, 46);
            this.btnClient.TabIndex = 44;
            this.btnClient.Text = "Calculate";
            this.btnClient.UseVisualStyleBackColor = true;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(265, 23);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(49, 17);
            this.lblNotes.TabIndex = 45;
            this.lblNotes.Text = "Notes:";
            // 
            // FeeName
            // 
            this.FeeName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.FeeName.DefaultCellStyle = dataGridViewCellStyle1;
            this.FeeName.FillWeight = 125F;
            this.FeeName.HeaderText = "Service";
            this.FeeName.Items.AddRange(new object[] {
            "Income Taxes",
            "Payroll"});
            this.FeeName.MinimumWidth = 6;
            this.FeeName.Name = "FeeName";
            this.FeeName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.FeeName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.FeeName.Width = 84;
            // 
            // FeeCost
            // 
            this.FeeCost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.FeeCost.DefaultCellStyle = dataGridViewCellStyle2;
            this.FeeCost.FillWeight = 125F;
            this.FeeCost.HeaderText = "Cost";
            this.FeeCost.MinimumWidth = 50;
            this.FeeCost.Name = "FeeCost";
            // 
            // Multiplier
            // 
            this.Multiplier.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Multiplier.HeaderText = "Multiplier";
            this.Multiplier.MinimumWidth = 20;
            this.Multiplier.Name = "Multiplier";
            // 
            // MiniTotal
            // 
            this.MiniTotal.HeaderText = "Minimum/Total";
            this.MiniTotal.MinimumWidth = 6;
            this.MiniTotal.Name = "MiniTotal";
            this.MiniTotal.Width = 90;
            // 
            // Started
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "t";
            dataGridViewCellStyle3.NullValue = null;
            this.Started.DefaultCellStyle = dataGridViewCellStyle3;
            this.Started.FillWeight = 125F;
            this.Started.HeaderText = "Started";
            this.Started.MinimumWidth = 6;
            this.Started.Name = "Started";
            this.Started.Width = 90;
            // 
            // Ended
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "t";
            dataGridViewCellStyle4.NullValue = null;
            this.Ended.DefaultCellStyle = dataGridViewCellStyle4;
            this.Ended.FillWeight = 125F;
            this.Ended.HeaderText = "Ended";
            this.Ended.MinimumWidth = 6;
            this.Ended.Name = "Ended";
            this.Ended.Width = 90;
            // 
            // TimeLength
            // 
            this.TimeLength.DataPropertyName = "Time";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Format = "g";
            dataGridViewCellStyle5.NullValue = null;
            this.TimeLength.DefaultCellStyle = dataGridViewCellStyle5;
            this.TimeLength.HeaderText = "Time";
            this.TimeLength.MinimumWidth = 6;
            this.TimeLength.Name = "TimeLength";
            this.TimeLength.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TimeLength.Width = 70;
            // 
            // StartedTime
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Format = "t";
            dataGridViewCellStyle6.NullValue = null;
            this.StartedTime.DefaultCellStyle = dataGridViewCellStyle6;
            this.StartedTime.HeaderText = "Start";
            this.StartedTime.MinimumWidth = 6;
            this.StartedTime.Name = "StartedTime";
            this.StartedTime.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.StartedTime.Width = 110;
            // 
            // EndedTime
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Format = "t";
            dataGridViewCellStyle7.NullValue = null;
            this.EndedTime.DefaultCellStyle = dataGridViewCellStyle7;
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
            // JobScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1415, 667);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.btnClient);
            this.Controls.Add(this.lblStaff);
            this.Controls.Add(this.dgvTime);
            this.Controls.Add(this.lblCatagory);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblOverride);
            this.Controls.Add(this.txbOverride);
            this.Controls.Add(this.lblCurrentTime);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.cmboAddTime);
            this.Controls.Add(this.lblAddTime);
            this.Controls.Add(this.btnTimer);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.dgvFees);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.rtbNotes);
            this.Controls.Add(this.btnEditClient);
            this.Controls.Add(this.lblSSN);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblAddressCSZ);
            this.Controls.Add(this.lblAddressSt);
            this.Controls.Add(this.lblName);
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
        private System.Windows.Forms.RichTextBox rtbNotes;
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
        private System.Windows.Forms.Label lblCurrentTime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.ComboBox cmboAddTime;
        private System.Windows.Forms.Label lblAddTime;
        private System.Windows.Forms.Button btnTimer;
        private System.Windows.Forms.TextBox txbOverride;
        private System.Windows.Forms.Label lblOverride;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblCatagory;
        private System.Windows.Forms.DataGridView dgvTime;
        private System.Windows.Forms.Label lblStaff;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.DataGridViewComboBoxColumn FeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FeeCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Multiplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn MiniTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Started;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ended;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeLength;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartedTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndedTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desc;
    }
}