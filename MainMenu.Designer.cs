namespace GrenciCPA
{
    partial class MainMenu
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
            this.btnClients = new System.Windows.Forms.Button();
            this.btnJobs = new System.Windows.Forms.Button();
            this.btnInvoices = new System.Windows.Forms.Button();
            this.btnGlobals = new System.Windows.Forms.Button();
            this.btnStaff = new System.Windows.Forms.Button();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClients
            // 
            this.btnClients.Location = new System.Drawing.Point(12, 140);
            this.btnClients.Name = "btnClients";
            this.btnClients.Size = new System.Drawing.Size(110, 50);
            this.btnClients.TabIndex = 0;
            this.btnClients.Text = "Clients";
            this.btnClients.UseVisualStyleBackColor = true;
            this.btnClients.Click += new System.EventHandler(this.btnClients_Click);
            // 
            // btnJobs
            // 
            this.btnJobs.Location = new System.Drawing.Point(12, 34);
            this.btnJobs.Name = "btnJobs";
            this.btnJobs.Size = new System.Drawing.Size(110, 50);
            this.btnJobs.TabIndex = 1;
            this.btnJobs.Text = "Active Jobs";
            this.btnJobs.UseVisualStyleBackColor = true;
            this.btnJobs.Click += new System.EventHandler(this.btnJobs_Click);
            // 
            // btnInvoices
            // 
            this.btnInvoices.Location = new System.Drawing.Point(12, 259);
            this.btnInvoices.Name = "btnInvoices";
            this.btnInvoices.Size = new System.Drawing.Size(110, 50);
            this.btnInvoices.TabIndex = 2;
            this.btnInvoices.Text = "Invoices";
            this.btnInvoices.UseVisualStyleBackColor = true;
            this.btnInvoices.Click += new System.EventHandler(this.btnInvoices_Click);
            // 
            // btnGlobals
            // 
            this.btnGlobals.Location = new System.Drawing.Point(468, 140);
            this.btnGlobals.Name = "btnGlobals";
            this.btnGlobals.Size = new System.Drawing.Size(110, 50);
            this.btnGlobals.TabIndex = 3;
            this.btnGlobals.Text = "Globals";
            this.btnGlobals.UseVisualStyleBackColor = true;
            this.btnGlobals.Click += new System.EventHandler(this.btnGlobals_Click);
            // 
            // btnStaff
            // 
            this.btnStaff.Location = new System.Drawing.Point(468, 34);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(110, 50);
            this.btnStaff.TabIndex = 4;
            this.btnStaff.Text = "Staff";
            this.btnStaff.UseVisualStyleBackColor = true;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // pbxLogo
            // 
            this.pbxLogo.Image = global::GrenciCPA.Properties.Resources.AFG_Logo;
            this.pbxLogo.Location = new System.Drawing.Point(128, 34);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(325, 275);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogo.TabIndex = 5;
            this.pbxLogo.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 339);
            this.Controls.Add(this.pbxLogo);
            this.Controls.Add(this.btnStaff);
            this.Controls.Add(this.btnGlobals);
            this.Controls.Add(this.btnInvoices);
            this.Controls.Add(this.btnJobs);
            this.Controls.Add(this.btnClients);
            this.Name = "MainMenu";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClients;
        private System.Windows.Forms.Button btnJobs;
        private System.Windows.Forms.Button btnInvoices;
        private System.Windows.Forms.Button btnGlobals;
        private System.Windows.Forms.Button btnStaff;
        private System.Windows.Forms.PictureBox pbxLogo;
    }
}

