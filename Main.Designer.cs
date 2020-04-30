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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpFac = new System.Windows.Forms.TabPage();
            this.gvNotiifications = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.tpEmail = new System.Windows.Forms.TabPage();
            this.lvProcessing = new System.Windows.Forms.ListView();
            this.colTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDetails = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1.SuspendLayout();
            this.tpFac.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvNotiifications)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tpFac);
            this.tabControl1.Controls.Add(this.tpEmail);
            this.tabControl1.Location = new System.Drawing.Point(2, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(978, 470);
            this.tabControl1.TabIndex = 0;
            // 
            // tpFac
            // 
            this.tpFac.Controls.Add(this.gvNotiifications);
            this.tpFac.Controls.Add(this.label1);
            this.tpFac.Controls.Add(this.btnTest);
            this.tpFac.Controls.Add(this.btnOpen);
            this.tpFac.Controls.Add(this.txtInfo);
            this.tpFac.Location = new System.Drawing.Point(4, 22);
            this.tpFac.Name = "tpFac";
            this.tpFac.Padding = new System.Windows.Forms.Padding(3);
            this.tpFac.Size = new System.Drawing.Size(970, 444);
            this.tpFac.TabIndex = 0;
            this.tpFac.Text = "Facilities";
            this.tpFac.UseVisualStyleBackColor = true;
            // 
            // gvNotiifications
            // 
            this.gvNotiifications.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gvNotiifications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvNotiifications.Location = new System.Drawing.Point(6, 51);
            this.gvNotiifications.Name = "gvNotiifications";
            this.gvNotiifications.Size = new System.Drawing.Size(537, 377);
            this.gvNotiifications.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(559, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Invaild Codes";
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(859, 22);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(81, 23);
            this.btnTest.TabIndex = 1;
            this.btnTest.Text = "Text";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
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
            // txtInfo
            // 
            this.txtInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtInfo.Location = new System.Drawing.Point(549, 96);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(415, 332);
            this.txtInfo.TabIndex = 2;
            // 
            // tpEmail
            // 
            this.tpEmail.Location = new System.Drawing.Point(4, 22);
            this.tpEmail.Name = "tpEmail";
            this.tpEmail.Padding = new System.Windows.Forms.Padding(3);
            this.tpEmail.Size = new System.Drawing.Size(970, 444);
            this.tpEmail.TabIndex = 1;
            this.tpEmail.Text = "Email";
            this.tpEmail.UseVisualStyleBackColor = true;
            // 
            // lvProcessing
            // 
            this.lvProcessing.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvProcessing.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTime,
            this.colDetails});
            this.lvProcessing.GridLines = true;
            this.lvProcessing.HideSelection = false;
            this.lvProcessing.Location = new System.Drawing.Point(-1, 466);
            this.lvProcessing.Name = "lvProcessing";
            this.lvProcessing.Size = new System.Drawing.Size(977, 165);
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
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 636);
            this.Controls.Add(this.lvProcessing);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Report Notifications";
            this.tabControl1.ResumeLayout(false);
            this.tpFac.ResumeLayout(false);
            this.tpFac.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvNotiifications)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpFac;
        private System.Windows.Forms.TabPage tpEmail;
        private System.Windows.Forms.ColumnHeader colTime;
        private System.Windows.Forms.ColumnHeader colDetails;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gvNotiifications;
        private System.Windows.Forms.Button btnTest;
        public System.Windows.Forms.ListView lvProcessing;
    }
}

