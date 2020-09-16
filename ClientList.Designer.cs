namespace GrenciCPA
{
    partial class ClientList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientList));
            this.dgvClients = new System.Windows.Forms.DataGridView();
            this.Active = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateZip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.View = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Invoices = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClientView = new System.Windows.Forms.Button();
            this.cbxUnassigned = new System.Windows.Forms.CheckBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cbxIsCompany = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClients
            // 
            this.dgvClients.AllowUserToAddRows = false;
            this.dgvClients.AllowUserToDeleteRows = false;
            this.dgvClients.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvClients.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Active,
            this.LastName,
            this.FirstName,
            this.txtCategory,
            this.txtCompany,
            this.Address,
            this.City,
            this.stateZip,
            this.Contact,
            this.View,
            this.Invoices});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClients.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvClients.Location = new System.Drawing.Point(12, 57);
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.ReadOnly = true;
            this.dgvClients.RowHeadersWidth = 51;
            this.dgvClients.RowTemplate.Height = 24;
            this.dgvClients.Size = new System.Drawing.Size(1677, 561);
            this.dgvClients.TabIndex = 0;
            this.dgvClients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClients_CellContentClick);
            // 
            // Active
            // 
            this.Active.DataPropertyName = "Active";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.Active.DefaultCellStyle = dataGridViewCellStyle2;
            this.Active.FillWeight = 60F;
            this.Active.HeaderText = "Active";
            this.Active.MinimumWidth = 60;
            this.Active.Name = "Active";
            this.Active.ReadOnly = true;
            this.Active.Width = 60;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "Last Name";
            this.LastName.FillWeight = 125F;
            this.LastName.HeaderText = "Last Name";
            this.LastName.MinimumWidth = 125;
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            this.LastName.Width = 125;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.FillWeight = 125F;
            this.FirstName.HeaderText = "First Name";
            this.FirstName.MinimumWidth = 125;
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            this.FirstName.Width = 125;
            // 
            // txtCategory
            // 
            this.txtCategory.DataPropertyName = "Category";
            this.txtCategory.FillWeight = 125F;
            this.txtCategory.HeaderText = "Category";
            this.txtCategory.MinimumWidth = 100;
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.ReadOnly = true;
            this.txtCategory.Width = 125;
            // 
            // txtCompany
            // 
            this.txtCompany.DataPropertyName = "Company";
            this.txtCompany.FillWeight = 140F;
            this.txtCompany.HeaderText = "Company";
            this.txtCompany.MinimumWidth = 100;
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.ReadOnly = true;
            this.txtCompany.Width = 140;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.FillWeight = 125F;
            this.Address.HeaderText = "Address";
            this.Address.MinimumWidth = 125;
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Width = 125;
            // 
            // City
            // 
            this.City.DataPropertyName = "City";
            this.City.FillWeight = 75F;
            this.City.HeaderText = "City";
            this.City.MinimumWidth = 75;
            this.City.Name = "City";
            this.City.ReadOnly = true;
            this.City.Width = 75;
            // 
            // stateZip
            // 
            this.stateZip.DataPropertyName = "StateZip";
            this.stateZip.FillWeight = 85F;
            this.stateZip.HeaderText = "State, Zip";
            this.stateZip.MinimumWidth = 85;
            this.stateZip.Name = "stateZip";
            this.stateZip.ReadOnly = true;
            this.stateZip.Width = 85;
            // 
            // Contact
            // 
            this.Contact.DataPropertyName = "PrefContact";
            this.Contact.FillWeight = 125F;
            this.Contact.HeaderText = "Perferred Contact";
            this.Contact.MinimumWidth = 100;
            this.Contact.Name = "Contact";
            this.Contact.ReadOnly = true;
            this.Contact.Width = 125;
            // 
            // View
            // 
            this.View.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.View.DataPropertyName = "ViewClient";
            this.View.HeaderText = "View";
            this.View.MinimumWidth = 100;
            this.View.Name = "View";
            this.View.ReadOnly = true;
            this.View.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.View.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Invoices
            // 
            this.Invoices.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Invoices.DataPropertyName = "ViewInvoices";
            this.Invoices.HeaderText = "Invoices";
            this.Invoices.MinimumWidth = 100;
            this.Invoices.Name = "Invoices";
            this.Invoices.ReadOnly = true;
            // 
            // btnAddClient
            // 
            this.btnAddClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddClient.Location = new System.Drawing.Point(15, 649);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(130, 57);
            this.btnAddClient.TabIndex = 4;
            this.btnAddClient.Text = "Add New Client";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(1557, 649);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(132, 57);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnClientView
            // 
            this.btnClientView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClientView.Location = new System.Drawing.Point(1390, 649);
            this.btnClientView.Name = "btnClientView";
            this.btnClientView.Size = new System.Drawing.Size(161, 57);
            this.btnClientView.TabIndex = 6;
            this.btnClientView.Text = "View Client";
            this.btnClientView.UseVisualStyleBackColor = true;
            this.btnClientView.Click += new System.EventHandler(this.btnClientView_Click);
            // 
            // cbxUnassigned
            // 
            this.cbxUnassigned.AutoSize = true;
            this.cbxUnassigned.Location = new System.Drawing.Point(246, 14);
            this.cbxUnassigned.Name = "cbxUnassigned";
            this.cbxUnassigned.Size = new System.Drawing.Size(105, 21);
            this.cbxUnassigned.TabIndex = 23;
            this.cbxUnassigned.Text = "Unassigned";
            this.cbxUnassigned.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(456, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(99, 37);
            this.btnSearch.TabIndex = 21;
            this.btnSearch.Text = "Search ";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(15, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(225, 22);
            this.txtSearch.TabIndex = 20;
            // 
            // cbxIsCompany
            // 
            this.cbxIsCompany.AutoSize = true;
            this.cbxIsCompany.Location = new System.Drawing.Point(357, 14);
            this.cbxIsCompany.Name = "cbxIsCompany";
            this.cbxIsCompany.Size = new System.Drawing.Size(89, 21);
            this.cbxIsCompany.TabIndex = 25;
            this.cbxIsCompany.Text = "Company";
            this.cbxIsCompany.UseVisualStyleBackColor = true;
            // 
            // ClientList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1707, 718);
            this.Controls.Add(this.cbxIsCompany);
            this.Controls.Add(this.cbxUnassigned);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnClientView);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddClient);
            this.Controls.Add(this.dgvClients);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClientList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientList";
            this.Load += new System.EventHandler(this.ClientList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClients;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClientView;
        private System.Windows.Forms.CheckBox cbxUnassigned;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.CheckBox cbxIsCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn Active;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateZip;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contact;
        private System.Windows.Forms.DataGridViewButtonColumn View;
        private System.Windows.Forms.DataGridViewButtonColumn Invoices;
    }
}