namespace ReportNotifications
{
    partial class Main
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpFac = new System.Windows.Forms.TabPage();
            this.tpEmail = new System.Windows.Forms.TabPage();
            this.lvProcessing = new System.Windows.Forms.ListView();
            this.colTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDetails = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnOpen = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tpFac.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tpFac);
            this.tabControl1.Controls.Add(this.tpEmail);
            this.tabControl1.Location = new System.Drawing.Point(2, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(864, 372);
            this.tabControl1.TabIndex = 0;
            // 
            // tpFac
            // 
            this.tpFac.Controls.Add(this.btnOpen);
            this.tpFac.Location = new System.Drawing.Point(4, 22);
            this.tpFac.Name = "tpFac";
            this.tpFac.Padding = new System.Windows.Forms.Padding(3);
            this.tpFac.Size = new System.Drawing.Size(856, 346);
            this.tpFac.TabIndex = 0;
            this.tpFac.Text = "Facilities";
            this.tpFac.UseVisualStyleBackColor = true;
            // 
            // tpEmail
            // 
            this.tpEmail.Location = new System.Drawing.Point(4, 22);
            this.tpEmail.Name = "tpEmail";
            this.tpEmail.Padding = new System.Windows.Forms.Padding(3);
            this.tpEmail.Size = new System.Drawing.Size(856, 346);
            this.tpEmail.TabIndex = 1;
            this.tpEmail.Text = "Email";
            this.tpEmail.UseVisualStyleBackColor = true;
            // 
            // lvProcessing
            // 
            this.lvProcessing.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvProcessing.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTime,
            this.colDetails});
            this.lvProcessing.GridLines = true;
            this.lvProcessing.HideSelection = false;
            this.lvProcessing.Location = new System.Drawing.Point(2, 374);
            this.lvProcessing.Name = "lvProcessing";
            this.lvProcessing.Size = new System.Drawing.Size(864, 145);
            this.lvProcessing.TabIndex = 1;
            this.lvProcessing.UseCompatibleStateImageBehavior = false;
            this.lvProcessing.View = System.Windows.Forms.View.Details;
            // 
            // colTime
            // 
            this.colTime.Text = "Time";
            this.colTime.Width = 100;
            // 
            // colDetails
            // 
            this.colDetails.Text = "Details";
            this.colDetails.Width = 800;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(25, 22);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 517);
            this.Controls.Add(this.lvProcessing);
            this.Controls.Add(this.tabControl1);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Report Notifications";
            this.tabControl1.ResumeLayout(false);
            this.tpFac.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpFac;
        private System.Windows.Forms.TabPage tpEmail;
        private System.Windows.Forms.ListView lvProcessing;
        private System.Windows.Forms.ColumnHeader colTime;
        private System.Windows.Forms.ColumnHeader colDetails;
        private System.Windows.Forms.Button btnOpen;
    }
}

