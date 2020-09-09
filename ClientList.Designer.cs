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
            this.dgvClients = new System.Windows.Forms.DataGridView();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CellPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.View = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Invoices = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Jobs = new System.Windows.Forms.DataGridViewButtonColumn();
            this.NewJob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClientView = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClients
            // 
            this.dgvClients.AllowUserToAddRows = false;
            this.dgvClients.AllowUserToDeleteRows = false;
            this.dgvClients.AllowUserToOrderColumns = true;
            this.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LastName,
            this.FirstName,
            this.Address,
            this.City,
            this.State,
            this.CellPhone,
            this.View,
            this.Invoices,
            this.Jobs,
            this.NewJob});
            this.dgvClients.Location = new System.Drawing.Point(12, 57);
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.ReadOnly = true;
            this.dgvClients.RowHeadersWidth = 51;
            this.dgvClients.RowTemplate.Height = 24;
            this.dgvClients.Size = new System.Drawing.Size(1013, 372);
            this.dgvClients.TabIndex = 0;
            this.dgvClients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClients_CellContentClick);
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
            // CellPhone
            // 
            this.CellPhone.HeaderText = "Cell Phone";
            this.CellPhone.MinimumWidth = 6;
            this.CellPhone.Name = "CellPhone";
            this.CellPhone.ReadOnly = true;
            this.CellPhone.Width = 125;
            // 
            // View
            // 
            this.View.HeaderText = "View";
            this.View.MinimumWidth = 6;
            this.View.Name = "View";
            this.View.ReadOnly = true;
            this.View.Width = 60;
            // 
            // Invoices
            // 
            this.Invoices.HeaderText = "Invoices";
            this.Invoices.MinimumWidth = 6;
            this.Invoices.Name = "Invoices";
            this.Invoices.ReadOnly = true;
            this.Invoices.Width = 60;
            // 
            // Jobs
            // 
            this.Jobs.HeaderText = "Jobs";
            this.Jobs.MinimumWidth = 6;
            this.Jobs.Name = "Jobs";
            this.Jobs.ReadOnly = true;
            this.Jobs.Width = 60;
            // 
            // NewJob
            // 
            this.NewJob.HeaderText = "New Job";
            this.NewJob.MinimumWidth = 6;
            this.NewJob.Name = "NewJob";
            this.NewJob.ReadOnly = true;
            this.NewJob.Width = 125;
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(12, 12);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(100, 22);
            this.tbxSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(127, 11);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search ";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnAddClient
            // 
            this.btnAddClient.Location = new System.Drawing.Point(15, 460);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(130, 57);
            this.btnAddClient.TabIndex = 4;
            this.btnAddClient.Text = "Add New Client";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(893, 460);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(132, 57);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnClientView
            // 
            this.btnClientView.Location = new System.Drawing.Point(716, 460);
            this.btnClientView.Name = "btnClientView";
            this.btnClientView.Size = new System.Drawing.Size(161, 57);
            this.btnClientView.TabIndex = 6;
            this.btnClientView.Text = "Temp Client Info";
            this.btnClientView.UseVisualStyleBackColor = true;
            this.btnClientView.Click += new System.EventHandler(this.btnClientView_Click);
            // 
            // ClientList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 529);
            this.Controls.Add(this.btnClientView);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddClient);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.dgvClients);
            this.Name = "ClientList";
            this.Text = "ClientList";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn State;
        private System.Windows.Forms.DataGridViewTextBoxColumn CellPhone;
        private System.Windows.Forms.DataGridViewButtonColumn View;
        private System.Windows.Forms.DataGridViewButtonColumn Invoices;
        private System.Windows.Forms.DataGridViewButtonColumn Jobs;
        private System.Windows.Forms.DataGridViewTextBoxColumn NewJob;
        private System.Windows.Forms.Button btnClientView;
    }
}