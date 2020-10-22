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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Globals));
            this.btnDone = new System.Windows.Forms.Button();
            this.lblServices = new System.Windows.Forms.Label();
            this.btnSaveFee = new System.Windows.Forms.Button();
            this.lblCharacteristics = new System.Windows.Forms.Label();
            this.grenciDBDataSet = new GrenciCPA.GrenciDBDataSet();
            this.cHARACTERISTIC_TABLEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cHARACTERISTIC_TABLETableAdapter = new GrenciCPA.GrenciDBDataSetTableAdapters.CHARACTERISTIC_TABLETableAdapter();
            this.tableAdapterManager = new GrenciCPA.GrenciDBDataSetTableAdapters.TableAdapterManager();
            this.cHARACTERISTIC_TABLEDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.sERVICE_TABLEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sERVICE_TABLETableAdapter = new GrenciCPA.GrenciDBDataSetTableAdapters.SERVICE_TABLETableAdapter();
            this.sERVICE_TABLEDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grenciDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHARACTERISTIC_TABLEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHARACTERISTIC_TABLEDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sERVICE_TABLEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sERVICE_TABLEDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDone
            // 
            this.btnDone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDone.Location = new System.Drawing.Point(1096, 603);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(137, 34);
            this.btnDone.TabIndex = 27;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // lblServices
            // 
            this.lblServices.AutoSize = true;
            this.lblServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServices.Location = new System.Drawing.Point(8, 9);
            this.lblServices.Name = "lblServices";
            this.lblServices.Size = new System.Drawing.Size(88, 20);
            this.lblServices.TabIndex = 17;
            this.lblServices.Text = "Services:";
            this.lblServices.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSaveFee
            // 
            this.btnSaveFee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSaveFee.Location = new System.Drawing.Point(937, 604);
            this.btnSaveFee.Name = "btnSaveFee";
            this.btnSaveFee.Size = new System.Drawing.Size(137, 33);
            this.btnSaveFee.TabIndex = 37;
            this.btnSaveFee.Text = "Save";
            this.btnSaveFee.UseVisualStyleBackColor = true;
            this.btnSaveFee.Click += new System.EventHandler(this.btnSaveFee_Click);
            // 
            // lblCharacteristics
            // 
            this.lblCharacteristics.AutoSize = true;
            this.lblCharacteristics.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharacteristics.Location = new System.Drawing.Point(531, 9);
            this.lblCharacteristics.Name = "lblCharacteristics";
            this.lblCharacteristics.Size = new System.Drawing.Size(144, 20);
            this.lblCharacteristics.TabIndex = 35;
            this.lblCharacteristics.Text = "Characteristics:";
            this.lblCharacteristics.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grenciDBDataSet
            // 
            this.grenciDBDataSet.DataSetName = "GrenciDBDataSet";
            this.grenciDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cHARACTERISTIC_TABLEBindingSource
            // 
            this.cHARACTERISTIC_TABLEBindingSource.DataMember = "CHARACTERISTIC_TABLE";
            this.cHARACTERISTIC_TABLEBindingSource.DataSource = this.grenciDBDataSet;
            // 
            // cHARACTERISTIC_TABLETableAdapter
            // 
            this.cHARACTERISTIC_TABLETableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CHARACTERISTIC_TABLETableAdapter = this.cHARACTERISTIC_TABLETableAdapter;
            this.tableAdapterManager.CLIENT_TABLETableAdapter = null;
            this.tableAdapterManager.CTC_TABLETableAdapter = null;
            this.tableAdapterManager.INVOICE_TABLETableAdapter = null;
            this.tableAdapterManager.JOB_COMPONENT_TABLETableAdapter = null;
            this.tableAdapterManager.JOB_TABLETableAdapter = null;
            this.tableAdapterManager.PAYMENT_TABLETableAdapter = null;
            this.tableAdapterManager.SERVICE_TABLETableAdapter = this.sERVICE_TABLETableAdapter;
            this.tableAdapterManager.STAFF_TABLETableAdapter = null;
            this.tableAdapterManager.TIME_TABLETableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GrenciCPA.GrenciDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cHARACTERISTIC_TABLEDataGridView
            // 
            this.cHARACTERISTIC_TABLEDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cHARACTERISTIC_TABLEDataGridView.AutoGenerateColumns = false;
            this.cHARACTERISTIC_TABLEDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cHARACTERISTIC_TABLEDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewCheckBoxColumn1});
            this.cHARACTERISTIC_TABLEDataGridView.DataSource = this.cHARACTERISTIC_TABLEBindingSource;
            this.cHARACTERISTIC_TABLEDataGridView.Location = new System.Drawing.Point(535, 32);
            this.cHARACTERISTIC_TABLEDataGridView.Name = "cHARACTERISTIC_TABLEDataGridView";
            this.cHARACTERISTIC_TABLEDataGridView.RowHeadersWidth = 51;
            this.cHARACTERISTIC_TABLEDataGridView.RowTemplate.Height = 24;
            this.cHARACTERISTIC_TABLEDataGridView.Size = new System.Drawing.Size(698, 540);
            this.cHARACTERISTIC_TABLEDataGridView.TabIndex = 38;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CHAR_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "CHAR_ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CHAR_NAME";
            this.dataGridViewTextBoxColumn2.HeaderText = "CHAR_NAME";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CHAR_COST";
            this.dataGridViewTextBoxColumn3.HeaderText = "CHAR_COST";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CHAR_MIN";
            this.dataGridViewTextBoxColumn4.HeaderText = "CHAR_MIN";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ASSOCIATED_SERVICE";
            this.dataGridViewTextBoxColumn5.HeaderText = "ASSOCIATED_SERVICE";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "CHAR_ACTIVE";
            this.dataGridViewCheckBoxColumn1.HeaderText = "CHAR_ACTIVE";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 125;
            // 
            // sERVICE_TABLEBindingSource
            // 
            this.sERVICE_TABLEBindingSource.DataMember = "SERVICE_TABLE";
            this.sERVICE_TABLEBindingSource.DataSource = this.grenciDBDataSet;
            // 
            // sERVICE_TABLETableAdapter
            // 
            this.sERVICE_TABLETableAdapter.ClearBeforeFill = true;
            // 
            // sERVICE_TABLEDataGridView
            // 
            this.sERVICE_TABLEDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.sERVICE_TABLEDataGridView.AutoGenerateColumns = false;
            this.sERVICE_TABLEDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sERVICE_TABLEDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewCheckBoxColumn2});
            this.sERVICE_TABLEDataGridView.DataSource = this.sERVICE_TABLEBindingSource;
            this.sERVICE_TABLEDataGridView.Location = new System.Drawing.Point(12, 32);
            this.sERVICE_TABLEDataGridView.Name = "sERVICE_TABLEDataGridView";
            this.sERVICE_TABLEDataGridView.RowHeadersWidth = 51;
            this.sERVICE_TABLEDataGridView.RowTemplate.Height = 24;
            this.sERVICE_TABLEDataGridView.Size = new System.Drawing.Size(502, 540);
            this.sERVICE_TABLEDataGridView.TabIndex = 38;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "SERV_ID";
            this.dataGridViewTextBoxColumn6.HeaderText = "SERV_ID";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "SERV_NAME";
            this.dataGridViewTextBoxColumn7.HeaderText = "SERV_NAME";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "SERV_SENTENCE";
            this.dataGridViewTextBoxColumn8.HeaderText = "SERV_SENTENCE";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "SERV_ACTIVE";
            this.dataGridViewCheckBoxColumn2.HeaderText = "SERV_ACTIVE";
            this.dataGridViewCheckBoxColumn2.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            this.dataGridViewCheckBoxColumn2.Width = 125;
            // 
            // Globals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 649);
            this.Controls.Add(this.sERVICE_TABLEDataGridView);
            this.Controls.Add(this.cHARACTERISTIC_TABLEDataGridView);
            this.Controls.Add(this.btnSaveFee);
            this.Controls.Add(this.lblCharacteristics);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.lblServices);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Globals";
            this.Text = "Globals";
            this.Load += new System.EventHandler(this.Fees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grenciDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHARACTERISTIC_TABLEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHARACTERISTIC_TABLEDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sERVICE_TABLEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sERVICE_TABLEDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Label lblServices;
        private System.Windows.Forms.Button btnSaveFee;
        private System.Windows.Forms.Label lblCharacteristics;
        private GrenciDBDataSet grenciDBDataSet;
        private System.Windows.Forms.BindingSource cHARACTERISTIC_TABLEBindingSource;
        private GrenciDBDataSetTableAdapters.CHARACTERISTIC_TABLETableAdapter cHARACTERISTIC_TABLETableAdapter;
        private GrenciDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private GrenciDBDataSetTableAdapters.SERVICE_TABLETableAdapter sERVICE_TABLETableAdapter;
        private System.Windows.Forms.DataGridView cHARACTERISTIC_TABLEDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.BindingSource sERVICE_TABLEBindingSource;
        private System.Windows.Forms.DataGridView sERVICE_TABLEDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
    }
}