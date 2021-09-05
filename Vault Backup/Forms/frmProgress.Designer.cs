
namespace Vault_Backup.Forms
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
            this.lblFilesSkipped = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPercentComplete = new System.Windows.Forms.Label();
            this.lblFiles = new System.Windows.Forms.Label();
            this.lblCurrentFile = new System.Windows.Forms.Label();
            this.progCurrentFile = new System.Windows.Forms.ProgressBar();
            this.lblTotalSizeCopied = new System.Windows.Forms.Label();
            this.bgWorkerCopying = new System.ComponentModel.BackgroundWorker();
            this.lblDirectories = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFilesSkipped
            // 
            this.lblFilesSkipped.AutoSize = true;
            this.lblFilesSkipped.BackColor = System.Drawing.Color.Transparent;
            this.lblFilesSkipped.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilesSkipped.ForeColor = System.Drawing.Color.Black;
            this.lblFilesSkipped.Location = new System.Drawing.Point(13, 158);
            this.lblFilesSkipped.Name = "lblFilesSkipped";
            this.lblFilesSkipped.Size = new System.Drawing.Size(84, 16);
            this.lblFilesSkipped.TabIndex = 40;
            this.lblFilesSkipped.Text = "Skipped Files";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(76, 16);
            this.lblTitle.TabIndex = 39;
            this.lblTitle.Text = "Copying ##";
            // 
            // lblPercentComplete
            // 
            this.lblPercentComplete.AutoSize = true;
            this.lblPercentComplete.BackColor = System.Drawing.Color.Transparent;
            this.lblPercentComplete.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentComplete.ForeColor = System.Drawing.Color.Black;
            this.lblPercentComplete.Location = new System.Drawing.Point(10, 34);
            this.lblPercentComplete.Name = "lblPercentComplete";
            this.lblPercentComplete.Size = new System.Drawing.Size(112, 22);
            this.lblPercentComplete.TabIndex = 38;
            this.lblPercentComplete.Text = "% Complete";
            // 
            // lblFiles
            // 
            this.lblFiles.AutoSize = true;
            this.lblFiles.BackColor = System.Drawing.Color.Transparent;
            this.lblFiles.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiles.ForeColor = System.Drawing.Color.Black;
            this.lblFiles.Location = new System.Drawing.Point(13, 133);
            this.lblFiles.Name = "lblFiles";
            this.lblFiles.Size = new System.Drawing.Size(33, 16);
            this.lblFiles.TabIndex = 37;
            this.lblFiles.Text = "Files";
            // 
            // lblCurrentFile
            // 
            this.lblCurrentFile.AutoSize = true;
            this.lblCurrentFile.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentFile.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentFile.ForeColor = System.Drawing.Color.Black;
            this.lblCurrentFile.Location = new System.Drawing.Point(12, 108);
            this.lblCurrentFile.Name = "lblCurrentFile";
            this.lblCurrentFile.Size = new System.Drawing.Size(74, 16);
            this.lblCurrentFile.TabIndex = 36;
            this.lblCurrentFile.Text = "Current File";
            // 
            // progCurrentFile
            // 
            this.progCurrentFile.Location = new System.Drawing.Point(12, 65);
            this.progCurrentFile.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.progCurrentFile.Name = "progCurrentFile";
            this.progCurrentFile.Size = new System.Drawing.Size(553, 34);
            this.progCurrentFile.TabIndex = 35;
            // 
            // lblTotalSizeCopied
            // 
            this.lblTotalSizeCopied.AutoSize = true;
            this.lblTotalSizeCopied.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalSizeCopied.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSizeCopied.ForeColor = System.Drawing.Color.Black;
            this.lblTotalSizeCopied.Location = new System.Drawing.Point(439, 9);
            this.lblTotalSizeCopied.Name = "lblTotalSizeCopied";
            this.lblTotalSizeCopied.Size = new System.Drawing.Size(67, 16);
            this.lblTotalSizeCopied.TabIndex = 41;
            this.lblTotalSizeCopied.Text = "Total Size:";
            // 
            // bgWorkerCopying
            // 
            this.bgWorkerCopying.WorkerSupportsCancellation = true;
            this.bgWorkerCopying.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorkerCopying_DoWork);
            this.bgWorkerCopying.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorkerCopying_RunWorkerCompleted);
            // 
            // lblDirectories
            // 
            this.lblDirectories.AutoSize = true;
            this.lblDirectories.BackColor = System.Drawing.Color.Transparent;
            this.lblDirectories.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirectories.ForeColor = System.Drawing.Color.Black;
            this.lblDirectories.Location = new System.Drawing.Point(13, 179);
            this.lblDirectories.Name = "lblDirectories";
            this.lblDirectories.Size = new System.Drawing.Size(54, 16);
            this.lblDirectories.TabIndex = 42;
            this.lblDirectories.Text = "Folders:";
            // 
            // frmProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 204);
            this.Controls.Add(this.lblDirectories);
            this.Controls.Add(this.lblTotalSizeCopied);
            this.Controls.Add(this.lblFilesSkipped);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblPercentComplete);
            this.Controls.Add(this.lblFiles);
            this.Controls.Add(this.lblCurrentFile);
            this.Controls.Add(this.progCurrentFile);
            this.Name = "frmProgress";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProgress";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmProgress_FormClosing);
            this.Load += new System.EventHandler(this.frmProgress_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblFilesSkipped;
        public System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.Label lblPercentComplete;
        public System.Windows.Forms.Label lblFiles;
        public System.Windows.Forms.Label lblCurrentFile;
        public System.Windows.Forms.ProgressBar progCurrentFile;
        public System.Windows.Forms.Label lblTotalSizeCopied;
        private System.ComponentModel.BackgroundWorker bgWorkerCopying;
        public System.Windows.Forms.Label lblDirectories;
    }
}