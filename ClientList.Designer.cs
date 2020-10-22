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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientList));
            this.btnAddClient = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClientView = new System.Windows.Forms.Button();
            this.cbxUnassigned = new System.Windows.Forms.CheckBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cbxIsCompany = new System.Windows.Forms.CheckBox();
            this.grenciDBDataSet = new GrenciCPA.GrenciDBDataSet();
            this.grenciDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cLIENT_TABLEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cLIENT_TABLETableAdapter = new GrenciCPA.GrenciDBDataSetTableAdapters.CLIENT_TABLETableAdapter();
            this.tableAdapterManager = new GrenciCPA.GrenciDBDataSetTableAdapters.TableAdapterManager();
            this.cLIENT_TABLEDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.VIEW_CLIENT = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grenciDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grenciDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENT_TABLEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENT_TABLEDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddClient
            // 
            this.btnAddClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddClient.Location = new System.Drawing.Point(15, 692);
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
            this.btnClose.Location = new System.Drawing.Point(1344, 692);
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
            this.btnClientView.Location = new System.Drawing.Point(1177, 692);
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
            // grenciDBDataSet
            // 
            this.grenciDBDataSet.DataSetName = "GrenciDBDataSet";
            this.grenciDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grenciDBDataSetBindingSource
            // 
            this.grenciDBDataSetBindingSource.DataSource = this.grenciDBDataSet;
            this.grenciDBDataSetBindingSource.Position = 0;
            // 
            // cLIENT_TABLEBindingSource
            // 
            this.cLIENT_TABLEBindingSource.DataMember = "CLIENT_TABLE";
            this.cLIENT_TABLEBindingSource.DataSource = this.grenciDBDataSet;
            // 
            // cLIENT_TABLETableAdapter
            // 
            this.cLIENT_TABLETableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CHARACTERISTIC_TABLETableAdapter = null;
            this.tableAdapterManager.CLIENT_TABLETableAdapter = this.cLIENT_TABLETableAdapter;
            this.tableAdapterManager.CTC_TABLETableAdapter = null;
            this.tableAdapterManager.INVOICE_TABLETableAdapter = null;
            this.tableAdapterManager.JOB_COMPONENT_TABLETableAdapter = null;
            this.tableAdapterManager.JOB_TABLETableAdapter = null;
            this.tableAdapterManager.PAYMENT_TABLETableAdapter = null;
            this.tableAdapterManager.SERVICE_TABLETableAdapter = null;
            this.tableAdapterManager.STAFF_TABLETableAdapter = null;
            this.tableAdapterManager.TIME_TABLETableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GrenciCPA.GrenciDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cLIENT_TABLEDataGridView
            // 
            this.cLIENT_TABLEDataGridView.AllowUserToAddRows = false;
            this.cLIENT_TABLEDataGridView.AllowUserToDeleteRows = false;
            this.cLIENT_TABLEDataGridView.AllowUserToOrderColumns = true;
            this.cLIENT_TABLEDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cLIENT_TABLEDataGridView.AutoGenerateColumns = false;
            this.cLIENT_TABLEDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cLIENT_TABLEDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewCheckBoxColumn2,
            this.VIEW_CLIENT,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14});
            this.cLIENT_TABLEDataGridView.DataSource = this.cLIENT_TABLEBindingSource;
            this.cLIENT_TABLEDataGridView.Location = new System.Drawing.Point(15, 52);
            this.cLIENT_TABLEDataGridView.Name = "cLIENT_TABLEDataGridView";
            this.cLIENT_TABLEDataGridView.ReadOnly = true;
            this.cLIENT_TABLEDataGridView.RowHeadersWidth = 51;
            this.cLIENT_TABLEDataGridView.RowTemplate.Height = 24;
            this.cLIENT_TABLEDataGridView.Size = new System.Drawing.Size(1447, 613);
            this.cLIENT_TABLEDataGridView.TabIndex = 25;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CLIENT_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "CLIENT_ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "ACTIVE";
            this.dataGridViewCheckBoxColumn2.HeaderText = "ACTIVE";
            this.dataGridViewCheckBoxColumn2.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            this.dataGridViewCheckBoxColumn2.ReadOnly = true;
            this.dataGridViewCheckBoxColumn2.Width = 125;
            // 
            // VIEW_CLIENT
            // 
            this.VIEW_CLIENT.DataPropertyName = "CLIENT_ID";
            this.VIEW_CLIENT.HeaderText = "View Client";
            this.VIEW_CLIENT.MinimumWidth = 6;
            this.VIEW_CLIENT.Name = "VIEW_CLIENT";
            this.VIEW_CLIENT.ReadOnly = true;
            this.VIEW_CLIENT.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FIRST_NAME";
            this.dataGridViewTextBoxColumn2.HeaderText = "FIRST_NAME";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "LAST_NAME";
            this.dataGridViewTextBoxColumn3.HeaderText = "LAST_NAME";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ST_ADDRESS";
            this.dataGridViewTextBoxColumn4.HeaderText = "ST_ADDRESS";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CITY";
            this.dataGridViewTextBoxColumn5.HeaderText = "CITY";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "STATE_AB";
            this.dataGridViewTextBoxColumn6.HeaderText = "STATE_AB";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ZIP";
            this.dataGridViewTextBoxColumn7.HeaderText = "ZIP";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "EMAIL";
            this.dataGridViewTextBoxColumn8.HeaderText = "EMAIL";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "PHONE";
            this.dataGridViewTextBoxColumn9.HeaderText = "PHONE";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "IS_BUSINESS";
            this.dataGridViewCheckBoxColumn1.HeaderText = "IS_BUSINESS";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "NOTES";
            this.dataGridViewTextBoxColumn11.HeaderText = "NOTES";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 125;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "COMPANY_NAME";
            this.dataGridViewTextBoxColumn12.HeaderText = "COMPANY_NAME";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 125;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "PARENT_CLIENT";
            this.dataGridViewTextBoxColumn13.HeaderText = "PARENT_CLIENT";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Width = 125;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "OWED_BALANCE";
            this.dataGridViewTextBoxColumn14.HeaderText = "OWED_BALANCE";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Width = 125;
            // 
            // ClientList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1494, 761);
            this.Controls.Add(this.cLIENT_TABLEDataGridView);
            this.Controls.Add(this.cbxIsCompany);
            this.Controls.Add(this.cbxUnassigned);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnClientView);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddClient);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClientList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientList";
            this.Load += new System.EventHandler(this.ClientList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grenciDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grenciDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENT_TABLEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENT_TABLEDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClientView;
        private System.Windows.Forms.CheckBox cbxUnassigned;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.CheckBox cbxIsCompany;
        private GrenciDBDataSet grenciDBDataSet;
        private System.Windows.Forms.BindingSource grenciDBDataSetBindingSource;
        private System.Windows.Forms.BindingSource cLIENT_TABLEBindingSource;
        private GrenciDBDataSetTableAdapters.CLIENT_TABLETableAdapter cLIENT_TABLETableAdapter;
        private GrenciDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView cLIENT_TABLEDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewButtonColumn VIEW_CLIENT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
    }
}