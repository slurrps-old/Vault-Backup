using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace CopyUSB
{
    public partial class frmProgress : KryptonForm
    {
        
        //Set a new instance of the backup class
        BackupClass Backup = new BackupClass();

        //Variables for the backup method
        private string source = ""; //Save the source to be copied
        private string dest = ""; //Save the destination to copy to
        private bool isChecked = false; //See if you are overwriting the files that match already in the desination

        public frmProgress()
        {
            InitializeComponent();
        }

        private void frmProgress_Load(object sender, EventArgs e)
        {
            //Grab the Settings from the program
            source = VaultBackup.Properties.Settings.Default.Source;
            dest = VaultBackup.Properties.Settings.Default.Dest;
            isChecked = VaultBackup.Properties.Settings.Default.Overwrite;
            VaultBackup.Properties.Settings.Default.Cancel = false;

            //Get Size of the amount of files being copied
            Backup.GetDirectorySize(source, true, this);
            //Start the backgroung worker
            bgWorkerCopying.RunWorkerAsync();
        }//End frmProgress_Load

        #region Background worker
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            //Get the current date
            string date = DateTime.Today.ToString("MM-dd-yyyy");
            //Remove the / and replace them with -
            date = date.Replace("/", "-");

            //Get the end folder name of the source
            string folderToBeCopied = new DirectoryInfo(source).Name;

            //Check if timestamp property is false or true if true create a new Directory
            if(VaultBackup.Properties.Settings.Default.TimeStamp == true)
            {
                //Create a new directory in the destination path called Backup "date"
                Directory.CreateDirectory(dest + @"\Backup " + date);
            }
            
            //Create a directory for the folder that is copied
            //Check if the folder selected is the drive name
            if (folderToBeCopied.Contains(":"))
            {
                //If it is set the folderToBeCopied variable to the drive letter
                DriveInfo di = new DriveInfo(source);
                folderToBeCopied = di.VolumeLabel;
            }
            else
            {
                if (VaultBackup.Properties.Settings.Default.TimeStamp == true)
                {
                    //Create Directory inside the new Backup + date directory copied from source
                    Directory.CreateDirectory(dest + @"\Backup " + date + @"\" + folderToBeCopied);
                }
                else
                {
                    //Create Directory inside destination copied from source
                    Directory.CreateDirectory(dest + @"\" + folderToBeCopied);
                }
               
            }

            if (VaultBackup.Properties.Settings.Default.TimeStamp == true)
            {
                //Call the DirectoryCopy method from the class
                Backup.DirectoryCopy(source, dest + @"\Backup " + date + @"\" + folderToBeCopied, true, isChecked, this);
            }
            else
            {
                //Call the DirectoryCopy method from the class
                Backup.DirectoryCopy(source, dest + @"\" + folderToBeCopied, true, isChecked, this);
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //Show completion message
            MessageBox.Show("Backup Complete " + source + " has been copied to " + dest + "." +
                Environment.NewLine + "Files Copied " + Backup.totalFilesCopied.ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //Cancel the background worker
            bgWorkerCopying.CancelAsync();
           //Clear the variables from the backup class
            Backup.totalFilesCopied = 0;
            Backup.totalFiles = 0;
            Backup.currFile = 0;
            //Close the form
            this.Close();
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //None
        }


        #endregion

        private void btnExit_Click(object sender, EventArgs e)
        {
            VaultBackup.Properties.Settings.Default.Cancel = true;
            //this.bgWorkerCopying.CancelAsync();
            MessageBox.Show("Process Aborted!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.Close();
        }
    }
}
