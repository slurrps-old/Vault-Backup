using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vault_Backup.Class;
using Vault_Backup.Properties;

namespace Vault_Backup.Forms
{
    public partial class frmProgress : Form
    {
        #region Private Variables
        //Variables for the backup method
        private string source = ""; //Save the source to be copied
        private string dest = ""; //Save the destination to copy to
        private bool isChecked = false; //See if you are overwriting the files that match already in the desination
        private string date;
        #endregion

        public frmProgress()
        {
            InitializeComponent();
        }

        #region Methods
        public void GetDate()
        {
            //Get the current date
            date = DateTime.Today.ToString("MM-dd-yyyy");
            //Remove the / and replace them with -
            date = date.Replace("/", "-");
        }
        #endregion

        #region Events
        private void frmProgress_Load(object sender, EventArgs e)
        {
            //Grab the Settings from the program
            source = Settings.Default.Source;
            dest = Settings.Default.Dest;
            isChecked = Settings.Default.Overwrite;
            Settings.Default.Cancel = false;

            //Grab the current date
            GetDate();

            //Get Size of the amount of files being copied
            BackupClass.GetDirectorySize(source, true);

            //Set the static labels of the form
            lblTotalSizeCopied.Text = "Total Size: " + BackupClass.totalSizeToCopy;
            lblDirectories.Text = "Folders: " + BackupClass.totalDirectories;
            lblTitle.Text = "Copying: " + BackupClass.totalFiles + " items from " + Settings.Default.Source 
                + " to " + Settings.Default.Dest;//Set the title of the progress form

            //Start the backgroung worker
            bgWorkerCopying.RunWorkerAsync();
        }

        private void bgWorkerCopying_DoWork(object sender, DoWorkEventArgs e)
        {
            //Get the end folder name of the source
            string folderToBeCopied = new DirectoryInfo(source).Name;

            //Create a directory for the folder that is copied
            //Check if the folder selected is the drive name
            if (folderToBeCopied.Contains(":"))
            {
                //If it is set the folderToBeCopied variable to the drive letter
                DriveInfo di = new DriveInfo(source);
                folderToBeCopied = di.VolumeLabel;
            }

            //Check if timestamp setting is true
            if(Settings.Default.TimeStamp)
            {
                //Call the directoryCopy method giving the source and destination , bool copy sub directories, bool overwrite, this form
                BackupClass.DirectoryCopy(source, dest + @"\" + date + " " + folderToBeCopied, true, isChecked, this);
            }
            else
            {
                //Call the directoryCopy method giving the source and destination , bool copy sub directories, bool overwrite, this form
                BackupClass.DirectoryCopy(source, dest + @"\" + folderToBeCopied, true, isChecked, this);
            }
            
        }

        private void bgWorkerCopying_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //Test Message
            //Show completion message
            MessageBox.Show("Backup Complete " + source + " has been copied to " + dest + "." +
                Environment.NewLine + "Files Copied " + BackupClass.totalFiles.ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Cancel the background worker
            bgWorkerCopying.CancelAsync();

            ////Clear the variables from the backup class
            BackupClass.totalFiles = 0;
            BackupClass.currFile = 0;
            BackupClass.totalSize = 0;
            BackupClass.totalDirectories = 0;
            BackupClass.filesNotCopied = 0;
            BackupClass.totalFilesCopied = 0;
            BackupClass.totalFiles = 0;

            //Close the form
            this.Close();
        }

        
        private void frmProgress_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.Cancel = true;
            bgWorkerCopying.CancelAsync();
        }
        #endregion
    }
}
