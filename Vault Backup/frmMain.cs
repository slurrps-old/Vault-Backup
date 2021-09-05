using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vault_Backup.Class;
using Vault_Backup.Forms;
using Vault_Backup.Properties;

namespace Vault_Backup
{
    public partial class frmMain : Form
    {
        #region Forms
        //This form reports on the progress of the backup utility
        frmProgress progress = new frmProgress();

        #endregion

        #region Public Variables
        //Creates a system Timer
        public System.Timers.Timer systemTimer;

        #region Format Variables
        //Set all of the public variables

        //Holds the drive letter
        public string formatDriveLetter = "";  // C:
        //Holds the VolumeLabel of the drive 
        public string volumeLabel = ""; // New Volume
        //Bool for quick formatting  
        public bool quickFormat = true; // true / false
        //Holds the fileSystem 
        public string fileSystem = ""; // NTFS / FAT32 / exFAT
        //Holds the cluster size
        public int clusterSize = 0; // 8192
        //Bool for if compressed
        public bool compression = false; // true / false
        //Bool for if it has been canceled
        public bool canceled = false; // true / false
        #endregion
        #endregion

        #region Detect USB Variables
        //Variables to detect USB Devices-----
        //WinProc Messages
        private const int WM_DEVICECHANGE = 0x219;
        private const int DBT_DEVICEARRIVAL = 0x8000;
        private const int DBT_DEVICEREMOVECOMPLETE = 0x8004;
        private const int DBT_DEVTYP_VOLUME = 0x00000002;
        //-----
        #endregion

        public frmMain()
        {
            InitializeComponent();

            //Get Drives attached to computer
            RefreshDrives(); //Loads cmbFormat and cmbOverview combo boxes
            //Load the selected Drives info
            LoadDriveInfo(); //Loads the RTB on overview page with the selected drives info
            //Load Program Defaults
            LoadDefaults();//Loads the progrms defaults
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            #region System Timer
            //systemTimer properties
            systemTimer = new System.Timers.Timer(1000); //set a new timer at 1 second per tick
            systemTimer.Elapsed += SystemTimer_Elapsed; ;//set it to the on timed event
            systemTimer.Enabled = true;//enable the timer
            #endregion //Loads the system timer
        }

        private void SystemTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {

        }

        #region Methods
        public void LoadDefaults()
        {

            #region Check Boxes
            chkSaveDest.Checked = Settings.Default.SaveDestination;
            #endregion

            #region Text Boxes

            txtDestinationPath.Text = Settings.Default.Dest;
            #endregion

            #region Format
            //Set the variables to the default values
            txtVolumeLabel.Text = "Untitled";
            cmbFileSystem.SelectedIndex = 0;
            cmbAllocationSize.SelectedIndex = 4;
            #endregion //Loads the format pages defaults
        }

        #region Drives
        public void RefreshDrives()
        {
            cmbOverview.SelectedIndexChanged -= new EventHandler(cmbOverview_SelectedIndexChanged);
            cmbOverview.Items.Clear();
            cmbFormat.Items.Clear();

            cmbOverview.Items.AddRange(DriveInfoClass.GetDrives().ToArray());
            cmbFormat.Items.AddRange(DriveInfoClass.GetDrives().ToArray());
            cmbFormat.SelectedIndex = 0;
            cmbOverview.SelectedIndex = 0;
            cmbOverview.SelectedIndexChanged += new EventHandler(cmbOverview_SelectedIndexChanged);
        }

        public void LoadDriveInfo()
        {
            rtbDriveInfo.Text = DriveInfoClass.GetDriveInformation(cmbOverview.SelectedItem.ToString());
        }
        #endregion

