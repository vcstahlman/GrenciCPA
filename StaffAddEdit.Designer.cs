namespace GrenciCPA
{
    partial class StaffAddEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffAddEdit));
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tbxFirst = new System.Windows.Forms.TextBox();
            this.tbxLast = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSave.Location = new System.Drawing.Point(12, 150);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(133, 55);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnClose.Location = new System.Drawing.Point(161, 150);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(145, 55);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tbxFirst
            // 
            this.tbxFirst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tbxFirst.Location = new System.Drawing.Point(110, 12);
            this.tbxFirst.Name = "tbxFirst";
            this.tbxFirst.Size = new System.Drawing.Size(196, 22);
            this.tbxFirst.TabIndex = 50;
            // 
            // tbxLast
            // 
            this.tbxLast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tbxLast.Location = new System.Drawing.Point(110, 44);
            this.tbxLast.Name = "tbxLast";
            this.tbxLast.Size = new System.Drawing.Size(196, 22);
            this.tbxLast.TabIndex = 49;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBox3.Location = new System.Drawing.Point(110, 102);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(196, 22);
            this.textBox3.TabIndex = 42;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 107);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 17);
            this.label11.TabIndex = 38;
            this.label11.Text = "Email";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "First Name";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(110, 72);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(196, 24);
            this.comboBox1.TabIndex = 51;
            // 
            // lblPosition
            // 
            this.lblPosition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(15, 75);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(58, 17);
            this.lblPosition.TabIndex = 52;
            this.lblPosition.Text = "Position";
            // 
            // StaffAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 217);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tbxFirst);
            this.Controls.Add(this.tbxLast);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StaffAddEdit";
            this.Text = "StaffAddEdit";
            this.Load += new System.EventHandler(this.StaffAddEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox tbxFirst;
        private System.Windows.Forms.TextBox tbxLast;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblPosition;
    }
}