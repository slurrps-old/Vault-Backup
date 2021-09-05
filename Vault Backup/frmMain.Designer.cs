
namespace Vault_Backup
{
    partial class frmMain
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
            this.tabMain = new System.Windows.Forms.TabControl();
            this.pgOverview = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.rtbDriveInfo = new System.Windows.Forms.RichTextBox();
            this.cmbOverview = new System.Windows.Forms.ComboBox();
            this.pgBackup = new System.Windows.Forms.TabPage();
            this.btnDest = new System.Windows.Forms.Button();
            this.btnSource = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.chkSaveDest = new System.Windows.Forms.CheckBox();
            this.chkOverwrite = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDestinationPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSourcePath = new System.Windows.Forms.TextBox();
            this.pgFormat = new System.Windows.Forms.TabPage();
            this.lblFormatMessage = new System.Windows.Forms.Label();
            this.btnFormat = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbAllocationSize = new System.Windows.Forms.ComboBox();
            this.cmbFileSystem = new System.Windows.Forms.ComboBox();
            this.chkCompression = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.chkQuickFormat = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtVolumeLabel = new System.Windows.Forms.TextBox();
            this.cmbFormat = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pgClone = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.notifyTrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.bgWorkerCopy = new System.ComponentModel.BackgroundWorker();
            this.folderBrowser = new WK.Libraries.BetterFolderBrowserNS.BetterFolderBrowser(this.components);
            this.bgFormat = new System.ComponentModel.BackgroundWorker();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDriveSize = new System.Windows.Forms.TextBox();
            this.tabMain.SuspendLayout();
            this.pgOverview.SuspendLayout();
            this.pgBackup.SuspendLayout();
            this.pgFormat.SuspendLayout();
            this.pgClone.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.pgOverview);
            this.tabMain.Controls.Add(this.pgBackup);
            this.tabMain.Controls.Add(this.pgFormat);
            this.tabMain.Controls.Add(this.pgClone);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(537, 555);
            this.tabMain.TabIndex = 0;
            // 
            // pgOverview
            // 
            this.pgOverview.Controls.Add(this.label13);
            this.pgOverview.Controls.Add(this.rtbDriveInfo);
            this.pgOverview.Controls.Add(this.cmbOverview);
            this.pgOverview.Location = new System.Drawing.Point(4, 25);
            this.pgOverview.Name = "pgOverview";
            this.pgOverview.Padding = new System.Windows.Forms.Padding(3);
            this.pgOverview.Size = new System.Drawing.Size(529, 526);
            this.pgOverview.TabIndex = 0;
            this.pgOverview.Text = "Overview";
            this.pgOverview.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(102, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(333, 21);
            this.label13.TabIndex = 3;
            this.label13.Text = "Please select a drive for information:";
            // 
            // rtbDriveInfo
            // 
            this.rtbDriveInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbDriveInfo.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbDriveInfo.Location = new System.Drawing.Point(8, 91);
            this.rtbDriveInfo.Name = "rtbDriveInfo";
            this.rtbDriveInfo.ReadOnly = true;
            this.rtbDriveInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rtbDriveInfo.Size = new System.Drawing.Size(513, 427);
            this.rtbDriveInfo.TabIndex = 1;
            this.rtbDriveInfo.Text = "";
            // 
            // cmbOverview
            // 
            this.cmbOverview.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOverview.FormattingEnabled = true;
            this.cmbOverview.Location = new System.Drawing.Point(100, 61);
            this.cmbOverview.Name = "cmbOverview";
            this.cmbOverview.Size = new System.Drawing.Size(336, 24);
            this.cmbOverview.TabIndex = 0;
            this.cmbOverview.SelectedIndexChanged += new System.EventHandler(this.cmbOverview_SelectedIndexChanged);
            // 
            // pgBackup
            // 
            this.pgBackup.Controls.Add(this.btnDest);
            this.pgBackup.Controls.Add(this.btnSource);
            this.pgBackup.Controls.Add(this.btnCopy);
            this.pgBackup.Controls.Add(this.chkSaveDest);
            this.pgBackup.Controls.Add(this.chkOverwrite);
            this.pgBackup.Controls.Add(this.label4);
            this.pgBackup.Controls.Add(this.label3);
            this.pgBackup.Controls.Add(this.txtDestinationPath);
            this.pgBackup.Controls.Add(this.label2);
            this.pgBackup.Controls.Add(this.label1);
            this.pgBackup.Controls.Add(this.txtSourcePath);
            this.pgBackup.Location = new System.Drawing.Point(4, 25);
            this.pgBackup.Name = "pgBackup";
            this.pgBackup.Padding = new System.Windows.Forms.Padding(3);
            this.pgBackup.Size = new System.Drawing.Size(529, 526);
            this.pgBackup.TabIndex = 1;
            this.pgBackup.Text = "Backup";
            this.pgBackup.UseVisualStyleBackColor = true;
            // 
            // btnDest
            // 
            this.btnDest.BackColor = System.Drawing.Color.LightGray;
            this.btnDest.FlatAppearance.BorderSize = 0;
            this.btnDest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDest.Location = new System.Drawing.Point(438, 228);
            this.btnDest.Name = "btnDest";
            this.btnDest.Size = new System.Drawing.Size(25, 25);
            this.btnDest.TabIndex = 10;
            this.btnDest.Text = "...";
            this.btnDest.UseVisualStyleBackColor = false;
            this.btnDest.Click += new System.EventHandler(this.btnDest_Click);
            // 
            // btnSource
            // 
            this.btnSource.BackColor = System.Drawing.Color.LightGray;
            this.btnSource.FlatAppearance.BorderSize = 0;
            this.btnSource.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSource.Location = new System.Drawing.Point(438, 99);
            this.btnSource.Name = "btnSource";
            this.btnSource.Size = new System.Drawing.Size(25, 25);
            this.btnSource.TabIndex = 9;
            this.btnSource.Text = "...";
            this.btnSource.UseVisualStyleBackColor = false;
            this.btnSource.Click += new System.EventHandler(this.btnSource_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.BackColor = System.Drawing.Color.LightGray;
            this.btnCopy.FlatAppearance.BorderSize = 0;
            this.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopy.Location = new System.Drawing.Point(204, 422);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(128, 32);
            this.btnCopy.TabIndex = 8;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = false;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // chkSaveDest
            // 
            this.chkSaveDest.AutoSize = true;
            this.chkSaveDest.BackColor = System.Drawing.Color.Transparent;
            this.chkSaveDest.ForeColor = System.Drawing.Color.Black;
            this.chkSaveDest.Location = new System.Drawing.Point(183, 340);
            this.chkSaveDest.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkSaveDest.Name = "chkSaveDest";
            this.chkSaveDest.Size = new System.Drawing.Size(170, 20);
            this.chkSaveDest.TabIndex = 7;
            this.chkSaveDest.Text = "Save Destination Folder?";
            this.chkSaveDest.UseVisualStyleBackColor = false;
            this.chkSaveDest.CheckedChanged += new System.EventHandler(this.chkSaveDest_CheckedChanged);
            // 
            // chkOverwrite
            // 
            this.chkOverwrite.AutoSize = true;
            this.chkOverwrite.BackColor = System.Drawing.Color.Transparent;
            this.chkOverwrite.ForeColor = System.Drawing.Color.Black;
            this.chkOverwrite.Location = new System.Drawing.Point(209, 297);
            this.chkOverwrite.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkOverwrite.Name = "chkOverwrite";
            this.chkOverwrite.Size = new System.Drawing.Size(118, 20);
            this.chkOverwrite.TabIndex = 6;
            this.chkOverwrite.Text = "Overwrite Files?";
            this.chkOverwrite.UseVisualStyleBackColor = false;
            this.chkOverwrite.CheckedChanged += new System.EventHandler(this.chkOverwrite_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Source:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Destination:";
            // 
            // txtDestinationPath
            // 
            this.txtDestinationPath.Location = new System.Drawing.Point(105, 228);
            this.txtDestinationPath.Name = "txtDestinationPath";
            this.txtDestinationPath.ReadOnly = true;
            this.txtDestinationPath.Size = new System.Drawing.Size(327, 25);
            this.txtDestinationPath.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(480, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Please select destination folder:________________________";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(439, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please select source folder:________________________";
            // 
            // txtSourcePath
            // 
            this.txtSourcePath.Location = new System.Drawing.Point(105, 100);
            this.txtSourcePath.Name = "txtSourcePath";
            this.txtSourcePath.ReadOnly = true;
            this.txtSourcePath.Size = new System.Drawing.Size(327, 25);
            this.txtSourcePath.TabIndex = 0;
            // 
            // pgFormat
            // 
            this.pgFormat.Controls.Add(this.label14);
            this.pgFormat.Controls.Add(this.txtDriveSize);
            this.pgFormat.Controls.Add(this.lblFormatMessage);
            this.pgFormat.Controls.Add(this.btnFormat);
            this.pgFormat.Controls.Add(this.label11);
            this.pgFormat.Controls.Add(this.label12);
            this.pgFormat.Controls.Add(this.cmbAllocationSize);
            this.pgFormat.Controls.Add(this.cmbFileSystem);
            this.pgFormat.Controls.Add(this.chkCompression);
            this.pgFormat.Controls.Add(this.label10);
            this.pgFormat.Controls.Add(this.chkQuickFormat);
            this.pgFormat.Controls.Add(this.label7);
            this.pgFormat.Controls.Add(this.label8);
            this.pgFormat.Controls.Add(this.label9);
            this.pgFormat.Controls.Add(this.txtVolumeLabel);
            this.pgFormat.Controls.Add(this.cmbFormat);
            this.pgFormat.Controls.Add(this.label6);
            this.pgFormat.Location = new System.Drawing.Point(4, 25);
            this.pgFormat.Name = "pgFormat";
            this.pgFormat.Padding = new System.Windows.Forms.Padding(3);
            this.pgFormat.Size = new System.Drawing.Size(529, 526);
            this.pgFormat.TabIndex = 2;
            this.pgFormat.Text = "Format";
            this.pgFormat.UseVisualStyleBackColor = true;
            // 
            // lblFormatMessage
            // 
            this.lblFormatMessage.AutoSize = true;
            this.lblFormatMessage.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormatMessage.Location = new System.Drawing.Point(188, 436);
            this.lblFormatMessage.Name = "lblFormatMessage";
            this.lblFormatMessage.Size = new System.Drawing.Size(162, 17);
            this.lblFormatMessage.TabIndex = 38;
            this.lblFormatMessage.Text = "Formatting please wait...";
            this.lblFormatMessage.Visible = false;
            // 
            // btnFormat
            // 
            this.btnFormat.BackColor = System.Drawing.Color.LightGray;
            this.btnFormat.FlatAppearance.BorderSize = 0;
            this.btnFormat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormat.Location = new System.Drawing.Point(204, 456);
            this.btnFormat.Name = "btnFormat";
            this.btnFormat.Size = new System.Drawing.Size(128, 32);
            this.btnFormat.TabIndex = 37;
            this.btnFormat.Text = "Format";
            this.btnFormat.UseVisualStyleBackColor = false;
            this.btnFormat.Click += new System.EventHandler(this.btnFormat_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(79, 294);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 16);
            this.label11.TabIndex = 36;
            this.label11.Text = "Allocation unit size";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(79, 264);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 16);
            this.label12.TabIndex = 35;
            this.label12.Text = "File System";
            // 
            // cmbAllocationSize
            // 
            this.cmbAllocationSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAllocationSize.FormattingEnabled = true;
            this.cmbAllocationSize.Items.AddRange(new object[] {
            "512 bytes",
            "1024 bytes",
            "2048 bytes",
            "4096 bytes",
            "8192 bytes",
            "16 kilobytes",
            "32 kilobytes",
            "64 kilobytes",
            "128 kilobytes",
            "256 kilobytes",
            "512 kilobytes",
            "1024 kilobytes",
            "2048 kilobytes"});
            this.cmbAllocationSize.Location = new System.Drawing.Point(204, 291);
            this.cmbAllocationSize.Name = "cmbAllocationSize";
            this.cmbAllocationSize.Size = new System.Drawing.Size(173, 24);
            this.cmbAllocationSize.TabIndex = 34;
            // 
            // cmbFileSystem
            // 
            this.cmbFileSystem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFileSystem.FormattingEnabled = true;
            this.cmbFileSystem.Items.AddRange(new object[] {
            "NTFS",
            "FAT32",
            "exFAT"});
            this.cmbFileSystem.Location = new System.Drawing.Point(204, 261);
            this.cmbFileSystem.Name = "cmbFileSystem";
            this.cmbFileSystem.Size = new System.Drawing.Size(173, 24);
            this.cmbFileSystem.TabIndex = 33;
            // 
            // chkCompression
            // 
            this.chkCompression.AutoSize = true;
            this.chkCompression.BackColor = System.Drawing.Color.Transparent;
            this.chkCompression.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCompression.ForeColor = System.Drawing.Color.Black;
            this.chkCompression.Location = new System.Drawing.Point(153, 365);
            this.chkCompression.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkCompression.Name = "chkCompression";
            this.chkCompression.Size = new System.Drawing.Size(231, 20);
            this.chkCompression.TabIndex = 32;
            this.chkCompression.Text = "Enable file and folder compression";
            this.chkCompression.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(172, 499);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(193, 16);
            this.label10.TabIndex = 31;
            this.label10.Text = "*Please wait for success pop up";
            // 
            // chkQuickFormat
            // 
            this.chkQuickFormat.AutoSize = true;
            this.chkQuickFormat.BackColor = System.Drawing.Color.Transparent;
            this.chkQuickFormat.Checked = true;
            this.chkQuickFormat.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkQuickFormat.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkQuickFormat.ForeColor = System.Drawing.Color.Black;
            this.chkQuickFormat.Location = new System.Drawing.Point(216, 337);
            this.chkQuickFormat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkQuickFormat.Name = "chkQuickFormat";
            this.chkQuickFormat.Size = new System.Drawing.Size(104, 20);
            this.chkQuickFormat.TabIndex = 30;
            this.chkQuickFormat.Text = "Quick Format";
            this.chkQuickFormat.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(195, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 25);
            this.label7.TabIndex = 29;
            this.label7.Text = "Format Details";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(79, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 16);
            this.label8.TabIndex = 28;
            this.label8.Text = "Volume Label";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(214, 209);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 16);
            this.label9.TabIndex = 27;
            this.label9.Text = "Please enter drive name.";
            // 
            // txtVolumeLabel
            // 
            this.txtVolumeLabel.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVolumeLabel.Location = new System.Drawing.Point(204, 229);
            this.txtVolumeLabel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtVolumeLabel.Name = "txtVolumeLabel";
            this.txtVolumeLabel.Size = new System.Drawing.Size(173, 25);
            this.txtVolumeLabel.TabIndex = 26;
            // 
            // cmbFormat
            // 
            this.cmbFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFormat.FormattingEnabled = true;
            this.cmbFormat.Location = new System.Drawing.Point(100, 73);
            this.cmbFormat.Name = "cmbFormat";
            this.cmbFormat.Size = new System.Drawing.Size(336, 24);
            this.cmbFormat.TabIndex = 3;
            this.cmbFormat.SelectedIndexChanged += new System.EventHandler(this.cmbFormat_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(129, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(279, 21);
            this.label6.TabIndex = 2;
            this.label6.Text = "Please select a drive to format:";
            // 
            // pgClone
            // 
            this.pgClone.Controls.Add(this.label5);
            this.pgClone.Location = new System.Drawing.Point(4, 25);
            this.pgClone.Name = "pgClone";
            this.pgClone.Padding = new System.Windows.Forms.Padding(3);
            this.pgClone.Size = new System.Drawing.Size(529, 526);
            this.pgClone.TabIndex = 3;
            this.pgClone.Text = "Clone";
            this.pgClone.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(186, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "In Construction";
            // 
            // notifyTrayIcon
            // 
            this.notifyTrayIcon.Text = "notifyIcon1";
            this.notifyTrayIcon.Visible = true;
            // 
            // bgWorkerCopy
            // 
            this.bgWorkerCopy.WorkerSupportsCancellation = true;
            this.bgWorkerCopy.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorkerCopy_DoWork);
            this.bgWorkerCopy.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorkerCopy_RunWorkerCompleted);
            // 
            // folderBrowser
            // 
            this.folderBrowser.Multiselect = false;
            this.folderBrowser.RootFolder = "C:\\Users\\klamb\\Desktop";
            this.folderBrowser.Title = "Please select a folder...";
            // 
            // bgFormat
            // 
            this.bgFormat.WorkerReportsProgress = true;
            this.bgFormat.WorkerSupportsCancellation = true;
            this.bgFormat.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgFormat_DoWork);
            this.bgFormat.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgFormat_RunWorkerCompleted);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(79, 183);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 16);
            this.label14.TabIndex = 40;
            this.label14.Text = "Drive Size";
            // 
            // txtDriveSize
            // 
            this.txtDriveSize.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDriveSize.Location = new System.Drawing.Point(204, 180);
            this.txtDriveSize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDriveSize.Name = "txtDriveSize";
            this.txtDriveSize.ReadOnly = true;
            this.txtDriveSize.Size = new System.Drawing.Size(173, 25);
            this.txtDriveSize.TabIndex = 39;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 555);
            this.Controls.Add(this.tabMain);
            this.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vault Backup";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tabMain.ResumeLayout(false);
            this.pgOverview.ResumeLayout(false);
            this.pgOverview.PerformLayout();
            this.pgBackup.ResumeLayout(false);
            this.pgBackup.PerformLayout();
            this.pgFormat.ResumeLayout(false);
            this.pgFormat.PerformLayout();
            this.pgClone.ResumeLayout(false);
            this.pgClone.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage pgOverview;
        private System.Windows.Forms.TabPage pgBackup;
        private System.Windows.Forms.TabPage pgFormat;
        private System.Windows.Forms.TabPage pgClone;
        private System.Windows.Forms.Button btnCopy;
        public System.Windows.Forms.CheckBox chkSaveDest;
        public System.Windows.Forms.CheckBox chkOverwrite;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDestinationPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSourcePath;
        private System.Windows.Forms.NotifyIcon notifyTrayIcon;
        private System.ComponentModel.BackgroundWorker bgWorkerCopy;
        private System.Windows.Forms.Button btnDest;
        private System.Windows.Forms.Button btnSource;
        private WK.Libraries.BetterFolderBrowserNS.BetterFolderBrowser folderBrowser;
        private System.Windows.Forms.ComboBox cmbOverview;
        private System.Windows.Forms.RichTextBox rtbDriveInfo;
        private System.Windows.Forms.ComboBox cmbFormat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbAllocationSize;
        private System.Windows.Forms.ComboBox cmbFileSystem;
        private System.Windows.Forms.CheckBox chkCompression;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox chkQuickFormat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txtVolumeLabel;
        private System.Windows.Forms.Button btnFormat;
        private System.Windows.Forms.Label label13;
        private System.ComponentModel.BackgroundWorker bgFormat;
        private System.Windows.Forms.Label lblFormatMessage;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.TextBox txtDriveSize;
    }
}