        #region Format Page
        public bool VerifyFormatData(string driveLetter)
        {
            //Check that the drive selected is not the OS drive
            if (DriveInfoClass.ISOSDrive(driveLetter))
            {
                MessageBox.Show("You cannot format an OS drive!",
                    "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                //Make sure that the user knows the repercussions.
                DialogResult result = MessageBox.Show("WARNING: Formatting will erase ALL data on this disk." +
                    " To format the disk, click OK. To quit, click CANCEL",
                    "Format " + DriveInfoClass.GetDriveLabel(driveLetter) + " " + driveLetter,
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (result == DialogResult.OK)
                {
                    volumeLabel = txtVolumeLabel.Text;
                    fileSystem = cmbFileSystem.SelectedItem.ToString();
                    quickFormat = chkQuickFormat.Checked;
                    compression = chkCompression.Checked;

                    //Make sure drive letter is formatted as ex: "C:"
                    driveLetter = cmbFormat.SelectedItem.ToString();
                    driveLetter = driveLetter.Substring(0, 2);

                    //Get Allocation size
                    //Get the number from the text on the combo box
                    string temp = cmbAllocationSize.SelectedItem.ToString();
                    int pos = temp.IndexOf(" ");
                    temp = temp.Substring(0, pos);

                    //Check to see if the selected item is above the 4th item
                    if (cmbAllocationSize.SelectedIndex > 4)
                    {
                        clusterSize = Convert.ToInt32(temp) * 1000;
                    }
                    else
                    {
                        clusterSize = Convert.ToInt32(temp);
                    }

                    return true;
                }
                else
                {
                    return false;
                }

            }
        }
        #endregion
        #endregion

        #region Events
        #region Overview Page
        private void cmbOverview_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDriveInfo();
        }

        #endregion

        #region Backup Page
        private void btnCopy_Click(object sender, EventArgs e)
        {
            //Check to make sure that the source and destination are not blank
            if (txtSourcePath.Text == "" || txtDestinationPath.Text == "")
            {
                //Error message
                MessageBox.Show("You need to select a source and destination before you can continue.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //Check to see if saveDest checkbox is checked
                if (chkSaveDest.Checked == true)
                {
                    //If it is set the default.Dest setting to the txtDestinationPath
                    Settings.Default.Dest = txtDestinationPath.Text;
                    Settings.Default.SaveDestination = chkSaveDest.Checked;
                    //Save the settings
                    Settings.Default.Save();

                }
                else
                {
                    Settings.Default.SaveDestination = chkSaveDest.Checked;
                    //Save the settings
                    Settings.Default.Save();
                }
                //set the default.IsChecked to true
                Settings.Default.Overwrite = chkOverwrite.Checked;

                //Show frmProgress form and start backup
                bgWorkerCopy.RunWorkerAsync();
            }
        }

        private void bgWorkerCopy_DoWork(object sender, DoWorkEventArgs e)
        {
            //Show frmProgress
            progress.ShowDialog();
        }

        private void bgWorkerCopy_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //Cancel the background worker
            this.bgWorkerCopy.CancelAsync();
        }

        private void btnSource_Click(object sender, EventArgs e)
        {
            //Set dialogresult
            DialogResult result = folderBrowser.ShowDialog();
            //Check result
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowser.SelectedPath))
            {
                //if OK set the textbox to the selected path
                txtSourcePath.Text = folderBrowser.SelectedPath;
                //Set Setting source to the textbox
                Settings.Default.Source = txtSourcePath.Text;
            }
        }

