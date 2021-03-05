namespace CopyUSB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.pgBackup = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.txtSourcePath = new System.Windows.Forms.TextBox();
            this.chkSaveDest = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDestinationPath = new System.Windows.Forms.TextBox();
            this.btnDest = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnSource = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnCopy = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chkOverwrite = new System.Windows.Forms.CheckBox();
            this.pgFormat = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.btnDriveDetails = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnFormatDrive = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnFileWipe = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lstDrives = new ComponentFactory.Krypton.Toolkit.KryptonListBox();
            this.lblDriveList = new System.Windows.Forms.Label();
            this.kryptonDockableNavigator1 = new ComponentFactory.Krypton.Docking.KryptonDockableNavigator();
            this.pgSettings = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.btnDefaultSettings = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chkDateTimeStamp = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDefaultSource = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtDefaultSource = new System.Windows.Forms.TextBox();
            this.dateTimeAutoBackup = new System.Windows.Forms.DateTimePicker();
            this.chkAutoBackup = new System.Windows.Forms.CheckBox();
            this.btnDefaultDest = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtDefaultDest = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkOverwriteSetting = new System.Windows.Forms.CheckBox();
            this.chkOnlyUSB = new System.Windows.Forms.CheckBox();
            this.chkStartOnStartup = new System.Windows.Forms.CheckBox();
            this.chkDriveDetection = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numUpDownFileWipe = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSaveSettings = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnMinimize = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panHeader = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.VaultToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.notifyTrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contexVault = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.restoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bgWorkerCopy = new System.ComponentModel.BackgroundWorker();
            this.bgWorkerFormat = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pgBackup)).BeginInit();
            this.pgBackup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pgFormat)).BeginInit();
            this.pgFormat.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDockableNavigator1)).BeginInit();
            this.kryptonDockableNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pgSettings)).BeginInit();
            this.pgSettings.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownFileWipe)).BeginInit();
            this.panHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contexVault.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // pgBackup
            // 
            this.pgBackup.AllowDrop = true;
            this.pgBackup.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.pgBackup.Controls.Add(this.txtSourcePath);
            this.pgBackup.Controls.Add(this.chkSaveDest);
            this.pgBackup.Controls.Add(this.label2);
            this.pgBackup.Controls.Add(this.label1);
            this.pgBackup.Controls.Add(this.txtDestinationPath);
            this.pgBackup.Controls.Add(this.btnDest);
            this.pgBackup.Controls.Add(this.btnSource);
            this.pgBackup.Controls.Add(this.btnCopy);
            this.pgBackup.Controls.Add(this.label5);
            this.pgBackup.Controls.Add(this.label4);
            this.pgBackup.Controls.Add(this.chkOverwrite);
            this.pgBackup.Flags = 65534;
            this.pgBackup.LastVisibleSet = true;
            this.pgBackup.MinimumSize = new System.Drawing.Size(50, 50);
            this.pgBackup.Name = "pgBackup";
            this.pgBackup.Size = new System.Drawing.Size(451, 400);
            this.pgBackup.StateNormal.BorderEdge.Color1 = System.Drawing.Color.Transparent;
            this.pgBackup.StateNormal.BorderEdge.Color2 = System.Drawing.Color.Transparent;
            this.pgBackup.StateNormal.BorderEdge.Width = 0;
            this.pgBackup.StateNormal.Page.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(128)))));
            this.pgBackup.StateNormal.Page.Color2 = System.Drawing.Color.Transparent;
            this.pgBackup.StateNormal.Page.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.RoundedTopLight;
            this.pgBackup.StateNormal.Page.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.pgBackup.StateSelected.Tab.Back.Color1 = System.Drawing.Color.White;
            this.pgBackup.StateSelected.Tab.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(128)))));
            this.pgBackup.StateSelected.Tab.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.GlassCheckedTrackingFull;
            this.pgBackup.StateTracking.Tab.Back.Color1 = System.Drawing.Color.White;
            this.pgBackup.StateTracking.Tab.Back.Color2 = System.Drawing.Color.White;
            this.pgBackup.Text = "Backup Drive";
            this.pgBackup.ToolTipTitle = "Page ToolTip";
            this.pgBackup.UniqueName = "DBE4E6CAF7F84B7C9F9BF3DBC20FF013";
            // 
            // txtSourcePath
            // 
            this.txtSourcePath.AllowDrop = true;
            this.txtSourcePath.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSourcePath.Location = new System.Drawing.Point(84, 114);
            this.txtSourcePath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSourcePath.Name = "txtSourcePath";
            this.txtSourcePath.Size = new System.Drawing.Size(248, 25);
            this.txtSourcePath.TabIndex = 0;
            this.txtSourcePath.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBox1_DragDrop);
            this.txtSourcePath.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBox1_DragEnter);
            // 
            // chkSaveDest
            // 
            this.chkSaveDest.AutoSize = true;
            this.chkSaveDest.BackColor = System.Drawing.Color.Transparent;
            this.chkSaveDest.ForeColor = System.Drawing.Color.White;
            this.chkSaveDest.Location = new System.Drawing.Point(207, 245);
            this.chkSaveDest.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkSaveDest.Name = "chkSaveDest";
            this.chkSaveDest.Size = new System.Drawing.Size(170, 20);
            this.chkSaveDest.TabIndex = 5;
            this.chkSaveDest.Text = "Save Destination Folder?";
            this.VaultToolTip.SetToolTip(this.chkSaveDest, "Save the destination folder for the next application launch.");
            this.chkSaveDest.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(81, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 17);
            this.label2.TabIndex = 35;
            this.label2.Text = "Please select its destination folder.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(81, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 17);
            this.label1.TabIndex = 34;
            this.label1.Text = "Please select the source you would like to copy.";
            // 
            // txtDestinationPath
            // 
            this.txtDestinationPath.AllowDrop = true;
            this.txtDestinationPath.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDestinationPath.Location = new System.Drawing.Point(84, 198);
            this.txtDestinationPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDestinationPath.Name = "txtDestinationPath";
            this.txtDestinationPath.Size = new System.Drawing.Size(248, 25);
            this.txtDestinationPath.TabIndex = 2;
            this.txtDestinationPath.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBox1_DragDrop);
            this.txtDestinationPath.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBox1_DragEnter);
            // 
            // btnDest
            // 
            this.btnDest.Location = new System.Drawing.Point(331, 199);
            this.btnDest.Name = "btnDest";
            this.btnDest.Size = new System.Drawing.Size(25, 24);
            this.btnDest.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.btnDest.StateTracking.Back.Color2 = System.Drawing.Color.White;
            this.btnDest.StateTracking.Border.Color1 = System.Drawing.Color.White;
            this.btnDest.StateTracking.Border.Color2 = System.Drawing.Color.White;
            this.btnDest.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnDest.TabIndex = 3;
            this.btnDest.Tag = "Select your destination folder.";
            this.VaultToolTip.SetToolTip(this.btnDest, "Select your destination.");
            this.btnDest.Values.Text = "...";
            this.btnDest.Click += new System.EventHandler(this.btnDest_Click);
            // 
            // btnSource
            // 
            this.btnSource.Location = new System.Drawing.Point(331, 114);
            this.btnSource.Name = "btnSource";
            this.btnSource.Size = new System.Drawing.Size(25, 24);
            this.btnSource.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.btnSource.StateTracking.Back.Color2 = System.Drawing.Color.White;
            this.btnSource.StateTracking.Border.Color1 = System.Drawing.Color.White;
            this.btnSource.StateTracking.Border.Color2 = System.Drawing.Color.White;
            this.btnSource.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSource.TabIndex = 1;
            this.btnSource.Tag = "Select your source folder.";
            this.VaultToolTip.SetToolTip(this.btnSource, "Select your source");
            this.btnSource.Values.Text = "...";
            this.btnSource.Click += new System.EventHandler(this.btnSource_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(167, 283);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(90, 25);
            this.btnCopy.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.btnCopy.StateTracking.Back.Color2 = System.Drawing.Color.White;
            this.btnCopy.StateTracking.Border.Color1 = System.Drawing.Color.White;
            this.btnCopy.StateTracking.Border.Color2 = System.Drawing.Color.White;
            this.btnCopy.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCopy.TabIndex = 6;
            this.VaultToolTip.SetToolTip(this.btnCopy, "Once a source and destination is chosen this will start the copying.");
            this.btnCopy.Values.Text = "Copy";
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(80, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 31;
            this.label5.Text = "Destination";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(80, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 30;
            this.label4.Text = "Source";
            // 
            // chkOverwrite
            // 
            this.chkOverwrite.AutoSize = true;
            this.chkOverwrite.BackColor = System.Drawing.Color.Transparent;
            this.chkOverwrite.ForeColor = System.Drawing.Color.White;
            this.chkOverwrite.Location = new System.Drawing.Point(83, 245);
            this.chkOverwrite.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkOverwrite.Name = "chkOverwrite";
            this.chkOverwrite.Size = new System.Drawing.Size(118, 20);
            this.chkOverwrite.TabIndex = 4;
            this.chkOverwrite.Text = "Overwrite Files?";
            this.VaultToolTip.SetToolTip(this.chkOverwrite, "Overwrite existing files in the destination that match.");
            this.chkOverwrite.UseVisualStyleBackColor = false;
            // 
            // pgFormat
            // 
            this.pgFormat.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.pgFormat.Controls.Add(this.btnDriveDetails);
            this.pgFormat.Controls.Add(this.btnFormatDrive);
            this.pgFormat.Controls.Add(this.btnFileWipe);
            this.pgFormat.Controls.Add(this.groupBox1);
            this.pgFormat.Flags = 65534;
            this.pgFormat.LastVisibleSet = true;
            this.pgFormat.MinimumSize = new System.Drawing.Size(50, 50);
            this.pgFormat.Name = "pgFormat";
            this.pgFormat.Size = new System.Drawing.Size(451, 400);
            this.pgFormat.StateNormal.BorderEdge.Color1 = System.Drawing.Color.Transparent;
            this.pgFormat.StateNormal.BorderEdge.Color2 = System.Drawing.Color.Transparent;
            this.pgFormat.StateNormal.BorderEdge.Width = 0;
            this.pgFormat.StateNormal.Page.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(128)))));
            this.pgFormat.StateNormal.Page.Color2 = System.Drawing.Color.Transparent;
            this.pgFormat.StateNormal.Page.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.RoundedTopLight;
            this.pgFormat.StateSelected.Tab.Back.Color1 = System.Drawing.Color.White;
            this.pgFormat.StateSelected.Tab.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(128)))));
            this.pgFormat.StateSelected.Tab.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.GlassCheckedTrackingSimple;
            this.pgFormat.StateTracking.Tab.Back.Color1 = System.Drawing.Color.White;
            this.pgFormat.StateTracking.Tab.Back.Color2 = System.Drawing.Color.White;
            this.pgFormat.Text = "Format Drive";
            this.pgFormat.ToolTipTitle = "Page ToolTip";
            this.pgFormat.UniqueName = "0DEAA9D37C964860588DF4F994C9A431";
            // 
            // btnDriveDetails
            // 
            this.btnDriveDetails.Location = new System.Drawing.Point(293, 203);
            this.btnDriveDetails.Name = "btnDriveDetails";
            this.btnDriveDetails.Size = new System.Drawing.Size(104, 34);
            this.btnDriveDetails.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.btnDriveDetails.StateTracking.Back.Color2 = System.Drawing.Color.White;
            this.btnDriveDetails.StateTracking.Border.Color1 = System.Drawing.Color.White;
            this.btnDriveDetails.StateTracking.Border.Color2 = System.Drawing.Color.White;
            this.btnDriveDetails.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnDriveDetails.TabIndex = 13;
            this.VaultToolTip.SetToolTip(this.btnDriveDetails, "Used to display your drive details");
            this.btnDriveDetails.Values.Text = "Drive Details";
            this.btnDriveDetails.Click += new System.EventHandler(this.btnDriveDetails_Click);
            // 
            // btnFormatDrive
            // 
            this.btnFormatDrive.Location = new System.Drawing.Point(294, 107);
            this.btnFormatDrive.Name = "btnFormatDrive";
            this.btnFormatDrive.Size = new System.Drawing.Size(104, 34);
            this.btnFormatDrive.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.btnFormatDrive.StateTracking.Back.Color2 = System.Drawing.Color.White;
            this.btnFormatDrive.StateTracking.Border.Color1 = System.Drawing.Color.White;
            this.btnFormatDrive.StateTracking.Border.Color2 = System.Drawing.Color.White;
            this.btnFormatDrive.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnFormatDrive.TabIndex = 11;
            this.VaultToolTip.SetToolTip(this.btnFormatDrive, "Used to format drives in your system or removable.");
            this.btnFormatDrive.Values.Text = "Format Drive";
            this.btnFormatDrive.Click += new System.EventHandler(this.btnFormatDrive_Click);
            // 
            // btnFileWipe
            // 
            this.btnFileWipe.Location = new System.Drawing.Point(293, 155);
            this.btnFileWipe.Name = "btnFileWipe";
            this.btnFileWipe.Size = new System.Drawing.Size(105, 34);
            this.btnFileWipe.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.btnFileWipe.StateTracking.Back.Color2 = System.Drawing.Color.White;
            this.btnFileWipe.StateTracking.Border.Color1 = System.Drawing.Color.White;
            this.btnFileWipe.StateTracking.Border.Color2 = System.Drawing.Color.White;
            this.btnFileWipe.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnFileWipe.TabIndex = 12;
            this.VaultToolTip.SetToolTip(this.btnFileWipe, "Used to securely wipe a file from your system.");
            this.btnFileWipe.Values.Text = "File Wipe";
            this.btnFileWipe.Click += new System.EventHandler(this.btnFileWipe_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lstDrives);
            this.groupBox1.Controls.Add(this.lblDriveList);
            this.groupBox1.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(52, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 365);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Drive Information";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(17, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 17);
            this.label3.TabIndex = 35;
            this.label3.Text = "Please select a drive to format.";
            // 
            // lstDrives
            // 
            this.lstDrives.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.HeaderCustom1;
            this.lstDrives.BorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.HeaderForm;
            this.lstDrives.ItemStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Alternate;
            this.lstDrives.Location = new System.Drawing.Point(17, 83);
            this.lstDrives.Name = "lstDrives";
            this.lstDrives.Size = new System.Drawing.Size(199, 264);
            this.lstDrives.StateNormal.Item.Content.LongText.Color1 = System.Drawing.Color.White;
            this.lstDrives.StateNormal.Item.Content.LongText.Color2 = System.Drawing.Color.White;
            this.lstDrives.StateNormal.Item.Content.LongText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.lstDrives.TabIndex = 13;
            // 
            // lblDriveList
            // 
            this.lblDriveList.AutoSize = true;
            this.lblDriveList.BackColor = System.Drawing.Color.Transparent;
            this.lblDriveList.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDriveList.ForeColor = System.Drawing.Color.White;
            this.lblDriveList.Location = new System.Drawing.Point(53, 34);
            this.lblDriveList.Name = "lblDriveList";
            this.lblDriveList.Size = new System.Drawing.Size(107, 19);
            this.lblDriveList.TabIndex = 6;
            this.lblDriveList.Text = "List of Drives";
            // 
            // kryptonDockableNavigator1
            // 
            this.kryptonDockableNavigator1.AllowDrop = true;
            this.kryptonDockableNavigator1.Bar.BarOrientation = ComponentFactory.Krypton.Toolkit.VisualOrientation.Left;
            this.kryptonDockableNavigator1.Bar.ItemOrientation = ComponentFactory.Krypton.Toolkit.ButtonOrientation.FixedTop;
            this.kryptonDockableNavigator1.Bar.ItemSizing = ComponentFactory.Krypton.Navigator.BarItemSizing.SameWidthAndHeight;
            this.kryptonDockableNavigator1.Bar.TabBorderStyle = ComponentFactory.Krypton.Toolkit.TabBorderStyle.RoundedOutsizeLarge;
            this.kryptonDockableNavigator1.Button.ButtonDisplayLogic = ComponentFactory.Krypton.Navigator.ButtonDisplayLogic.None;
            this.kryptonDockableNavigator1.Button.CloseButtonAction = ComponentFactory.Krypton.Navigator.CloseButtonAction.None;
            this.kryptonDockableNavigator1.Button.CloseButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide;
            this.kryptonDockableNavigator1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonDockableNavigator1.Group.GroupBorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.HeaderForm;
            this.kryptonDockableNavigator1.Location = new System.Drawing.Point(0, 67);
            this.kryptonDockableNavigator1.Name = "kryptonDockableNavigator1";
            this.kryptonDockableNavigator1.PageBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.HeaderForm;
            this.kryptonDockableNavigator1.Pages.AddRange(new ComponentFactory.Krypton.Navigator.KryptonPage[] {
            this.pgBackup,
            this.pgFormat,
            this.pgSettings});
            this.kryptonDockableNavigator1.Panel.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.SeparatorHighProfile;
            this.kryptonDockableNavigator1.SelectedIndex = 2;
            this.kryptonDockableNavigator1.Size = new System.Drawing.Size(542, 401);
            this.kryptonDockableNavigator1.StateNormal.BorderEdge.Color1 = System.Drawing.Color.Transparent;
            this.kryptonDockableNavigator1.StateNormal.BorderEdge.Color2 = System.Drawing.Color.Transparent;
            this.kryptonDockableNavigator1.StateNormal.Panel.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.kryptonDockableNavigator1.StateNormal.Panel.Color2 = System.Drawing.Color.Transparent;
            this.kryptonDockableNavigator1.StateNormal.Panel.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.RoundedTopLight;
            this.kryptonDockableNavigator1.TabIndex = 0;
            this.kryptonDockableNavigator1.Text = "kryptonDockableNavigator1";
            // 
            // pgSettings
            // 
            this.pgSettings.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.pgSettings.Controls.Add(this.btnDefaultSettings);
            this.pgSettings.Controls.Add(this.groupBox4);
            this.pgSettings.Controls.Add(this.groupBox3);
            this.pgSettings.Controls.Add(this.groupBox2);
            this.pgSettings.Controls.Add(this.btnSaveSettings);
            this.pgSettings.Flags = 65534;
            this.pgSettings.LastVisibleSet = true;
            this.pgSettings.MinimumSize = new System.Drawing.Size(50, 50);
            this.pgSettings.Name = "pgSettings";
            this.pgSettings.Size = new System.Drawing.Size(456, 400);
            this.pgSettings.StateNormal.Page.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(128)))));
            this.pgSettings.StateNormal.Page.Color2 = System.Drawing.Color.Transparent;
            this.pgSettings.StateNormal.Page.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.RoundedTopLight;
            this.pgSettings.StateSelected.Tab.Back.Color1 = System.Drawing.Color.White;
            this.pgSettings.StateSelected.Tab.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(128)))));
            this.pgSettings.StateSelected.Tab.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.GlassCheckedTrackingFull;
            this.pgSettings.StateTracking.Tab.Back.Color1 = System.Drawing.Color.White;
            this.pgSettings.StateTracking.Tab.Back.Color2 = System.Drawing.Color.White;
            this.pgSettings.Text = "Settings";
            this.pgSettings.ToolTipTitle = "Page ToolTip";
            this.pgSettings.UniqueName = "F85C99860EEC408100ACDFC4029BAA62";
            // 
            // btnDefaultSettings
            // 
            this.btnDefaultSettings.Location = new System.Drawing.Point(15, 360);
            this.btnDefaultSettings.Name = "btnDefaultSettings";
            this.btnDefaultSettings.Size = new System.Drawing.Size(100, 25);
            this.btnDefaultSettings.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.btnDefaultSettings.StateTracking.Back.Color2 = System.Drawing.Color.White;
            this.btnDefaultSettings.StateTracking.Border.Color1 = System.Drawing.Color.White;
            this.btnDefaultSettings.StateTracking.Border.Color2 = System.Drawing.Color.White;
            this.btnDefaultSettings.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnDefaultSettings.TabIndex = 44;
            this.VaultToolTip.SetToolTip(this.btnDefaultSettings, "Returns settings to the default settings");
            this.btnDefaultSettings.Values.Text = "Default Settings";
            this.btnDefaultSettings.Click += new System.EventHandler(this.btnDefaultSettings_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.chkDateTimeStamp);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.btnDefaultSource);
            this.groupBox4.Controls.Add(this.txtDefaultSource);
            this.groupBox4.Controls.Add(this.dateTimeAutoBackup);
            this.groupBox4.Controls.Add(this.chkAutoBackup);
            this.groupBox4.Controls.Add(this.btnDefaultDest);
            this.groupBox4.Controls.Add(this.txtDefaultDest);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(15, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(430, 134);
            this.groupBox4.TabIndex = 43;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Back Up Settings";
            // 
            // chkDateTimeStamp
            // 
            this.chkDateTimeStamp.AutoSize = true;
            this.chkDateTimeStamp.Location = new System.Drawing.Point(17, 102);
            this.chkDateTimeStamp.Name = "chkDateTimeStamp";
            this.chkDateTimeStamp.Size = new System.Drawing.Size(143, 20);
            this.chkDateTimeStamp.TabIndex = 41;
            this.chkDateTimeStamp.Text = "Folder Time Stamp?";
            this.VaultToolTip.SetToolTip(this.chkDateTimeStamp, "When checked adds a time stamp to the copied folder. Will take more space!");
            this.chkDateTimeStamp.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(10, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 16);
            this.label9.TabIndex = 41;
            this.label9.Text = "Source";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(14, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 16);
            this.label7.TabIndex = 40;
            this.label7.Text = "Dest";
            // 
            // btnDefaultSource
            // 
            this.btnDefaultSource.Location = new System.Drawing.Point(311, 23);
            this.btnDefaultSource.Name = "btnDefaultSource";
            this.btnDefaultSource.Size = new System.Drawing.Size(25, 24);
            this.btnDefaultSource.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.btnDefaultSource.StateTracking.Back.Color2 = System.Drawing.Color.White;
            this.btnDefaultSource.StateTracking.Border.Color1 = System.Drawing.Color.White;
            this.btnDefaultSource.StateTracking.Border.Color2 = System.Drawing.Color.White;
            this.btnDefaultSource.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnDefaultSource.TabIndex = 39;
            this.btnDefaultSource.Tag = "Select your source folder";
            this.VaultToolTip.SetToolTip(this.btnDefaultSource, "Select your destination.");
            this.btnDefaultSource.Values.Text = "...";
            this.btnDefaultSource.Click += new System.EventHandler(this.btnDefaultSource_Click);
            // 
            // txtDefaultSource
            // 
            this.txtDefaultSource.Enabled = false;
            this.txtDefaultSource.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDefaultSource.Location = new System.Drawing.Point(64, 23);
            this.txtDefaultSource.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDefaultSource.Name = "txtDefaultSource";
            this.txtDefaultSource.Size = new System.Drawing.Size(248, 25);
            this.txtDefaultSource.TabIndex = 38;
            // 
            // dateTimeAutoBackup
            // 
            this.dateTimeAutoBackup.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimeAutoBackup.Location = new System.Drawing.Point(310, 97);
            this.dateTimeAutoBackup.Name = "dateTimeAutoBackup";
            this.dateTimeAutoBackup.Size = new System.Drawing.Size(114, 25);
            this.dateTimeAutoBackup.TabIndex = 37;
            this.VaultToolTip.SetToolTip(this.dateTimeAutoBackup, "Please choose which time you would like the backup to occur. Date does not matter" +
        ".");
            this.dateTimeAutoBackup.Visible = false;
            // 
            // chkAutoBackup
            // 
            this.chkAutoBackup.AutoSize = true;
            this.chkAutoBackup.Location = new System.Drawing.Point(205, 102);
            this.chkAutoBackup.Name = "chkAutoBackup";
            this.chkAutoBackup.Size = new System.Drawing.Size(99, 20);
            this.chkAutoBackup.TabIndex = 36;
            this.chkAutoBackup.Text = "Auto Backup";
            this.VaultToolTip.SetToolTip(this.chkAutoBackup, "When checked will ask user to setup auto backup.");
            this.chkAutoBackup.UseVisualStyleBackColor = true;
            this.chkAutoBackup.CheckedChanged += new System.EventHandler(this.chkAutoBackup_CheckedChanged);
            // 
            // btnDefaultDest
            // 
            this.btnDefaultDest.Location = new System.Drawing.Point(310, 64);
            this.btnDefaultDest.Name = "btnDefaultDest";
            this.btnDefaultDest.Size = new System.Drawing.Size(25, 24);
            this.btnDefaultDest.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.btnDefaultDest.StateTracking.Back.Color2 = System.Drawing.Color.White;
            this.btnDefaultDest.StateTracking.Border.Color1 = System.Drawing.Color.White;
            this.btnDefaultDest.StateTracking.Border.Color2 = System.Drawing.Color.White;
            this.btnDefaultDest.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnDefaultDest.TabIndex = 35;
            this.btnDefaultDest.Tag = "Select your destination folder";
            this.VaultToolTip.SetToolTip(this.btnDefaultDest, "Select your destination.");
            this.btnDefaultDest.Values.Text = "...";
            this.btnDefaultDest.Click += new System.EventHandler(this.btnDefaultDest_Click);
            // 
            // txtDefaultDest
            // 
            this.txtDefaultDest.Enabled = false;
            this.txtDefaultDest.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDefaultDest.Location = new System.Drawing.Point(63, 64);
            this.txtDefaultDest.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDefaultDest.Name = "txtDefaultDest";
            this.txtDefaultDest.Size = new System.Drawing.Size(248, 25);
            this.txtDefaultDest.TabIndex = 34;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.chkOverwriteSetting);
            this.groupBox3.Controls.Add(this.chkOnlyUSB);
            this.groupBox3.Controls.Add(this.chkStartOnStartup);
            this.groupBox3.Controls.Add(this.chkDriveDetection);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(15, 142);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(430, 113);
            this.groupBox3.TabIndex = 42;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Global Settings";
            // 
            // chkOverwriteSetting
            // 
            this.chkOverwriteSetting.AutoSize = true;
            this.chkOverwriteSetting.Location = new System.Drawing.Point(192, 76);
            this.chkOverwriteSetting.Name = "chkOverwriteSetting";
            this.chkOverwriteSetting.Size = new System.Drawing.Size(143, 20);
            this.chkOverwriteSetting.TabIndex = 40;
            this.chkOverwriteSetting.Text = "Overwrite Old Files?";
            this.VaultToolTip.SetToolTip(this.chkOverwriteSetting, "When checked old files will be overwritten.");
            this.chkOverwriteSetting.UseVisualStyleBackColor = true;
            // 
            // chkOnlyUSB
            // 
            this.chkOnlyUSB.AutoSize = true;
            this.chkOnlyUSB.Location = new System.Drawing.Point(13, 76);
            this.chkOnlyUSB.Name = "chkOnlyUSB";
            this.chkOnlyUSB.Size = new System.Drawing.Size(173, 20);
            this.chkOnlyUSB.TabIndex = 39;
            this.chkOnlyUSB.Text = "Format Removable Only?";
            this.VaultToolTip.SetToolTip(this.chkOnlyUSB, "When checked only removable media will be eligible for backup.");
            this.chkOnlyUSB.UseVisualStyleBackColor = true;
            // 
            // chkStartOnStartup
            // 
            this.chkStartOnStartup.AutoSize = true;
            this.chkStartOnStartup.BackColor = System.Drawing.Color.Transparent;
            this.chkStartOnStartup.ForeColor = System.Drawing.Color.White;
            this.chkStartOnStartup.Location = new System.Drawing.Point(13, 24);
            this.chkStartOnStartup.Name = "chkStartOnStartup";
            this.chkStartOnStartup.Size = new System.Drawing.Size(129, 20);
            this.chkStartOnStartup.TabIndex = 37;
            this.chkStartOnStartup.Text = "Open on startup?";
            this.VaultToolTip.SetToolTip(this.chkStartOnStartup, "When checked the program will start on computer startup.");
            this.chkStartOnStartup.UseVisualStyleBackColor = false;
            // 
            // chkDriveDetection
            // 
            this.chkDriveDetection.AutoSize = true;
            this.chkDriveDetection.BackColor = System.Drawing.Color.Transparent;
            this.chkDriveDetection.ForeColor = System.Drawing.Color.White;
            this.chkDriveDetection.Location = new System.Drawing.Point(13, 50);
            this.chkDriveDetection.Name = "chkDriveDetection";
            this.chkDriveDetection.Size = new System.Drawing.Size(116, 20);
            this.chkDriveDetection.TabIndex = 38;
            this.chkDriveDetection.Text = "Drive Detection";
            this.VaultToolTip.SetToolTip(this.chkDriveDetection, "When checked USB detection is turned on");
            this.chkDriveDetection.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.numUpDownFileWipe);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(15, 260);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(430, 94);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "File Wipe";
            // 
            // numUpDownFileWipe
            // 
            this.numUpDownFileWipe.Location = new System.Drawing.Point(17, 50);
            this.numUpDownFileWipe.Name = "numUpDownFileWipe";
            this.numUpDownFileWipe.Size = new System.Drawing.Size(61, 25);
            this.numUpDownFileWipe.TabIndex = 39;
            this.VaultToolTip.SetToolTip(this.numUpDownFileWipe, "Number of passes you would like to run the file shredder.");
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(14, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(295, 16);
            this.label8.TabIndex = 40;
            this.label8.Text = "Please set the number of passes for the file wipe.";
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Location = new System.Drawing.Point(355, 360);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(90, 25);
            this.btnSaveSettings.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.btnSaveSettings.StateTracking.Back.Color2 = System.Drawing.Color.White;
            this.btnSaveSettings.StateTracking.Border.Color1 = System.Drawing.Color.White;
            this.btnSaveSettings.StateTracking.Border.Color2 = System.Drawing.Color.White;
            this.btnSaveSettings.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSaveSettings.TabIndex = 0;
            this.VaultToolTip.SetToolTip(this.btnSaveSettings, "Saves Settings");
            this.btnSaveSettings.Values.Text = "Save Settings";
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnMinimize.Location = new System.Drawing.Point(494, 14);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(15, 15);
            this.btnMinimize.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.btnMinimize.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.btnMinimize.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.btnMinimize.TabIndex = 0;
            this.VaultToolTip.SetToolTip(this.btnMinimize, "Minimize");
            this.btnMinimize.Values.Text = "Copy";
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // panHeader
            // 
            this.panHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.panHeader.Controls.Add(this.pictureBox1);
            this.panHeader.Controls.Add(this.btnExit);
            this.panHeader.Controls.Add(this.btnMinimize);
            this.panHeader.Controls.Add(this.lblTitle);
            this.panHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panHeader.Location = new System.Drawing.Point(0, 0);
            this.panHeader.Name = "panHeader";
            this.panHeader.Size = new System.Drawing.Size(542, 43);
            this.panHeader.TabIndex = 16;
            this.panHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseDown);
            this.panHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseMove);
            this.panHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::VaultBackup.Properties.Resources.VaultIcon;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 37);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnExit.Location = new System.Drawing.Point(515, 14);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(15, 15);
            this.btnExit.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(108)))), ((int)(((byte)(77)))));
            this.btnExit.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(108)))), ((int)(((byte)(77)))));
            this.btnExit.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(108)))), ((int)(((byte)(77)))));
            this.btnExit.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnExit.TabIndex = 1;
            this.VaultToolTip.SetToolTip(this.btnExit, "Close");
            this.btnExit.Values.Text = "Copy";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(46, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(110, 19);
            this.lblTitle.TabIndex = 21;
            this.lblTitle.Text = "Vault Backup";
            // 
            // notifyTrayIcon
            // 
            this.notifyTrayIcon.ContextMenuStrip = this.contexVault;
            this.notifyTrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyTrayIcon.Icon")));
            this.notifyTrayIcon.Text = "Vault Backup";
            this.notifyTrayIcon.Visible = true;
            this.notifyTrayIcon.DoubleClick += new System.EventHandler(this.notifyTrayIcon_DoubleClick);
            // 
            // contexVault
            // 
            this.contexVault.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.contexVault.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contexVault.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restoreToolStripMenuItem,
            this.closeApplicationToolStripMenuItem});
            this.contexVault.Name = "contexVault";
            this.contexVault.Size = new System.Drawing.Size(168, 48);
            // 
            // restoreToolStripMenuItem
            // 
            this.restoreToolStripMenuItem.Name = "restoreToolStripMenuItem";
            this.restoreToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.restoreToolStripMenuItem.Text = "Restore";
            this.restoreToolStripMenuItem.Click += new System.EventHandler(this.restoreToolStripMenuItem_Click);
            // 
            // closeApplicationToolStripMenuItem
            // 
            this.closeApplicationToolStripMenuItem.Name = "closeApplicationToolStripMenuItem";
            this.closeApplicationToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.closeApplicationToolStripMenuItem.Text = "Close Application";
            this.closeApplicationToolStripMenuItem.Click += new System.EventHandler(this.closeApplicationToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 43);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(542, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            // 
            // bgWorkerCopy
            // 
            this.bgWorkerCopy.WorkerReportsProgress = true;
            this.bgWorkerCopy.WorkerSupportsCancellation = true;
            this.bgWorkerCopy.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorkerCopy_DoWork);
            this.bgWorkerCopy.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorkerCopy_RunWorkerCompleted);
            // 
            // bgWorkerFormat
            // 
            this.bgWorkerFormat.WorkerReportsProgress = true;
            this.bgWorkerFormat.WorkerSupportsCancellation = true;
            // 
            // frmMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(542, 468);
            this.Controls.Add(this.kryptonDockableNavigator1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panHeader);
            this.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pgBackup)).EndInit();
            this.pgBackup.ResumeLayout(false);
            this.pgBackup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pgFormat)).EndInit();
            this.pgFormat.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDockableNavigator1)).EndInit();
            this.kryptonDockableNavigator1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pgSettings)).EndInit();
            this.pgSettings.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownFileWipe)).EndInit();
            this.panHeader.ResumeLayout(false);
            this.panHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contexVault.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private ComponentFactory.Krypton.Navigator.KryptonPage pgBackup;
        private ComponentFactory.Krypton.Navigator.KryptonPage pgFormat;
        private ComponentFactory.Krypton.Docking.KryptonDockableNavigator kryptonDockableNavigator1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnMinimize;
        private System.Windows.Forms.Panel panHeader;
        private System.Windows.Forms.Label lblTitle;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnExit;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCopy;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtDestinationPath;
        public System.Windows.Forms.TextBox txtSourcePath;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnDest;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSource;
        public System.Windows.Forms.CheckBox chkOverwrite;
        private System.Windows.Forms.GroupBox groupBox1;
        public ComponentFactory.Krypton.Toolkit.KryptonListBox lstDrives;
        private System.Windows.Forms.Label lblDriveList;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnFormatDrive;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnFileWipe;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip VaultToolTip;
        public System.Windows.Forms.CheckBox chkSaveDest;
        private ComponentFactory.Krypton.Navigator.KryptonPage pgSettings;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSaveSettings;
        public System.Windows.Forms.TextBox txtDefaultDest;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnDefaultDest;
        private System.Windows.Forms.NotifyIcon notifyTrayIcon;
        private System.Windows.Forms.ContextMenuStrip contexVault;
        private System.Windows.Forms.ToolStripMenuItem restoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeApplicationToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnDriveDetails;
        public System.ComponentModel.BackgroundWorker bgWorkerCopy;
        public System.ComponentModel.BackgroundWorker bgWorkerFormat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnDefaultSource;
        public System.Windows.Forms.TextBox txtDefaultSource;
        public System.Windows.Forms.CheckBox chkStartOnStartup;
        public System.Windows.Forms.CheckBox chkDriveDetection;
        public System.Windows.Forms.NumericUpDown numUpDownFileWipe;
        public System.Windows.Forms.CheckBox chkOnlyUSB;
        public System.Windows.Forms.CheckBox chkOverwriteSetting;
        public System.Windows.Forms.DateTimePicker dateTimeAutoBackup;
        public System.Windows.Forms.CheckBox chkAutoBackup;
        public System.Windows.Forms.CheckBox chkDateTimeStamp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnDefaultSettings;
    }
}

