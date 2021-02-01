using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;
using UDiagnose.Classes;
using Microsoft.Win32;
using System.Runtime.InteropServices;
using ComponentFactory.Krypton.Toolkit;
using VaultBackup.Forms;
using System.Timers;

namespace CopyUSB
{
    public partial class frmMain : KryptonForm
    {
        #region Forms and Classes Instances
        //Setup instances of the forms and classes-----
        readonly DriveInfoClass dwInfo = new DriveInfoClass();
        readonly FormatClass format = new FormatClass();
        readonly frmProgress progress = new frmProgress();
        readonly BackupClass backup = new BackupClass();
        readonly frmDriveDetails driveDetails = new frmDriveDetails();
        //-----
        #endregion

        #region Detect USB Variables
        //Variables to detect USB Devices-----
        private const int WM_DEVICECHANGE = 0x219;
        private const int DBT_DEVICEARRIVAL = 0x8000;
        private const int DBT_DEVICEREMOVECOMPLETE = 0x8004;
        private const int DBT_DEVTYP_VOLUME = 0x00000002;
        //-----
        #endregion

        public System.Timers.Timer systemTimer;

        public frmMain()
        {
            InitializeComponent();
        }

        #region Movement
        //variables for window movement
        bool drag;
        int mousex;
        int mousey;

        private void frmMain_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;

            mousex = System.Windows.Forms.Cursor.Position.X - this.Left;
            mousey = System.Windows.Forms.Cursor.Position.Y - this.Top;
        }