        private void btnDest_Click(object sender, EventArgs e)
        {
            //Set dialogresult
            DialogResult result = folderBrowser.ShowDialog();
            //Check result
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowser.SelectedPath))
            {
                //Set textbox to the selected path
                txtDestinationPath.Text = folderBrowser.SelectedPath;
                //Set setting default.dest to txtDestinationPath
                Settings.Default.Dest = txtDestinationPath.Text;
            }
        }


        #endregion

        #region Format Page
        private void cmbFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Make sure drive letter is formatted
            formatDriveLetter = cmbFormat.SelectedItem.ToString().Substring(0, 2); // C:

            //Load the info from the selected drive
            txtVolumeLabel.Text = DriveInfoClass.GetDriveLabel(formatDriveLetter); // New Volume
            txtDriveSize.Text = DriveInfoClass.GetDriveSize(formatDriveLetter).ToString("0.0") + " GB"; // 32.0 GB
        }
        private void btnFormat_Click(object sender, EventArgs e)
        {
            if (VerifyFormatData(formatDriveLetter))
            {
                lblFormatMessage.Visible = true;
                bgFormat.RunWorkerAsync();
            }
        }

        private void bgFormat_DoWork(object sender, DoWorkEventArgs e)
        {
            FormatClass.FormatDrive(formatDriveLetter, volumeLabel, fileSystem, quickFormat, clusterSize, compression);
        }

        private void bgFormat_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lblFormatMessage.Visible = false;
            MessageBox.Show("Format Complete");
        }
        #endregion

        #endregion

        //Handles all USB Detection in the program
        #region DetectUSB
        #region USB Property Struct
        //Struct to hold the new devices properties
        public struct DevBroadcastVolume
        {
            public int Size;
            public int DeviceType;
            public int Reserved;
            public int Mask; //This will hold the drive letter
            public Int16 Flags;
        }
        #endregion

        #region WinProc Message Handling
        //Used to override the windows message on device arrival
        //Big ol code I need to scrub on through for any errors.
        //Used to override Windows Message for usb detection
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (Settings.Default.DriveDetection == true)
            {
                switch (m.Msg)
                {
                    #region Device Change
                    case WM_DEVICECHANGE:
                        switch ((int)m.WParam)
                        {
                            #region Device Arrival
                            //Device Arrives
                            case DBT_DEVICEARRIVAL:
                                //Refresh the drive list
                                RefreshDrives();
                                //Get the device type of USB Only
                                int devType = Marshal.ReadInt32(m.LParam, 4);
                                //Check that the device is USB
                                if (devType == DBT_DEVTYP_VOLUME)
                                {
                                    //Set up the struct information from the m.LParam
                                    DevBroadcastVolume vol;
                                    vol = (DevBroadcastVolume)
                                       Marshal.PtrToStructure(m.LParam,
                                       typeof(DevBroadcastVolume));
                                    //Alert user of the device change and ask if they would like to back it up.
                                    DialogResult result = MessageBox.Show("USB Drive " + (DriveMaskToLetter(vol.Mask).ToString())
                                        + @":\ has been inserted. Would you like to backup its contents?", "Alert", MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Information);
                                    //Check the result
                                    if (result == DialogResult.Yes)
                                    {
                                        //If yest check that the Default Destination is not blank
                                        if (Settings.Default.Dest != "")
                                        {
                                            Settings.Default.Source = (DriveMaskToLetter(vol.Mask).ToString()) + @":\";
                                            //Call the backup method
                                            progress.ShowDialog();
                                        }
                                        else
                                        {
                                            //Alert the user to choose a destination for the backup
                                            MessageBox.Show("Please choose a destination for the backup!", "alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            //Set the folder browser to a result so that if they cancel the method below is not ran
                                            DialogResult folderResult = folderBrowser.ShowDialog();
                                            //check the result
                                            if (folderResult == DialogResult.Cancel)
                                            {
                                                //If cancel return
                                                return;
                                            }
                                            //If not set the folderbrowser selected path to the default destination
                                            Settings.Default.Dest = folderBrowser.SelectedPath;
                                            //Save the property
                                            Settings.Default.Save();
                                            //Set the source
                                            Settings.Default.Source = (DriveMaskToLetter(vol.Mask).ToString()) + @":\";
                                            //Call the backup method
                                            progress.ShowDialog();
                                        }
                                    }
                                    else
                                    {
                                        //Return if they do not wish to backup
                                        return;
                                    }
                                }
                                break;
                            #endregion

                            #region Device Removal
                            //Device Remove
                            case DBT_DEVICEREMOVECOMPLETE:
                                //Don't necessarilly need to know when drive is removed.
                                //MessageBox.Show("Device Removed", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ////Refresh the drive list

                                RefreshDrives();
                                LoadDriveInfo();
                                break;
                                #endregion
                        }
                        break;
                        #endregion
                }
            }

        }
        #endregion

        #region Convert DriveMask to Letter
        //Method to convert the Mask of the USB to a Char
        //This will get the Drive Letter
        private static char DriveMaskToLetter(int mask /*Incoming USB Mask*/)
        {
            //Variables//
            char letter; //Hold the letter
            string drives = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"; //1 = A, 2 = B, 3 = C...
            int count = 0;//Set count to 0
            int pom = mask / 2; //Set pom to (mask / 2)
            while (pom != 0)    // while there is any bit set in the mask shift it right        
            {
                pom = pom / 2; //Set pom to (pom / 2)
                count++; //Increase Count
            }

            //Check if the count is less than the length of the drives
            if (count < drives.Length)
            {
                //Set the letter to drives[count] 
                letter = drives[count];
            }
            else
            {
                //Set letter to unknown
                letter = '?';
            }

            //Return the letter
            return letter;
        }
        #endregion

        #endregion

        private void chkSaveDest_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkOverwrite_CheckedChanged(object sender, EventArgs e)
        {

        }


    }
}
