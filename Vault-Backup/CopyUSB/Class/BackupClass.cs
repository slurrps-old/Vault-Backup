using System.Threading;
using System.IO;
using System.Security.AccessControl;

namespace CopyUSB
{
    class BackupClass
    {
        //Variables
        public int totalFilesCopied = 0;//Holds the amount of files successfully copied
        public int filesNotCopied = 0;//Holds the amount of files not copied
        private int dirNumber = 0;
        private float totalSize = 0;//Holds the total size of a file
        public int totalFiles = 0; //Holds the total files being processed

        //set variable num currFile to 0
        public int currFile = 0;//Holds the current file being processed

        #region Copy Files
        //This method is used to copy directories and files to a new location.
        public void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs, bool overwriteFiles, /*Needs to be changed per project*/ frmProgress main)
        {
            //Check if process is cancelled
            if(VaultBackup.Properties.Settings.Default.Cancel == true)
            {
                return;
            }
            else
            {
                #region Directory Info and Security
                //set the directory info to the incoming source name
                DirectoryInfo dir = new DirectoryInfo(sourceDirName);
                //Get all directories from the source
                DirectoryInfo[] dirs = dir.GetDirectories();

                //Set a new directoryInfo called DestinationDirectory
                DirectoryInfo destinationDirectory;

                //Check if the directory info exists
                if (!dir.Exists)
                {
                    //If not throw exception
                    throw new DirectoryNotFoundException(
                        "Source directory does not exist or could not be found: "
                        + sourceDirName);
                }
                //Check if the directory exists in the destination
                if (!Directory.Exists(destDirName))
                {
                    //If not create it and set it to the variable destinationDirectory
                    destinationDirectory = Directory.CreateDirectory(destDirName);
                }
                else
                {
                    //Set it to the variable destinationDirectory
                    destinationDirectory = new DirectoryInfo(destDirName);
                }

                //-----Setting security access to the destination -----
                //Get Access Control from dir set it to DirectorySecurity security
                DirectorySecurity security = dir.GetAccessControl();
                //SetAccessRuleProtection on security
                security.SetAccessRuleProtection(true, true);
                //SetAccessControl for the DirectoryInfo destinationDirectory to security
                destinationDirectory.SetAccessControl(security);
                //-----------------------------------------------------
                #endregion

                #region FileCopy
                //Get all of the files from the directory
                FileInfo[] files = dir.GetFiles();

                //For each loop to go through the array of files
                foreach (FileInfo file in files)
                {
                    try
                    {
                        //Use the beginInvoke method to access the main forms UI controls
                        main.BeginInvoke((ThreadStart)delegate ()
                        {
                            //Current file being copied
                            main.lblCurrentFile.Text = "Name: " + file.Name; //Current file name being copied to display

                            //-----Not sure if this is going to work
                            //Get amount of directories copied
                            //main.progCurrDir.Value = dirNumber * 100 / direct.GetDirectories().Length;
                            //main.lblCurrDir.Text = "Directory " + dirNumber + " out of " + direct.GetDirectories().Length;

                            main.lblTitle.Text = "Copying " + totalFiles + " items from " + VaultBackup.Properties.Settings.Default.Source
                            + " to " + VaultBackup.Properties.Settings.Default.Dest;//Set the title of the progress form
                            main.lblPercentComplete.Text = (currFile * 100 / totalFiles) + "% complete";//Set the percent complete after every file
                            main.lblFilesSkipped.Text = "Files Skipped: " + filesNotCopied;//Show if any files were skipped
                            main.lblFiles.Text = "File " + currFile + " out of " + totalFiles;//Current file number out of the total files
                            //main.lblFileCount.Text = "Total files copied " + totalFilesCopied;//Gets total files copied
                            main.progCurrentFile.Value = currFile * 100 / totalFiles;//Shows the progress on the form
                        });
                    }
                    catch
                    {
                        //Error
                    }

                    //Set the path to combine the destination name and the file name from the source
                    string temppath = Path.Combine(destDirName, file.Name);

                    //Get access control from the file
                    FileSecurity fileSecurity = file.GetAccessControl();
                    //Set the access rule
                    fileSecurity.SetAccessRuleProtection(true, true);
                    //Try to copy the file
                    try
                    {
                        //Copy the file from the source to the destination
                        file.CopyTo(temppath, false);
                        //Increase the total files copied
                        totalFilesCopied++;
                    }
                    catch
                    {
                        try
                        {
                            if (overwriteFiles == true)
                            {
                                //Copy the file from the source to the destination
                                file.CopyTo(temppath, overwriteFiles);
                                //Increase the total files copied
                                totalFilesCopied++;
                            }
                            else
                            {
                                 //Error no overwriting
                                filesNotCopied++;
                            }
                        }
                        catch
                        {
                            //Error issue copying
                            filesNotCopied++;
                        }
                    }
                    //get file info of copied file
                    FileInfo copiedFile = new FileInfo(temppath);
                    //Set access control of the new file
                    copiedFile.SetAccessControl(fileSecurity);
                    //increase the numfiles processed by 1 to get current file
                    currFile++;
                }//End loop
                #endregion

                #region SubDirectory Copy
                //Check if the copySubDirectories is true
                if (copySubDirs)
                {
                    //Use a foreach loop to go through all of the subdirectories in the dirs array
                    foreach (DirectoryInfo subdir in dirs)
                    {
                        //Check that the subdirectory is not System Volume Information
                        if (subdir.ToString() == "System Volume Information")
                        {
                            //If it is skip this as this has hightened security and cannot be copied
                        }
                        else
                        {
                            //Get a temp path of the destination name and the subdir name
                            string temppath = Path.Combine(destDirName, subdir.Name);
                            //Recursively call the DirectCopy method with the temp name as the destination
                            DirectoryCopy(subdir.FullName, temppath, copySubDirs, overwriteFiles, main);
                            dirNumber++;
                        }//End if statement

                    }//End loop
                }//End if statement
                #endregion
            }
        }//End DirectoryCopy
        #endregion

