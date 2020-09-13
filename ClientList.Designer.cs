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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientList));
            this.dgvClients = new System.Windows.Forms.DataGridView();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClientView = new System.Windows.Forms.Button();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.View = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Invoices = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Jobs = new System.Windows.Forms.DataGridViewButtonColumn();
            this.NewJob = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cbxIsCompany = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClients
            // 
            this.dgvClients.AllowUserToAddRows = false;
            this.dgvClients.AllowUserToDeleteRows = false;
            this.dgvClients.AllowUserToOrderColumns = true;
            this.dgvClients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LastName,
            this.FirstName,
            this.Company,
            this.Address,
            this.City,
            this.State,
            this.Contact,
            this.View,
            this.Invoices,
            this.Jobs,
            this.NewJob});
            this.dgvClients.Location = new System.Drawing.Point(12, 57);
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.ReadOnly = true;
            this.dgvClients.RowHeadersWidth = 51;
            this.dgvClients.RowTemplate.Height = 24;
            this.dgvClients.Size = new System.Drawing.Size(1213, 414);
            this.dgvClients.TabIndex = 0;
            this.dgvClients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClients_CellContentClick);
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(15, 13);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(100, 22);
            this.tbxSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(244, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search ";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnAddClient
            // 
            this.btnAddClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddClient.Location = new System.Drawing.Point(15, 502);
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
            this.btnClose.Location = new System.Drawing.Point(1093, 502);
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
            this.btnClientView.Location = new System.Drawing.Point(926, 502);
            this.btnClientView.Name = "btnClientView";
            this.btnClientView.Size = new System.Drawing.Size(161, 57);
            this.btnClientView.TabIndex = 6;
            this.btnClientView.Text = "Temp Client Info";
            this.btnClientView.UseVisualStyleBackColor = true;
            this.btnClientView.Click += new System.EventHandler(this.btnClientView_Click);
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Last Name";
            this.LastName.MinimumWidth = 6;
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            this.LastName.Width = 125;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "First Name";
            this.FirstName.MinimumWidth = 6;
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            this.FirstName.Width = 125;
            // 
            // Company
            // 
            this.Company.HeaderText = "Company";
            this.Company.MinimumWidth = 6;
            this.Company.Name = "Company";
            this.Company.ReadOnly = true;
            this.Company.Width = 125;
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Width = 125;
            // 
            // City
            // 
            this.City.HeaderText = "City";
            this.City.MinimumWidth = 6;
            this.City.Name = "City";
            this.City.ReadOnly = true;
            this.City.Width = 125;
            // 
            // State
            // 
            this.State.HeaderText = "State";
            this.State.MinimumWidth = 6;
            this.State.Name = "State";
            this.State.ReadOnly = true;
            this.State.Width = 50;
            // 
            // Contact
            // 
            this.Contact.HeaderText = "Perferred Contact";
            this.Contact.MinimumWidth = 6;
            this.Contact.Name = "Contact";
            this.Contact.ReadOnly = true;
            this.Contact.Width = 125;
            // 
            // View
            // 
            this.View.HeaderText = "View";
            this.View.MinimumWidth = 6;
            this.View.Name = "View";
            this.View.ReadOnly = true;
            this.View.Width = 90;
            // 
            // Invoices
            // 
            this.Invoices.HeaderText = "Invoices";
            this.Invoices.MinimumWidth = 6;
            this.Invoices.Name = "Invoices";
            this.Invoices.ReadOnly = true;
            this.Invoices.Width = 90;
            // 
            // Jobs
            // 
            this.Jobs.HeaderText = "Jobs";
            this.Jobs.MinimumWidth = 6;
            this.Jobs.Name = "Jobs";
            this.Jobs.ReadOnly = true;
            this.Jobs.Width = 90;
            // 
            // NewJob
            // 
            this.NewJob.HeaderText = "New Job";
            this.NewJob.MinimumWidth = 6;
            this.NewJob.Name = "NewJob";
            this.NewJob.ReadOnly = true;
            this.NewJob.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NewJob.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.NewJob.Width = 90;
            // 
            // cbxIsCompany
            // 
            this.cbxIsCompany.AutoSize = true;
            this.cbxIsCompany.Location = new System.Drawing.Point(149, 14);
            this.cbxIsCompany.Name = "cbxIsCompany";
            this.cbxIsCompany.Size = new System.Drawing.Size(89, 21);
            this.cbxIsCompany.TabIndex = 7;
            this.cbxIsCompany.Text = "Company";
            this.cbxIsCompany.UseVisualStyleBackColor = true;
            // 
            // ClientList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 571);
            this.Controls.Add(this.cbxIsCompany);
            this.Controls.Add(this.btnClientView);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddClient);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.dgvClients);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClientList";
            this.Text = "ClientList";
            this.Load += new System.EventHandler(this.ClientList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClients;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClientView;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Company;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn State;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contact;
        private System.Windows.Forms.DataGridViewButtonColumn View;
        private System.Windows.Forms.DataGridViewButtonColumn Invoices;
        private System.Windows.Forms.DataGridViewButtonColumn Jobs;
        private System.Windows.Forms.DataGridViewButtonColumn NewJob;
        private System.Windows.Forms.CheckBox cbxIsCompany;
    }
}