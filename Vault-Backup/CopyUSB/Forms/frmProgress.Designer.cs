namespace CopyUSB
{
    partial class frmProgress
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProgress));
            this.panHeader = new System.Windows.Forms.Panel();
            this.btnExit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblTotalSizeCopied = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bgWorkerCopying = new System.ComponentModel.BackgroundWorker();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.lblFilesSkipped = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPercentComplete = new System.Windows.Forms.Label();
            this.lblFiles = new System.Windows.Forms.Label();
            this.lblCurrentFile = new System.Windows.Forms.Label();
            this.progCurrentFile = new System.Windows.Forms.ProgressBar();
            this.panHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panHeader
            // 
            this.panHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.panHeader.Controls.Add(this.btnExit);
            this.panHeader.Controls.Add(this.lblTotalSizeCopied);
            this.panHeader.Controls.Add(this.label1);
            this.panHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panHeader.Location = new System.Drawing.Point(0, 0);
            this.panHeader.Name = "panHeader";
            this.panHeader.Size = new System.Drawing.Size(579, 43);
            this.panHeader.TabIndex = 17;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnExit.Location = new System.Drawing.Point(552, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(15, 15);
            this.btnExit.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(108)))), ((int)(((byte)(77)))));
            this.btnExit.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(108)))), ((int)(((byte)(77)))));
            this.btnExit.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(108)))), ((int)(((byte)(77)))));
            this.btnExit.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnExit.TabIndex = 35;
            this.btnExit.Values.Text = "Copy";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTotalSizeCopied
            // 
            this.lblTotalSizeCopied.AutoSize = true;
            this.lblTotalSizeCopied.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalSizeCopied.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSizeCopied.ForeColor = System.Drawing.Color.White;
            this.lblTotalSizeCopied.Location = new System.Drawing.Point(194, 14);
            this.lblTotalSizeCopied.Name = "lblTotalSizeCopied";
            this.lblTotalSizeCopied.Size = new System.Drawing.Size(67, 16);
            this.lblTotalSizeCopied.TabIndex = 34;
            this.lblTotalSizeCopied.Text = "Total Size:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 19);
            this.label1.TabIndex = 22;
            this.label1.Text = "Vault Backup";
            // 
            // bgWorkerCopying
            // 
            this.bgWorkerCopying.WorkerReportsProgress = true;
            this.bgWorkerCopying.WorkerSupportsCancellation = true;
            this.bgWorkerCopying.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.bgWorkerCopying.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.bgWorkerCopying.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.lblFilesSkipped);
            this.kryptonPanel1.Controls.Add(this.lblTitle);
            this.kryptonPanel1.Controls.Add(this.lblPercentComplete);
            this.kryptonPanel1.Controls.Add(this.lblFiles);
            this.kryptonPanel1.Controls.Add(this.lblCurrentFile);
            this.kryptonPanel1.Controls.Add(this.progCurrentFile);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 43);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(579, 193);
            this.kryptonPanel1.StateNormal.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(128)))));
            this.kryptonPanel1.StateNormal.Color2 = System.Drawing.Color.Transparent;
            this.kryptonPanel1.StateNormal.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.RoundedTopLight;
            this.kryptonPanel1.TabIndex = 18;
            // 
            // lblFilesSkipped
            // 
            this.lblFilesSkipped.AutoSize = true;
            this.lblFilesSkipped.BackColor = System.Drawing.Color.Transparent;
            this.lblFilesSkipped.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilesSkipped.ForeColor = System.Drawing.Color.White;
            this.lblFilesSkipped.Location = new System.Drawing.Point(13, 164);
            this.lblFilesSkipped.Name = "lblFilesSkipped";
            this.lblFilesSkipped.Size = new System.Drawing.Size(84, 16);
            this.lblFilesSkipped.TabIndex = 34;
            this.lblFilesSkipped.Text = "Skipped Files";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(12, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(76, 16);
            this.lblTitle.TabIndex = 33;
            this.lblTitle.Text = "Copying ##";
            // 
            // lblPercentComplete
            // 
            this.lblPercentComplete.AutoSize = true;
            this.lblPercentComplete.BackColor = System.Drawing.Color.Transparent;
            this.lblPercentComplete.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentComplete.ForeColor = System.Drawing.Color.White;
            this.lblPercentComplete.Location = new System.Drawing.Point(10, 40);
            this.lblPercentComplete.Name = "lblPercentComplete";
            this.lblPercentComplete.Size = new System.Drawing.Size(112, 22);
            this.lblPercentComplete.TabIndex = 32;
            this.lblPercentComplete.Text = "% Complete";
            // 
            // lblFiles
            // 
            this.lblFiles.AutoSize = true;
            this.lblFiles.BackColor = System.Drawing.Color.Transparent;
            this.lblFiles.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiles.ForeColor = System.Drawing.Color.White;
            this.lblFiles.Location = new System.Drawing.Point(13, 139);
            this.lblFiles.Name = "lblFiles";
            this.lblFiles.Size = new System.Drawing.Size(33, 16);
            this.lblFiles.TabIndex = 31;
            this.lblFiles.Text = "Files";
            // 
            // lblCurrentFile
            // 
            this.lblCurrentFile.AutoSize = true;
            this.lblCurrentFile.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentFile.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentFile.ForeColor = System.Drawing.Color.White;
            this.lblCurrentFile.Location = new System.Drawing.Point(12, 114);
            this.lblCurrentFile.Name = "lblCurrentFile";
            this.lblCurrentFile.Size = new System.Drawing.Size(74, 16);
            this.lblCurrentFile.TabIndex = 30;
            this.lblCurrentFile.Text = "Current File";
            // 
            // progCurrentFile
            // 
            this.progCurrentFile.Location = new System.Drawing.Point(12, 71);
            this.progCurrentFile.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.progCurrentFile.Name = "progCurrentFile";
            this.progCurrentFile.Size = new System.Drawing.Size(553, 34);
            this.progCurrentFile.TabIndex = 29;
            // 
            // frmProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(579, 236);
            this.Controls.Add(this.kryptonPanel1);
            this.Controls.Add(this.panHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProgress";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProgress";
            this.Load += new System.EventHandler(this.frmProgress_Load);
            this.panHeader.ResumeLayout(false);
            this.panHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panHeader;
        public System.ComponentModel.BackgroundWorker bgWorkerCopying;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        public System.Windows.Forms.Label lblFiles;
        public System.Windows.Forms.Label lblCurrentFile;
        public System.Windows.Forms.ProgressBar progCurrentFile;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblTotalSizeCopied;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnExit;
        public System.Windows.Forms.Label lblPercentComplete;
        public System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.Label lblFilesSkipped;
    }
}