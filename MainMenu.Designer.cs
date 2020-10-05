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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.btnClients = new System.Windows.Forms.Button();
            this.btnJobs = new System.Windows.Forms.Button();
            this.btnInvoices = new System.Windows.Forms.Button();
            this.btnGlobals = new System.Windows.Forms.Button();
            this.btnStaff = new System.Windows.Forms.Button();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.btnReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClients
            // 
            this.btnClients.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnClients.Location = new System.Drawing.Point(12, 142);
            this.btnClients.Name = "btnClients";
            this.btnClients.Size = new System.Drawing.Size(105, 68);
            this.btnClients.TabIndex = 0;
            this.btnClients.Text = "Clients";
            this.btnClients.UseVisualStyleBackColor = true;
            this.btnClients.Click += new System.EventHandler(this.btnClients_Click);
            // 
            // btnJobs
            // 
            this.btnJobs.Location = new System.Drawing.Point(12, 34);
            this.btnJobs.Name = "btnJobs";
            this.btnJobs.Size = new System.Drawing.Size(104, 64);
            this.btnJobs.TabIndex = 1;
            this.btnJobs.Text = "Active Jobs";
            this.btnJobs.UseVisualStyleBackColor = true;
            this.btnJobs.Click += new System.EventHandler(this.btnJobs_Click);
            // 
            // btnInvoices
            // 
            this.btnInvoices.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnInvoices.Location = new System.Drawing.Point(12, 263);
            this.btnInvoices.Name = "btnInvoices";
            this.btnInvoices.Size = new System.Drawing.Size(104, 64);
            this.btnInvoices.TabIndex = 2;
            this.btnInvoices.Text = "Invoices";
            this.btnInvoices.UseVisualStyleBackColor = true;
            this.btnInvoices.Click += new System.EventHandler(this.btnInvoices_Click);
            // 
            // btnGlobals
            // 
            this.btnGlobals.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnGlobals.Location = new System.Drawing.Point(448, 142);
            this.btnGlobals.Name = "btnGlobals";
            this.btnGlobals.Size = new System.Drawing.Size(104, 64);
            this.btnGlobals.TabIndex = 3;
            this.btnGlobals.Text = "Globals";
            this.btnGlobals.UseVisualStyleBackColor = true;
            this.btnGlobals.Click += new System.EventHandler(this.btnGlobals_Click);
            // 
            // btnStaff
            // 
            this.btnStaff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStaff.Location = new System.Drawing.Point(448, 34);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(104, 64);
            this.btnStaff.TabIndex = 4;
            this.btnStaff.Text = "Staff";
            this.btnStaff.UseVisualStyleBackColor = true;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // pbxLogo
            // 
            this.pbxLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxLogo.Image = global::GrenciCPA.Properties.Resources.AFG_Logo;
            this.pbxLogo.Location = new System.Drawing.Point(132, 34);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(299, 293);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogo.TabIndex = 5;
            this.pbxLogo.TabStop = false;
            // 
            // btnReport
            // 
            this.btnReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReport.Location = new System.Drawing.Point(448, 263);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(104, 64);
            this.btnReport.TabIndex = 6;
            this.btnReport.Text = "Reports";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 357);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.pbxLogo);
            this.Controls.Add(this.btnStaff);
            this.Controls.Add(this.btnGlobals);
            this.Controls.Add(this.btnInvoices);
            this.Controls.Add(this.btnJobs);
            this.Controls.Add(this.btnClients);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Button btnReport;
    }
}