        private void frmMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag == true)
            {
                this.Top = System.Windows.Forms.Cursor.Position.Y - mousey;
                this.Left = System.Windows.Forms.Cursor.Position.X - mousex;
            }
        }

        private void frmMain_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }
        #endregion

        #region FormWindowButtons
        //Close button
        private void btnExit_Click(object sender, EventArgs e)
        {
            //Hide the form and set focus to the Backup page
            Hide();
            pgBackup.Select();
        }//End btnExit_Click

        //Minimize Button
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            //Set windows state to minimize
            this.WindowState = FormWindowState.Minimized;
        }//End btnMinimize_Click



        #endregion

        #region Form Events
        private void Form1_Load(object sender, EventArgs e)
        {
            //properties
            systemTimer = new System.Timers.Timer(1000); //set a new timer at 1 second per tick
            systemTimer.Elapsed += OnTimedEvent;//set it to the on timed event
            systemTimer.Enabled = true;//enable the timer
            //Load Drive information
            dwInfo.RefreshDrives(this);
            //Load default values
            LoadDefaults();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            //VaultBackup.Properties.Settings.Default.Source = "";
            notifyTrayIcon.Dispose();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //notifyTrayIcon.Dispose();
        }
        #endregion

        #region Contex Menu
        private void closeApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Closes the application
            Application.Exit();
        }//end closeApp

        private void restoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Restore the application to the window
            Show();
            WindowState = FormWindowState.Normal;
            pgBackup.Focus();

        }//end restoreToolStripMenu
        #endregion

        #region Menu Strip
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Close application
            Application.Exit();
        }//end exitTool





        #endregion

        #region Methods
        public void LoadDefaults()
        {
            //Check how many passes are set to the file wipe
            numUpDownFileWipe.Value = VaultBackup.Properties.Settings.Default.Passes;

            #region Text Boxes
            //Set defaults to the settings in the program that were saved
            txtDestinationPath.Text = VaultBackup.Properties.Settings.Default.Dest;
            txtDefaultDest.Text = VaultBackup.Properties.Settings.Default.Dest;
            txtSourcePath.Text = VaultBackup.Properties.Settings.Default.Source;
            txtDefaultSource.Text = VaultBackup.Properties.Settings.Default.Source;
            #endregion
            
            #region CheckBoxes on Program
            //Check if the checkboxes should be checked
            //Checkbox for Start on startup still in experimental mode
            if (VaultBackup.Properties.Settings.Default.StartupProgram == true)
            {
                chkStartOnStartup.CheckState = CheckState.Checked;
            }
            else
            {
                chkStartOnStartup.CheckState = CheckState.Unchecked;
            }
            //Check box for Drive detection
            if (VaultBackup.Properties.Settings.Default.DriveDetection == true)
            {
                chkDriveDetection.CheckState = CheckState.Checked;

            }
            else
            {
                chkDriveDetection.CheckState = CheckState.Unchecked;
            }
            //Check box for overwriting files
            if (VaultBackup.Properties.Settings.Default.Overwrite == true)
            {
                chkOverwriteSetting.CheckState = CheckState.Checked;
                chkOverwrite.CheckState = CheckState.Checked;
            }
            else
            {
                chkOverwriteSetting.CheckState = CheckState.Unchecked;
                chkOverwrite.CheckState = CheckState.Unchecked;
            }
            //Destination check box
            if (VaultBackup.Properties.Settings.Default.Dest != "")
            {
                chkSaveDest.CheckState = CheckState.Checked;
            }
            else
            {
                chkSaveDest.CheckState = CheckState.Unchecked;
            }
            //OnlyUSB checkbox
            if (VaultBackup.Properties.Settings.Default.OnlyUSB == true)
            {
                chkOnlyUSB.CheckState = CheckState.Checked;
            }
            else
            {
                chkOnlyUSB.CheckState = CheckState.Unchecked;
            }

            //Autobackup
            if(VaultBackup.Properties.Settings.Default.AutoBackup == true)
            {
                chkAutoBackup.CheckState = CheckState.Checked;
                dateTimeAutoBackup.Visible = true;
            }
            else
            {
                chkAutoBackup.CheckState = CheckState.Unchecked;
                dateTimeAutoBackup.Visible = false;
            }

            //TimeStamp
            if (VaultBackup.Properties.Settings.Default.TimeStamp == true)
            {
                chkDateTimeStamp.CheckState = CheckState.Checked;
            }
            else
            {
                chkDateTimeStamp.CheckState = CheckState.Unchecked;
            }
            #endregion
        }

        public TimeSpan GetTime(DateTime dateAndTime)
        {
            int pos = 0;
            string time = dateAndTime.ToString();
            TimeSpan AutoTime;

            pos = time.IndexOf(" ");
            time = time.Remove(0, pos + 1);
            pos = time.IndexOf(" ");
            time = time.Remove(pos, 3);

            AutoTime = TimeSpan.Parse(time);

            return AutoTime;
        }

        #region DetectUSB
        //Struct to hold the new devices properties
        public struct DevBroadcastVolume
        {
            public int Size;
            public int DeviceType;
            public int Reserved;
            public int Mask; //This will hold the drive letter
            public Int16 Flags;
        }


        //Used to override the windows message on device arrival
        //Big ol code I need to scrub on through for any errors.
        //Used to override Windows Message for usb detection
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (VaultBackup.Properties.Settings.Default.DriveDetection == true)
            {
                switch (m.Msg)
                {
                    case WM_DEVICECHANGE:
                        switch ((int)m.WParam)
                        {
                            //Device Arrives
                            case DBT_DEVICEARRIVAL:
                                //Refresh the drive list
                                dwInfo.RefreshDrives(this);
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
                                        if (VaultBackup.Properties.Settings.Default.Dest != "")
                                        {
                                            VaultBackup.Properties.Settings.Default.Source = (DriveMaskToLetter(vol.Mask).ToString()) + @":\";
                                            //Call the backup method
                                            progress.ShowDialog();
                                        }
                                        else
                                        {
                                            //Alert the user to choose a destination for the backup
                                            MessageBox.Show("Please choose a destination for the backup!", "alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            //Set the folder browser to a result so that if they cancel the method below is not ran
                                            DialogResult folderResult = folderBrowserDialog.ShowDialog();
                                            //check the result
                                            if (folderResult == DialogResult.Cancel)
                                            {
                                                //If cancel return
                                                return;
                                            }
                                            //If not set the folderbrowser selected path to the default destination
                                            VaultBackup.Properties.Settings.Default.Dest = folderBrowserDialog.SelectedPath;
                                            //Save the property
                                            VaultBackup.Properties.Settings.Default.Save();
                                            //Set the source
                                            VaultBackup.Properties.Settings.Default.Source = (DriveMaskToLetter(vol.Mask).ToString()) + @":\";
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
                            //Device Remove
                            case DBT_DEVICEREMOVECOMPLETE:
                                //Don't necessarilly need to know when drive is removed.
                                //MessageBox.Show("Device Removed", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ////Refresh the drive list
                                dwInfo.RefreshDrives(this);
                                break;
                        }
                        break;
                }
            }

        }
        //Method to convert the Mask of the USB to a Char
        //This will get the Drive Letter
        private static char DriveMaskToLetter(int mask)
        {

            char letter;
            string drives = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"; //1 = A, 2 = B, 3 = C
            int cnt = 0;
            int pom = mask / 2;
            while (pom != 0)    // while there is any bit set in the mask shift it right        
            {
                pom = pom / 2;
                cnt++;
            }
            if (cnt < drives.Length)
                letter = drives[cnt];
            else
                letter = '?';
            return letter;
        }
        #endregion

        #region AutoBackup
        public void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            if (VaultBackup.Properties.Settings.Default.AutoBackup == true)
            {
                if (VaultBackup.Properties.Settings.Default.BackupTime == GetTime(DateTime.Now))
                {
                    if (VaultBackup.Properties.Settings.Default.Source != ""
                        && VaultBackup.Properties.Settings.Default.Dest != "")
                    {
                        //Show frmProgress form and start backup
                        bgWorkerCopy.RunWorkerAsync();
                    }
                    else
                    {
                        return;

                    }


                }
            }

        }


        #endregion

        #region Tray Icon
        private void notifyTrayIcon_DoubleClick(object sender, EventArgs e)
        {
            //Return window state to normal
            Show();
            WindowState = FormWindowState.Normal;
        }//end notifyTrayIcon_DoubleClick
        #endregion

        #region Open Program on Windows Startup
        //Experimental code
        private void SetStartup()
        {
            RegistryKey rk = Registry.CurrentUser.OpenSubKey
                ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            if (VaultBackup.Properties.Settings.Default.StartupProgram == true)
                rk.SetValue("Vault Backup", Application.ExecutablePath);
            else
                rk.DeleteValue("Vault Backup", false);

        }
        #endregion

        #endregion

        #region Pages

        #region Backup Page
        //Source button
        private void btnSource_Click(object sender, EventArgs e)
        {
            //Set dialogresult
            DialogResult result = folderBrowserDialog.ShowDialog();
            //Check result
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
            {
                //if OK set the textbox to the selected path
                txtSourcePath.Text = folderBrowserDialog.SelectedPath;
                //Set Setting source to the textbox
                VaultBackup.Properties.Settings.Default.Source = txtSourcePath.Text;
            }
        }//End btnSource_Click

        //Destination button
        private void btnDest_Click(object sender, EventArgs e)
        {
            //Set dialogresult
            DialogResult result = folderBrowserDialog.ShowDialog();
            //Check result
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
            {
                //Set textbox to the selected path
                txtDestinationPath.Text = folderBrowserDialog.SelectedPath;
                //Set setting default.dest to txtDestinationPath
                VaultBackup.Properties.Settings.Default.Dest = txtDestinationPath.Text;
            }
        }//End btnDest_Click

        //Copy button
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
                    VaultBackup.Properties.Settings.Default.Dest = txtDestinationPath.Text;
                    //Save the settings
                    VaultBackup.Properties.Settings.Default.Save();

                }
                //Check if the overwrite check box is checked
                if (chkOverwrite.Checked == true)
                {
                    //set the default.IsChecked to true
                    VaultBackup.Properties.Settings.Default.Overwrite = true;
                }
                //Show frmProgress form and start backup
                bgWorkerCopy.RunWorkerAsync();
            }
        }
        //Background worker
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
        #endregion

        #region Format Page
        private void btnFormatDrive_Click(object sender, EventArgs e)
        {
           
            //Set Drive letter to be nothing
            string driveLetter;
            //Check to make sure the selected drive is not the windows drive by making sure it does not contain the Windows folder
            if (Directory.Exists(lstDrives.SelectedItem.ToString() + @"\Windows"))
            {
                //Error message
                MessageBox.Show("Error you cannot format the windows partition drive, please try another drive.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //Get selected drive letter
                driveLetter = lstDrives.SelectedItem.ToString();
                driveLetter = driveLetter.Remove(2, 1);
                //Setup an instance of DriveInfo and give it a driveLetter as the constructor
                DriveInfo selectedDrive = new DriveInfo(driveLetter);

                //Check to see if OnlyUSB formatting has been selected from the settings.
                if (VaultBackup.Properties.Settings.Default.OnlyUSB == true)
                {
                    #region OnlyUSB Formatting
                    //Check to see if the drive is a Removable USB
                    if (selectedDrive.DriveType.ToString() == "Removable")
                    {
                        //Call the formatdrive method from FormatClass
                        format.FormatDrive(driveLetter);
                    }
                    else
                    {
                        //error
                        MessageBox.Show("This is not a USB device!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    //Call the formatdrive method from FormatClass
                    format.FormatDrive(driveLetter);
                }
                       
                //Call the refresh method from the DriveInfoClass
                dwInfo.RefreshDrives(this);
            }
        }

        private void btnFileWipe_Click(object sender, EventArgs e)
        {
            //Call the WipeFile method from the FormatClass
            format.WipeFile();
        }//End btnFileWipe_Click

        private void btnDriveDetails_Click(object sender, EventArgs e)
        {
            //set drive letter on the form drive details to selected item from the list
            driveDetails.driveLetter = lstDrives.SelectedItem.ToString();
            //Show frmDriveDetails
            driveDetails.ShowDialog();
        }//End btnDriveDetails_Click
        #endregion



        #endregion

        #region Settings Page

        private void btnDefaultDest_Click(object sender, EventArgs e)
        {
            //Set Dialog result to the folderbrowserdialog
            DialogResult result = folderBrowserDialog.ShowDialog();
            //Check the result
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
            {
                //If OK then set the textbox to the selected path
                txtDefaultDest.Text = folderBrowserDialog.SelectedPath;
            }
        }//End btnDefaultDest_Click

        private void btnDefaultSource_Click(object sender, EventArgs e)
        {
            //Set Dialog result to the folderbrowserdialog
            DialogResult result = folderBrowserDialog.ShowDialog();
            //Check the result
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
            {
                //If OK then set the textbox to the selected path
                txtDefaultSource.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            //Fill all of the settings in the program here.
            //set Default.Dest to the text box
            VaultBackup.Properties.Settings.Default.Dest = txtDefaultDest.Text;
            //Set default.Soure to the text box
            VaultBackup.Properties.Settings.Default.Source = txtDefaultSource.Text;

            #region CheckBoxes
            //Set if the user wants the program to start on windows startup
            //Sets whether the program starts on boot
            if (chkStartOnStartup.Checked)
            {
                VaultBackup.Properties.Settings.Default.StartupProgram = true;
            }
            else
            {
                VaultBackup.Properties.Settings.Default.StartupProgram = false;
            }
            //Set whether usb detection is on
            if (chkDriveDetection.Checked)
            {
                VaultBackup.Properties.Settings.Default.DriveDetection = true;

            }
            else
            {
                VaultBackup.Properties.Settings.Default.DriveDetection = false;
            }

            //Set overwrite is on by default
            if (chkOverwriteSetting.Checked)
            {
                VaultBackup.Properties.Settings.Default.Overwrite = true;

            }
            else
            {
                VaultBackup.Properties.Settings.Default.Overwrite = false;
            }

            //Set OnlyUSB setting
            if (chkOnlyUSB.Checked)
            {
                VaultBackup.Properties.Settings.Default.OnlyUSB = true;

            }
            else
            {
                VaultBackup.Properties.Settings.Default.OnlyUSB = false;
            }

            //AutoBackup
            if (chkAutoBackup.Checked)
            {
                if (txtDefaultDest.Text != null && txtDefaultSource.Text != null)
                {
                    VaultBackup.Properties.Settings.Default.AutoBackup = true;
                    //Save time
                    VaultBackup.Properties.Settings.Default.BackupTime = GetTime(dateTimeAutoBackup.Value);
                }
                else
                {
                    MessageBox.Show("Alert", "Please make sure the default Destination and Source folders are setup", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }


            }
            else
            {
                VaultBackup.Properties.Settings.Default.AutoBackup = false;

            }

            //TimeStamp
            if (chkDateTimeStamp.Checked)
            {
                VaultBackup.Properties.Settings.Default.TimeStamp = true;
            }
            else
            {
                VaultBackup.Properties.Settings.Default.TimeStamp = false;
            }
            #endregion

            #region FileWipe
            //Sets the default number of passes to fileWipe
            //Checks to make sure it is not set to 0
            if (numUpDownFileWipe.Value == 0)
            {
                //Error message
                MessageBox.Show("Please choose a number. This cannot be zero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                //Set passes for the file wipe
                VaultBackup.Properties.Settings.Default.Passes = Convert.ToInt32(numUpDownFileWipe.Value);
            }
            #endregion

            //Save all of them so they stay when the program is closed.
            VaultBackup.Properties.Settings.Default.Save();
            //SetStartup();
            MessageBox.Show("Settings Updated!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //Load the defaults into the program
            LoadDefaults();
        }

        private void chkAutoBackup_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAutoBackup.Checked)
            {
                if (txtDefaultSource.Text == "" && txtDefaultDest.Text == "")
                {
                    chkAutoBackup.CheckState = CheckState.Unchecked;
                    MessageBox.Show("Warning auto backup cannot be enabled with empty default destination and source folders." +
                        "Please choose the folders first then try again.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    dateTimeAutoBackup.Visible = true;
                }
            }
            else
            {
                dateTimeAutoBackup.Visible = false;
            }
        }

        private void btnDefaultSettings_Click(object sender, EventArgs e)
        {
            txtDefaultDest.Text = "";
            txtDefaultSource.Text = "";
            //set Default.Dest to the text box
            VaultBackup.Properties.Settings.Default.Dest = txtDefaultDest.Text;
            //Set default.Soure to the text box
            VaultBackup.Properties.Settings.Default.Source = txtDefaultSource.Text;

            VaultBackup.Properties.Settings.Default.AutoBackup = false;
            VaultBackup.Properties.Settings.Default.TimeStamp = false;
            VaultBackup.Properties.Settings.Default.DriveDetection = false;
            VaultBackup.Properties.Settings.Default.StartupProgram = false;
            VaultBackup.Properties.Settings.Default.OnlyUSB = false;
            VaultBackup.Properties.Settings.Default.Overwrite = true;

            numUpDownFileWipe.Value = 1;

            LoadDefaults();
        }

        #endregion

        #endregion

        #region Tesing!!!
        private void textBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void textBox1_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

                if (Directory.Exists(files[0]))
                {
                    this.txtSourcePath.Text = files[0];
                }
            }
        }

        #endregion

        
    }
}