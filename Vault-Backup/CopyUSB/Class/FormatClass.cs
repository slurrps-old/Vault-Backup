using System;
using System.IO;
using System.Windows.Forms;
using System.Management;
using UDiagnose.Forms;
using UDiagnose.Popups;
using System.Security.Cryptography;

namespace UDiagnose.Classes
{
    class FormatClass
    {
        //Author: Kenneth Lamb
        //Purpose:  This clas handles the formatting of the drives algorithms
        // 
        // Assumptions: 
        //
        // Exception Handling: 
        //
        // Summary of Methods:

        //Instances of the Forms needed
        public frmFormatDetails drivedetails = new frmFormatDetails();
        public frmWait wait = new frmWait();

        public FormatClass()
        {

        }

        #region FormatDrives
        public bool FormatDrive(string driveLetter, string fileSystem = "NTFS", bool quickFormat = true, int clusterSize = 8192, string label = "", bool enableCompression = false)
        {

            //Run format as normal on any drive
            //Check to make sure the drive letter is correctly formatted.
            if (driveLetter.Length != 2 || driveLetter[1] != ':' || !char.IsLetter(driveLetter[0]))
            {
                return false;
            }

            //Make sure that the user knows the repercussions.
            DialogResult result = MessageBox.Show("Are you sure you want to format, this will permenantly delete any information on the drive "
                + driveLetter + " ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            //If Yes go ahead with the format
            if (result == DialogResult.Yes)
            {
                //Show the popup form
                drivedetails.ShowDialog();
                //Get the variables from the popup forms details.
                if (drivedetails.VolumeLabel == "")
                {
                    label = "Untitled";
                }
                else
                {
                    label = drivedetails.VolumeLabel;
                }
                fileSystem = drivedetails.fileSystem;
                quickFormat = drivedetails.quickFormat;
                clusterSize = drivedetails.allocationSize;
                enableCompression = drivedetails.compression;

                //Check if the process has been canceled
                if (drivedetails.canceled == true)
                {
                    //Abort Message.
                    MessageBox.Show("Format has been aborted.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                else
                {
                    //Show the wait form
                    wait.ShowDialog();
                    try
                    {
                        //query and format given drive         
                        ManagementObjectSearcher searcher = new ManagementObjectSearcher
                         (@"select * from Win32_Volume WHERE DriveLetter = '" + driveLetter + "'");
                        //Format the drive with the below code.
                        foreach (ManagementObject vi in searcher.Get())
                        {
                            //Invoke the format method
                            vi.InvokeMethod("Format", new object[]
                          { fileSystem, quickFormat,clusterSize, label, enableCompression });
                        }
                        //Message complete
                        //close thread
                        //sf.Abort();
                        //Call the new wait window
                        updateWait();

                        return true;
                    }
                    catch
                    {
                        //Error message
                        wait.Close();
                        MessageBox.Show("Format has been aborted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            //Else quit the process.
            else
            {
                return false;
            }
        }//End Format

        //Create the wait form set complete button to false
        private void showWait()
        {
            //set the button to be invisable
            wait.btnAccept.Visible = false;
            //Show form
            wait.ShowDialog();
        }
        //Update upon completion
        public void updateWait()
        {
            //Change the text
            wait.lblMessage.Text = "Success, your format is complete.";
            //set button to be visable
            wait.btnAccept.Visible = true;
            //Show form
            wait.ShowDialog();
        }
        #endregion

        #region File Wipe
        public bool WipeFile()
        {
            //Warn user of results of deleting a file this way
           DialogResult result = MessageBox.Show("Are you sure you would like to wipe a file? This will permenantly delete the file."
               , "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            //Check to see if this has been canceled
            if (result == DialogResult.No)
            {
                //Abort Message
                MessageBox.Show("This has been aborted.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                //Set an instance of openfiledialog and show it
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.ShowDialog();

                //Get the filename from the dialog
                string filename = openFile.FileName;

                //Try to wipe the file
                try
                {
                    //Check if the file exists
                    if (File.Exists(filename))
                    {
                        // Set the files attributes to normal in case it's read-only.

                        File.SetAttributes(filename, FileAttributes.Normal);

                        // Calculate the total number of sectors in the file.
                        double sectors = Math.Ceiling(new FileInfo(filename).Length / 512.0);

                        // Create a dummy-buffer the size of a sector.

                        byte[] dummyBuffer = new byte[512];

                        // Create a cryptographic Random Number Generator.
                        // This is what I use to create the garbage data.

                        RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();

                        // Open a FileStream to the file.
                        FileStream inputStream = new FileStream(filename, FileMode.Open);
                        for (int currentPass = 0; currentPass < VaultBackup.Properties.Settings.Default.Passes; currentPass++)
                        {
                            //UpdatePassInfo(currentPass + 1, timesToWrite);

                            // Go to the beginning of the stream

                            inputStream.Position = 0;

                            // Loop all sectors
                            for (int sectorsWritten = 0; sectorsWritten < sectors; sectorsWritten++)
                            {
                                //UpdateSectorInfo(sectorsWritten + 1, (int)sectors);

                                // Fill the dummy-buffer with random data

                                rng.GetBytes(dummyBuffer);

                                // Write it to the stream
                                inputStream.Write(dummyBuffer, 0, dummyBuffer.Length);
                            }
                        }

                        // Truncate the file to 0 bytes.
                        // This will hide the original file-length if you try to recover the file.

                        inputStream.SetLength(0);

                        // Close the stream.
                        inputStream.Close();

                        // As an extra precaution I change the dates of the file so the
                        // original dates are hidden if you try to recover the file.

                        DateTime dt = new DateTime(2037, 1, 1, 0, 0, 0);
                        File.SetCreationTime(filename, dt);
                        File.SetLastAccessTime(filename, dt);
                        File.SetLastWriteTime(filename, dt);

                        // Finally, delete the file

                        File.Delete(filename);

                        //Success message
                        MessageBox.Show("The file " +
                            filename + " has successfully been wiped.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {
                    //error message
                    MessageBox.Show("File has not been wiped!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                return true;
            }
        }
        #endregion

    }
}
