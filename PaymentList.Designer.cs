namespace GrenciCPA
{
    partial class PaymentList
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
            this.grenciDBDataSet = new GrenciCPA.GrenciDBDataSet();
            this.pAYMENT_TABLEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pAYMENT_TABLETableAdapter = new GrenciCPA.GrenciDBDataSetTableAdapters.PAYMENT_TABLETableAdapter();
            this.tableAdapterManager = new GrenciCPA.GrenciDBDataSetTableAdapters.TableAdapterManager();
            this.pAYMENT_TABLEDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grenciDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAYMENT_TABLEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAYMENT_TABLEDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // grenciDBDataSet
            // 
            this.grenciDBDataSet.DataSetName = "GrenciDBDataSet";
            this.grenciDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pAYMENT_TABLEBindingSource
            // 
            this.pAYMENT_TABLEBindingSource.DataMember = "PAYMENT_TABLE";
            this.pAYMENT_TABLEBindingSource.DataSource = this.grenciDBDataSet;
            // 
            // pAYMENT_TABLETableAdapter
            // 
            this.pAYMENT_TABLETableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CHARACTERISTIC_TABLETableAdapter = null;
            this.tableAdapterManager.CLIENT_TABLETableAdapter = null;
            this.tableAdapterManager.CTC_TABLETableAdapter = null;
            this.tableAdapterManager.INVOICE_TABLETableAdapter = null;
            this.tableAdapterManager.JOB_COMPONENT_TABLETableAdapter = null;
            this.tableAdapterManager.JOB_TABLETableAdapter = null;
            this.tableAdapterManager.PAYMENT_TABLETableAdapter = this.pAYMENT_TABLETableAdapter;
            this.tableAdapterManager.SERVICE_TABLETableAdapter = null;
            this.tableAdapterManager.STAFF_TABLETableAdapter = null;
            this.tableAdapterManager.TIME_TABLETableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GrenciCPA.GrenciDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pAYMENT_TABLEDataGridView
            // 
            this.pAYMENT_TABLEDataGridView.AutoGenerateColumns = false;
            this.pAYMENT_TABLEDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pAYMENT_TABLEDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.pAYMENT_TABLEDataGridView.DataSource = this.pAYMENT_TABLEBindingSource;
            this.pAYMENT_TABLEDataGridView.Location = new System.Drawing.Point(12, 26);
            this.pAYMENT_TABLEDataGridView.Name = "pAYMENT_TABLEDataGridView";
            this.pAYMENT_TABLEDataGridView.RowHeadersWidth = 51;
            this.pAYMENT_TABLEDataGridView.RowTemplate.Height = 24;
            this.pAYMENT_TABLEDataGridView.Size = new System.Drawing.Size(764, 378);
            this.pAYMENT_TABLEDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PAYMENT_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "PAYMENT_ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CLIENT_ID";
            this.dataGridViewTextBoxColumn2.HeaderText = "CLIENT_ID";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PAYMENT_TYPE";
            this.dataGridViewTextBoxColumn3.HeaderText = "PAYMENT_TYPE";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PAYMENT_AMOUNT";
            this.dataGridViewTextBoxColumn4.HeaderText = "PAYMENT_AMOUNT";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DATE_PAID";
            this.dataGridViewTextBoxColumn5.HeaderText = "DATE_PAID";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // PaymentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pAYMENT_TABLEDataGridView);
            this.Name = "PaymentList";
            this.Text = "PaymentList";
            this.Load += new System.EventHandler(this.PaymentList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grenciDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAYMENT_TABLEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAYMENT_TABLEDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GrenciDBDataSet grenciDBDataSet;
        private System.Windows.Forms.BindingSource pAYMENT_TABLEBindingSource;
        private GrenciDBDataSetTableAdapters.PAYMENT_TABLETableAdapter pAYMENT_TABLETableAdapter;
        private GrenciDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView pAYMENT_TABLEDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}