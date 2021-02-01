using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CopyUSB;

namespace VaultBackup
{
    class Settings
    {
        frmMain main = new frmMain();
        public void SaveSettings()
        {
            //set Default.Dest to the text box
            VaultBackup.Properties.Settings.Default.Dest = main.txtDefaultDest.Text;
            //Set default.Soure to the text box
            VaultBackup.Properties.Settings.Default.Source = main.txtDefaultSource.Text;

            #region CheckBoxes
            //Set if the user wants the program to start on windows startup
            //Sets whether the program starts on boot
            if (main.chkStartOnStartup.Checked)
            {
                VaultBackup.Properties.Settings.Default.StartupProgram = true;
            }
            else
            {
                VaultBackup.Properties.Settings.Default.StartupProgram = false;
            }
            //Set whether usb detection is on
            if (main.chkDriveDetection.Checked)
            {
                VaultBackup.Properties.Settings.Default.DriveDetection = true;

            }
            else
            {
                VaultBackup.Properties.Settings.Default.DriveDetection = false;
            }

            //Set overwrite is on by default
            if (main.chkOverwriteSetting.Checked)
            {
                VaultBackup.Properties.Settings.Default.Overwrite = true;

            }
            else
            {
                VaultBackup.Properties.Settings.Default.Overwrite = false;
            }

            //Set OnlyUSB setting
            if (main.chkOnlyUSB.Checked)
            {
                VaultBackup.Properties.Settings.Default.OnlyUSB = true;

            }
            else
            {
                VaultBackup.Properties.Settings.Default.OnlyUSB = false;
            }

            //AutoBackup
            if (main.chkAutoBackup.Checked)
            {
                VaultBackup.Properties.Settings.Default.AutoBackup = true;
                //Save time
                VaultBackup.Properties.Settings.Default.BackupTime = main.GetTime(main.dateTimeAutoBackup.Value);

            }
            else
            {
                VaultBackup.Properties.Settings.Default.AutoBackup = false;

            }

            //TimeStamp
            if (main.chkDateTimeStamp.Checked)
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
            if (main.numUpDownFileWipe.Value == 0)
            {
                //Error message
                MessageBox.Show("Please choose a number. This cannot be zero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                //Set passes for the file wipe
                VaultBackup.Properties.Settings.Default.Passes = Convert.ToInt32(main.numUpDownFileWipe.Value);
            }
            #endregion

        }

        public void LoadSettings()
        {

        }
    }
}