        //This method is used to get the size of the selected directory for reporting.
        public void GetDirectorySize(string sourceDirName, bool copySubDirs, frmProgress prog)
        {
            //set the directory info to the incoming source name
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);
            //Get all directories from the source
            DirectoryInfo[] dirs = dir.GetDirectories();

            //Check if the directory info exists
            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + sourceDirName);
            }
            //Get all of the files from the directory
            FileInfo[] files = dir.GetFiles();

            //For each loop to go through the array of files
            foreach (FileInfo file in files)
            {
                totalSize += (file.Length);
                totalFiles++;

            }//End loop

            //Check if the copySubDirectories is true
            if (copySubDirs)
            {
                //Use a foreach loop to go through all of the subdirectories in the dirs array
                foreach (DirectoryInfo subdir in dirs)
                {
                    //Check that the subdirectory is not System Volume Information
                    if (subdir.ToString() == "System Volume Information")
                    {
                        //If it is skip this
                    }
                    else
                    {
                        //Recursively call the DirectCopy method with the temp name as the destination
                        GetDirectorySize(subdir.FullName, copySubDirs, prog);
                    }//End if statement
                }
            }
            else
            {
                //Do nothing
            }

            //Gets the total size of the transfer
            try
            {
                //Use the beginInvoke method to access the main forms UI controls
                prog.BeginInvoke((ThreadStart)delegate ()
                {
                    //Check the size in bytes
                    if (totalSize > 1000000000)
                    {
                        prog.lblTotalSizeCopied.Text = "Total Size: " + (totalSize / 1048576000).ToString("0.00") + " GB";

                    }
                    else
                    {
                        prog.lblTotalSizeCopied.Text = "Total Size: " + (totalSize / 1048576).ToString("0.00") + " MB";

                    }
                });
            }
            catch
            {
                //Error
            }
        }


        //Not available yet
        #region Copy file with ability to report
        //Copies a file and reports the progress
        //Called only by DirectoryCopy Method
        //private void CopyFile(string source, string dest, /*Needs to be changed per project*/ frmProgress main)
        //{
        //    try
        //    {
        //        //Open the outstream and in stream
        //        FileStream fsOut = new FileStream(dest, FileMode.Create);
        //        FileStream fsIn = new FileStream(source, FileMode.Open);
        //        //Create a new byte variable
        //        byte[] bt = new byte[1048765];
        //        //Create a int variable called readByte
        //        int readByte;

        //        //While loop where int readByte = input stream reading bytes is > 0
        //        while ((readByte = fsIn.Read(bt, 0, bt.Length)) > 0)
        //        {
        //            //Write the file to the output stream
        //            fsOut.Write(bt, 0, readByte);
        //            //Report the progress back to the main forms background worker
        //            //Make sure to properly name the background worker you would like to report to
        //            main.backgroundWorker1.ReportProgress((int)(fsIn.Position * 100 / fsIn.Length));
        //        }
        //        //Close the streams
        //        fsIn.Close();
        //        fsOut.Close();
        //    }
        //    catch
        //    {
        //        //Try to fix the catch for denied access

        //        //Count how many files were not copied
        //        filesNotCopied++;
        //    }


        //}//End CopyFile
        #endregion
    }
}
