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
            this.dptFacExport = new System.Windows.Forms.DateTimePicker();
            this.btnFileExport = new System.Windows.Forms.Button();
            this.gvNotiifications = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.tpEmail = new System.Windows.Forms.TabPage();
            this.gvEmail = new System.Windows.Forms.DataGridView();
            this.tpSettings = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnRxBackend = new System.Windows.Forms.Button();
            this.btnCIPS = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtRxBackend = new System.Windows.Forms.TextBox();
            this.txtCIPS = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEmailServer = new System.Windows.Forms.Button();
            this.btnPassword = new System.Windows.Forms.Button();
            this.btnAddress = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmailServer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPythonFolder = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPythonFolder = new System.Windows.Forms.TextBox();
            this.btnRenamedFolder = new System.Windows.Forms.Button();
            this.btnNotifyExports = new System.Windows.Forms.Button();
            this.btnNotifyReport = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRenamedFolder = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNotifyExports = new System.Windows.Forms.TextBox();
            this.txtNotifyReport = new System.Windows.Forms.TextBox();
            this.lvProcessing = new System.Windows.Forms.ListView();
            this.colTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDetails = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtMailbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnMailbox = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tpFac.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvNotiifications)).BeginInit();
            this.tpEmail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvEmail)).BeginInit();
            this.tpSettings.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tpFac);
            this.tabControl1.Controls.Add(this.tpEmail);
            this.tabControl1.Controls.Add(this.tpSettings);
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(978, 468);
            this.tabControl1.TabIndex = 0;
            // 
            // tpFac
            // 
            this.tpFac.Controls.Add(this.dptFacExport);
            this.tpFac.Controls.Add(this.btnFileExport);
            this.tpFac.Controls.Add(this.gvNotiifications);
            this.tpFac.Controls.Add(this.label1);
            this.tpFac.Controls.Add(this.btnTest);
            this.tpFac.Controls.Add(this.btnOpen);
            this.tpFac.Controls.Add(this.txtInfo);
            this.tpFac.Location = new System.Drawing.Point(4, 22);
            this.tpFac.Name = "tpFac";
            this.tpFac.Padding = new System.Windows.Forms.Padding(3);
            this.tpFac.Size = new System.Drawing.Size(970, 442);
            this.tpFac.TabIndex = 0;
            this.tpFac.Text = "Facility Notify";
            this.tpFac.UseVisualStyleBackColor = true;
            // 
            // dptFacExport
            // 
            this.dptFacExport.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dptFacExport.Location = new System.Drawing.Point(240, 23);
            this.dptFacExport.Name = "dptFacExport";
            this.dptFacExport.Size = new System.Drawing.Size(90, 20);
            this.dptFacExport.TabIndex = 6;
            // 
            // btnFileExport
            // 
            this.btnFileExport.Location = new System.Drawing.Point(153, 21);
            this.btnFileExport.Name = "btnFileExport";
            this.btnFileExport.Size = new System.Drawing.Size(80, 23);
            this.btnFileExport.TabIndex = 5;
            this.btnFileExport.Text = "Facility Export";
            this.btnFileExport.UseVisualStyleBackColor = true;
            this.btnFileExport.Click += new System.EventHandler(this.btnFileExport_Click);
            // 
            // gvNotiifications
            // 
            this.gvNotiifications.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gvNotiifications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvNotiifications.Location = new System.Drawing.Point(6, 51);
            this.gvNotiifications.Name = "gvNotiifications";
            this.gvNotiifications.Size = new System.Drawing.Size(537, 375);
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
            this.btnTest.Location = new System.Drawing.Point(950, 6);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(10, 23);
            this.btnTest.TabIndex = 1;
            this.btnTest.Text = "Text";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(18, 20);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(110, 23);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Import Notifications";
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
            this.txtInfo.Size = new System.Drawing.Size(415, 330);
            this.txtInfo.TabIndex = 2;
            // 
            // tpEmail
            // 
            this.tpEmail.Controls.Add(this.gvEmail);
            this.tpEmail.Location = new System.Drawing.Point(4, 22);
            this.tpEmail.Name = "tpEmail";
            this.tpEmail.Padding = new System.Windows.Forms.Padding(3);
            this.tpEmail.Size = new System.Drawing.Size(970, 442);
            this.tpEmail.TabIndex = 1;
            this.tpEmail.Text = "Email";
            this.tpEmail.UseVisualStyleBackColor = true;
            // 
            // gvEmail
            // 
            this.gvEmail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvEmail.Location = new System.Drawing.Point(20, 96);
            this.gvEmail.Name = "gvEmail";
            this.gvEmail.Size = new System.Drawing.Size(931, 291);
            this.gvEmail.TabIndex = 0;
            // 
            // tpSettings
            // 
            this.tpSettings.Controls.Add(this.groupBox3);
            this.tpSettings.Controls.Add(this.groupBox1);
            this.tpSettings.Controls.Add(this.groupBox2);
            this.tpSettings.Location = new System.Drawing.Point(4, 22);
            this.tpSettings.Name = "tpSettings";
            this.tpSettings.Size = new System.Drawing.Size(970, 442);
            this.tpSettings.TabIndex = 2;
            this.tpSettings.Text = "Settings";
            this.tpSettings.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnRxBackend);
            this.groupBox3.Controls.Add(this.btnCIPS);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txtRxBackend);
            this.groupBox3.Controls.Add(this.txtCIPS);
            this.groupBox3.Location = new System.Drawing.Point(16, 212);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(438, 117);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Database Connections";
            // 
            // btnRxBackend
            // 
            this.btnRxBackend.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRxBackend.Location = new System.Drawing.Point(376, 67);
            this.btnRxBackend.Name = "btnRxBackend";
            this.btnRxBackend.Size = new System.Drawing.Size(38, 22);
            this.btnRxBackend.TabIndex = 9;
            this.btnRxBackend.Text = ">>>";
            this.btnRxBackend.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRxBackend.UseVisualStyleBackColor = true;
            this.btnRxBackend.Click += new System.EventHandler(this.btnTextBox_Click);
            // 
            // btnCIPS
            // 
            this.btnCIPS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCIPS.Location = new System.Drawing.Point(376, 29);
            this.btnCIPS.Name = "btnCIPS";
            this.btnCIPS.Size = new System.Drawing.Size(38, 22);
            this.btnCIPS.TabIndex = 2;
            this.btnCIPS.Text = ">>>";
            this.btnCIPS.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCIPS.UseVisualStyleBackColor = true;
            this.btnCIPS.Click += new System.EventHandler(this.btnTextBox_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "RxBackend";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 38);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "CIPS";
            // 
            // txtRxBackend
            // 
            this.txtRxBackend.Location = new System.Drawing.Point(83, 68);
            this.txtRxBackend.Name = "txtRxBackend";
            this.txtRxBackend.Size = new System.Drawing.Size(287, 20);
            this.txtRxBackend.TabIndex = 1;
            // 
            // txtCIPS
            // 
            this.txtCIPS.Location = new System.Drawing.Point(83, 31);
            this.txtCIPS.Name = "txtCIPS";
            this.txtCIPS.Size = new System.Drawing.Size(287, 20);
            this.txtCIPS.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEmailServer);
            this.groupBox1.Controls.Add(this.btnPassword);
            this.groupBox1.Controls.Add(this.btnMailbox);
            this.groupBox1.Controls.Add(this.btnAddress);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtEmailServer);
            this.groupBox1.Controls.Add(this.txtMailbox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Location = new System.Drawing.Point(486, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 189);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Email";
            // 
            // btnEmailServer
            // 
            this.btnEmailServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmailServer.Location = new System.Drawing.Point(287, 144);
            this.btnEmailServer.Name = "btnEmailServer";
            this.btnEmailServer.Size = new System.Drawing.Size(38, 22);
            this.btnEmailServer.TabIndex = 10;
            this.btnEmailServer.Text = ">>>";
            this.btnEmailServer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEmailServer.UseVisualStyleBackColor = true;
            this.btnEmailServer.Click += new System.EventHandler(this.btnTextBox_Click);
            // 
            // btnPassword
            // 
            this.btnPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPassword.Location = new System.Drawing.Point(287, 68);
            this.btnPassword.Name = "btnPassword";
            this.btnPassword.Size = new System.Drawing.Size(38, 22);
            this.btnPassword.TabIndex = 9;
            this.btnPassword.Text = ">>>";
            this.btnPassword.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPassword.UseVisualStyleBackColor = true;
            this.btnPassword.Click += new System.EventHandler(this.btnTextBox_Click);
            // 
            // btnAddress
            // 
            this.btnAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddress.Location = new System.Drawing.Point(287, 30);
            this.btnAddress.Name = "btnAddress";
            this.btnAddress.Size = new System.Drawing.Size(38, 22);
            this.btnAddress.TabIndex = 2;
            this.btnAddress.Text = ">>>";
            this.btnAddress.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddress.UseVisualStyleBackColor = true;
            this.btnAddress.Click += new System.EventHandler(this.btnTextBox_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Server";
            // 
            // txtEmailServer
            // 
            this.txtEmailServer.Location = new System.Drawing.Point(69, 145);
            this.txtEmailServer.Name = "txtEmailServer";
            this.txtEmailServer.Size = new System.Drawing.Size(212, 20);
            this.txtEmailServer.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Address";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(69, 68);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(212, 20);
            this.txtPassword.TabIndex = 1;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(69, 31);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(212, 20);
            this.txtAddress.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPythonFolder);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtPythonFolder);
            this.groupBox2.Controls.Add(this.btnRenamedFolder);
            this.groupBox2.Controls.Add(this.btnNotifyExports);
            this.groupBox2.Controls.Add(this.btnNotifyReport);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtRenamedFolder);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtNotifyExports);
            this.groupBox2.Controls.Add(this.txtNotifyReport);
            this.groupBox2.Location = new System.Drawing.Point(16, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(438, 189);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Folders/Files";
            // 
            // btnPythonFolder
            // 
            this.btnPythonFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPythonFolder.Location = new System.Drawing.Point(376, 148);
            this.btnPythonFolder.Name = "btnPythonFolder";
            this.btnPythonFolder.Size = new System.Drawing.Size(38, 22);
            this.btnPythonFolder.TabIndex = 18;
            this.btnPythonFolder.Text = ">>>";
            this.btnPythonFolder.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPythonFolder.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 153);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Python";
            // 
            // txtPythonFolder
            // 
            this.txtPythonFolder.Location = new System.Drawing.Point(102, 147);
            this.txtPythonFolder.Name = "txtPythonFolder";
            this.txtPythonFolder.Size = new System.Drawing.Size(268, 20);
            this.txtPythonFolder.TabIndex = 16;
            // 
            // btnRenamedFolder
            // 
            this.btnRenamedFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRenamedFolder.Location = new System.Drawing.Point(376, 111);
            this.btnRenamedFolder.Name = "btnRenamedFolder";
            this.btnRenamedFolder.Size = new System.Drawing.Size(38, 22);
            this.btnRenamedFolder.TabIndex = 15;
            this.btnRenamedFolder.Text = ">>>";
            this.btnRenamedFolder.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRenamedFolder.UseVisualStyleBackColor = true;
            // 
            // btnNotifyExports
            // 
            this.btnNotifyExports.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotifyExports.Location = new System.Drawing.Point(376, 71);
            this.btnNotifyExports.Name = "btnNotifyExports";
            this.btnNotifyExports.Size = new System.Drawing.Size(38, 22);
            this.btnNotifyExports.TabIndex = 14;
            this.btnNotifyExports.Text = ">>>";
            this.btnNotifyExports.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNotifyExports.UseVisualStyleBackColor = true;
            this.btnNotifyExports.Click += new System.EventHandler(this.btnNotifyExports_Click);
            // 
            // btnNotifyReport
            // 
            this.btnNotifyReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotifyReport.Location = new System.Drawing.Point(376, 31);
            this.btnNotifyReport.Name = "btnNotifyReport";
            this.btnNotifyReport.Size = new System.Drawing.Size(38, 22);
            this.btnNotifyReport.TabIndex = 13;
            this.btnNotifyReport.Text = ">>>";
            this.btnNotifyReport.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNotifyReport.UseVisualStyleBackColor = true;
            this.btnNotifyReport.Click += new System.EventHandler(this.btnNotifyReport_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Renamed";
            // 
            // txtRenamedFolder
            // 
            this.txtRenamedFolder.Location = new System.Drawing.Point(102, 110);
            this.txtRenamedFolder.Name = "txtRenamedFolder";
            this.txtRenamedFolder.Size = new System.Drawing.Size(268, 20);
            this.txtRenamedFolder.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Notify Exports";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Notify Report";
            // 
            // txtNotifyExports
            // 
            this.txtNotifyExports.Location = new System.Drawing.Point(102, 71);
            this.txtNotifyExports.Name = "txtNotifyExports";
            this.txtNotifyExports.Size = new System.Drawing.Size(268, 20);
            this.txtNotifyExports.TabIndex = 1;
            // 
            // txtNotifyReport
            // 
            this.txtNotifyReport.Location = new System.Drawing.Point(102, 31);
            this.txtNotifyReport.Name = "txtNotifyReport";
            this.txtNotifyReport.Size = new System.Drawing.Size(268, 20);
            this.txtNotifyReport.TabIndex = 0;
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
            // txtMailbox
            // 
            this.txtMailbox.Location = new System.Drawing.Point(69, 105);
            this.txtMailbox.Name = "txtMailbox";
            this.txtMailbox.Size = new System.Drawing.Size(212, 20);
            this.txtMailbox.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Mailbox";
            // 
            // btnMailbox
            // 
            this.btnMailbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMailbox.Location = new System.Drawing.Point(287, 104);
            this.btnMailbox.Name = "btnMailbox";
            this.btnMailbox.Size = new System.Drawing.Size(38, 22);
            this.btnMailbox.TabIndex = 8;
            this.btnMailbox.Text = ">>>";
            this.btnMailbox.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMailbox.UseVisualStyleBackColor = true;
            this.btnMailbox.Click += new System.EventHandler(this.btnTextBox_Click);
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
            this.tpEmail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvEmail)).EndInit();
            this.tpSettings.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.Button btnFileExport;
        private System.Windows.Forms.DateTimePicker dptFacExport;
        private System.Windows.Forms.DataGridView gvEmail;
        private System.Windows.Forms.TabPage tpSettings;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPythonFolder;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPythonFolder;
        private System.Windows.Forms.Button btnRenamedFolder;
        private System.Windows.Forms.Button btnNotifyExports;
        private System.Windows.Forms.Button btnNotifyReport;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRenamedFolder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNotifyExports;
        private System.Windows.Forms.TextBox txtNotifyReport;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnRxBackend;
        private System.Windows.Forms.Button btnCIPS;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtRxBackend;
        private System.Windows.Forms.TextBox txtCIPS;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEmailServer;
        private System.Windows.Forms.Button btnPassword;
        private System.Windows.Forms.Button btnAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmailServer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnMailbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMailbox;
    }
}

