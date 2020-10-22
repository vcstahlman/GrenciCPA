namespace GrenciCPA
{
    partial class Invoices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Invoices));
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.cbxOverdue = new System.Windows.Forms.CheckBox();
            this.btnPayment = new System.Windows.Forms.Button();
            this.grenciDBDataSet = new GrenciCPA.GrenciDBDataSet();
            this.iNVOICE_TABLEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iNVOICE_TABLETableAdapter = new GrenciCPA.GrenciDBDataSetTableAdapters.INVOICE_TABLETableAdapter();
            this.tableAdapterManager = new GrenciCPA.GrenciDBDataSetTableAdapters.TableAdapterManager();
            this.iNVOICE_TABLEDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grenciDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNVOICE_TABLEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNVOICE_TABLEDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(1176, 466);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(132, 57);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(263, 14);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search ";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(12, 14);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(124, 22);
            this.tbxSearch.TabIndex = 7;
            // 
            // cbxOverdue
            // 
            this.cbxOverdue.AutoSize = true;
            this.cbxOverdue.Location = new System.Drawing.Point(142, 16);
            this.cbxOverdue.Name = "cbxOverdue";
            this.cbxOverdue.Size = new System.Drawing.Size(85, 21);
            this.cbxOverdue.TabIndex = 12;
            this.cbxOverdue.Text = "Overdue";
            this.cbxOverdue.UseVisualStyleBackColor = true;
            this.cbxOverdue.CheckedChanged += new System.EventHandler(this.cbxOverdue_CheckedChanged);
            // 
            // btnPayment
            // 
            this.btnPayment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPayment.Location = new System.Drawing.Point(1009, 466);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(126, 57);
            this.btnPayment.TabIndex = 14;
            this.btnPayment.Text = "make payment";
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // grenciDBDataSet
            // 
            this.grenciDBDataSet.DataSetName = "GrenciDBDataSet";
            this.grenciDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iNVOICE_TABLEBindingSource
            // 
            this.iNVOICE_TABLEBindingSource.DataMember = "INVOICE_TABLE";
            this.iNVOICE_TABLEBindingSource.DataSource = this.grenciDBDataSet;
            // 
            // iNVOICE_TABLETableAdapter
            // 
            this.iNVOICE_TABLETableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CHARACTERISTIC_TABLETableAdapter = null;
            this.tableAdapterManager.CLIENT_TABLETableAdapter = null;
            this.tableAdapterManager.CTC_TABLETableAdapter = null;
            this.tableAdapterManager.INVOICE_TABLETableAdapter = this.iNVOICE_TABLETableAdapter;
            this.tableAdapterManager.JOB_COMPONENT_TABLETableAdapter = null;
            this.tableAdapterManager.JOB_TABLETableAdapter = null;
            this.tableAdapterManager.PAYMENT_TABLETableAdapter = null;
            this.tableAdapterManager.SERVICE_TABLETableAdapter = null;
            this.tableAdapterManager.STAFF_TABLETableAdapter = null;
            this.tableAdapterManager.TIME_TABLETableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GrenciCPA.GrenciDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // iNVOICE_TABLEDataGridView
            // 
            this.iNVOICE_TABLEDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iNVOICE_TABLEDataGridView.AutoGenerateColumns = false;
            this.iNVOICE_TABLEDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.iNVOICE_TABLEDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.iNVOICE_TABLEDataGridView.DataSource = this.iNVOICE_TABLEBindingSource;
            this.iNVOICE_TABLEDataGridView.Location = new System.Drawing.Point(12, 43);
            this.iNVOICE_TABLEDataGridView.Name = "iNVOICE_TABLEDataGridView";
            this.iNVOICE_TABLEDataGridView.RowHeadersWidth = 51;
            this.iNVOICE_TABLEDataGridView.RowTemplate.Height = 24;
            this.iNVOICE_TABLEDataGridView.Size = new System.Drawing.Size(1296, 417);
            this.iNVOICE_TABLEDataGridView.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "INVOICE_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "INVOICE_ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "JOB_ID";
            this.dataGridViewTextBoxColumn2.HeaderText = "JOB_ID";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "AMOUNT_OWED";
            this.dataGridViewTextBoxColumn3.HeaderText = "AMOUNT_OWED";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "AMOUNT_PAID";
            this.dataGridViewTextBoxColumn4.HeaderText = "AMOUNT_PAID";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "INVOICE_TEXT";
            this.dataGridViewTextBoxColumn5.HeaderText = "INVOICE_TEXT";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "FILE_PATH";
            this.dataGridViewTextBoxColumn6.HeaderText = "FILE_PATH";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "DATE_SENT";
            this.dataGridViewTextBoxColumn7.HeaderText = "DATE_SENT";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // Invoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 539);
            this.Controls.Add(this.iNVOICE_TABLEDataGridView);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.cbxOverdue);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbxSearch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Invoices";
            this.Text = "Invoices";
            this.Load += new System.EventHandler(this.Invoices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grenciDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNVOICE_TABLEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNVOICE_TABLEDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.CheckBox cbxOverdue;
        private System.Windows.Forms.Button btnPayment;
        private GrenciDBDataSet grenciDBDataSet;
        private System.Windows.Forms.BindingSource iNVOICE_TABLEBindingSource;
        private GrenciDBDataSetTableAdapters.INVOICE_TABLETableAdapter iNVOICE_TABLETableAdapter;
        private GrenciDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView iNVOICE_TABLEDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}