namespace GrenciCPA
{
    partial class StaffSelect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffSelect));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAddEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Dr. Grenci",
            "Mrs. Grenci"});
            this.comboBox1.Location = new System.Drawing.Point(34, 50);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(234, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "Choose Staff";
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSelect.Location = new System.Drawing.Point(158, 106);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(133, 49);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnClose.Location = new System.Drawing.Point(158, 161);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(134, 43);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAddEdit
            // 
            this.btnAddEdit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAddEdit.Location = new System.Drawing.Point(12, 106);
            this.btnAddEdit.Name = "btnAddEdit";
            this.btnAddEdit.Size = new System.Drawing.Size(127, 49);
            this.btnAddEdit.TabIndex = 3;
            this.btnAddEdit.Text = "Add/Edit Staff";
            this.btnAddEdit.UseVisualStyleBackColor = true;
            this.btnAddEdit.Click += new System.EventHandler(this.btnAddEdit_Click);
            // 
            // StaffSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 216);
            this.Controls.Add(this.btnAddEdit);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.comboBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StaffSelect";
            this.Text = "StaffSelect";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAddEdit;
    }
}