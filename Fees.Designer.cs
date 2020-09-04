namespace GrenciCPA
{
    partial class Fees
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
            this.btnDone = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ServName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BaseFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSaveServ = new System.Windows.Forms.Button();
            this.btnSaveFee = new System.Windows.Forms.Button();
            this.dgvFees = new System.Windows.Forms.DataGridView();
            this.FeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BaseMutilpier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mininumOrAdd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FeeDisc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFees)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(882, 301);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(135, 47);
            this.btnDone.TabIndex = 27;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(580, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Services:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ServName,
            this.BaseFee,
            this.Description});
            this.dataGridView1.Location = new System.Drawing.Point(584, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(433, 213);
            this.dataGridView1.TabIndex = 32;
            // 
            // ServName
            // 
            this.ServName.HeaderText = "Name";
            this.ServName.MinimumWidth = 6;
            this.ServName.Name = "ServName";
            this.ServName.Width = 125;
            // 
            // BaseFee
            // 
            this.BaseFee.HeaderText = "Base Fee";
            this.BaseFee.MinimumWidth = 6;
            this.BaseFee.Name = "BaseFee";
            this.BaseFee.Width = 125;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.Width = 125;
            // 
            // btnSaveServ
            // 
            this.btnSaveServ.Location = new System.Drawing.Point(919, 248);
            this.btnSaveServ.Name = "btnSaveServ";
            this.btnSaveServ.Size = new System.Drawing.Size(98, 34);
            this.btnSaveServ.TabIndex = 34;
            this.btnSaveServ.Text = "Save";
            this.btnSaveServ.UseVisualStyleBackColor = true;
            // 
            // btnSaveFee
            // 
            this.btnSaveFee.Location = new System.Drawing.Point(477, 248);
            this.btnSaveFee.Name = "btnSaveFee";
            this.btnSaveFee.Size = new System.Drawing.Size(89, 34);
            this.btnSaveFee.TabIndex = 37;
            this.btnSaveFee.Text = "Save";
            this.btnSaveFee.UseVisualStyleBackColor = true;
            // 
            // dgvFees
            // 
            this.dgvFees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FeeName,
            this.BaseMutilpier,
            this.mininumOrAdd,
            this.FeeDisc});
            this.dgvFees.Location = new System.Drawing.Point(12, 29);
            this.dgvFees.Name = "dgvFees";
            this.dgvFees.RowHeadersWidth = 51;
            this.dgvFees.RowTemplate.Height = 24;
            this.dgvFees.Size = new System.Drawing.Size(554, 213);
            this.dgvFees.TabIndex = 36;
            // 
            // FeeName
            // 
            this.FeeName.HeaderText = "Name";
            this.FeeName.MinimumWidth = 6;
            this.FeeName.Name = "FeeName";
            this.FeeName.Width = 125;
            // 
            // BaseMutilpier
            // 
            this.BaseMutilpier.HeaderText = "Multilpier ";
            this.BaseMutilpier.MinimumWidth = 6;
            this.BaseMutilpier.Name = "BaseMutilpier";
            this.BaseMutilpier.Width = 125;
            // 
            // mininumOrAdd
            // 
            this.mininumOrAdd.HeaderText = "Minimum, or Base fee";
            this.mininumOrAdd.MinimumWidth = 6;
            this.mininumOrAdd.Name = "mininumOrAdd";
            this.mininumOrAdd.Width = 125;
            // 
            // FeeDisc
            // 
            this.FeeDisc.HeaderText = "Disctription";
            this.FeeDisc.MinimumWidth = 6;
            this.FeeDisc.Name = "FeeDisc";
            this.FeeDisc.Width = 125;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 35;
            this.label6.Text = "Fees:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Fees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 361);
            this.Controls.Add(this.btnSaveFee);
            this.Controls.Add(this.dgvFees);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSaveServ);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.label1);
            this.Name = "Fees";
            this.Text = "Fees";
            this.Load += new System.EventHandler(this.Fees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BaseFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.Button btnSaveServ;
        private System.Windows.Forms.Button btnSaveFee;
        private System.Windows.Forms.DataGridView dgvFees;
        private System.Windows.Forms.DataGridViewTextBoxColumn FeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BaseMutilpier;
        private System.Windows.Forms.DataGridViewTextBoxColumn mininumOrAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn FeeDisc;
        private System.Windows.Forms.Label label6;
    }
}