using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Vault_Backup.Forms;
using Vault_Backup.Properties;

namespace Vault_Backup.Class
{
    public class BackupClass
    {
        #region Public Variables
        //Variables
        public static int totalFilesCopied = 0;//Holds the amount of files successfully copied
        public static int filesNotCopied = 0;//Holds the amount of files not copied
        public static int totalDirectories = 0; //Holds the number of directories
        public static float totalSize = 0;//Holds the total size of a file
        public static string totalSizeToCopy = ""; //Holds the string of the totalSize of the Copy
        public static int totalFiles = 0; //Holds the total files being processed
        public static int currFile = 0;//Holds the current file being processed
        #endregion

        #region Copy Files
        /// <summary>
        /// This method is used to copy directories and files from sourceDirName
        /// to destDirName. Will copy sub directories if bool copySubDirs is true and 
        /// overwrite files if bool overwriteFiles is true. It takes in a form to update the UI controls
        /// to report progress.
        /// 
        /// Fills the following variables
        /// -----
        /// totalFilesCopied
        /// filesNotCopied
        /// currFile
        /// 
        /// </summary>
        /// <param name="sourceDirName"></param>
        /// <param name="destDirName"></param>
        /// <param name="copySubDirs"></param>
        /// <param name="overwriteFiles"></param>
        /// <param name="main"></param>
        public static void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs, bool overwriteFiles, /*Needs to be changed per project*/ frmProgress main)
        {
            #region Variables
            //Holds the Directory variables
            #region Directory Variables
            DirectoryInfo dir = new DirectoryInfo(sourceDirName); //Holds sourceDirName DirectoryInfo
            DirectoryInfo[] dirs = dir.GetDirectories(); //Holds an array of DirectoryInfo
            DirectoryInfo destinationDirectory; // Holds the new DirectoryInfo destinationDirectory
            DirectorySecurity security; //Holds the Directory Security
            #endregion

            //Holds the variables to process copying a file
            #region Copy File Variables
            string temppath; //Holds the temp file path
            FileSecurity fileSecurity; //Holds the file security
            FileInfo[] files; //Holds an array of file information
            FileInfo copiedFile; //Holds a new FileInfo copiedFile;
            #endregion
            #endregion

            //Check if process is cancelled
            if (Settings.Default.Cancel == true)
            {
                return; //Exit the method
            }
            else
            {
                #region Directory Info and Security

                #region Check Source Directory Existance
                //Check if the source dir exists
                if (!dir.Exists)
                {
                    //If not throw exception
                    throw new DirectoryNotFoundException(
                        "Source directory does not exist or could not be found: "
                        + sourceDirName);
                }
                #endregion

                #region Set Destination Directory
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
                #endregion

                #region Set Security
                //-----Setting security access to the destination -----
                //Get Access Control from dir set it to DirectorySecurity security
                security = dir.GetAccessControl();
                //SetAccessRuleProtection on security
                security.SetAccessRuleProtection(true, true);
                //SetAccessControl for the DirectoryInfo destinationDirectory to security
                destinationDirectory.SetAccessControl(security);
                //-----------------------------------------------------
                #endregion

                #endregion

                #region FileCopy
                //Get all of the files from the directory
                files = dir.GetFiles();

                //For each loop to go through the array of files
                foreach (FileInfo file in files)
                {
                    //Set the path to combine the destination name and the file name from the source
                    temppath = Path.Combine(destDirName, file.Name);

                    //Get file access control
                    fileSecurity = file.GetAccessControl();

                    //Set the fileSecurity access control
                    fileSecurity.SetAccessRuleProtection(true, true);

                    //Try to copy the file
                    #region Copy File
                    //Try statement to try and copy the file
                    try
                    {
                        //Copy the file from the source to the destination
                        file.CopyTo(temppath, false);
                        //Increase the total files copied
                        totalFilesCopied++;
                    }
                    //If file already exists
                    catch
                    {
                        //Check if overwriteFiles is true
                        if (overwriteFiles == true)
                        {
                            try
                            {
                                //Copy the file from the source to the destination
                                file.CopyTo(temppath, overwriteFiles);
                                //Increase the total files copied
                                totalFilesCopied++;
                            }
                            catch
                            {
                                //Error issue copying
                                filesNotCopied++;
                            }
                        }
                        else
                        {
                            //Do NOT Copy
                            filesNotCopied++;
                        }
                    }
                    
                    //get file info of copied file
                    copiedFile = new FileInfo(temppath);
                    //Set access control of the new file
                    copiedFile.SetAccessControl(fileSecurity);
                    //increase the numfiles processed by 1 to get current file
                    currFile++;
                    #endregion

                    //Try statement to update the Progress UI providing progress reporting
                    //Needs to be at end of method to be accurate!!!
                    #region Update UI
                    try
                    {
                        //Use the beginInvoke method to access the main forms UI controls to update them while copying
                        main.BeginInvoke((ThreadStart)delegate ()
                        {
                            main.lblCurrentFile.Text = "File: " + file.Name; //Current file name being copied to display
                            main.lblFiles.Text = "Files Copied: " + currFile + " out of " + totalFiles;//Current file number out of the total files
                            main.lblPercentComplete.Text = (currFile * 100 / totalFiles) + "% complete";//Set the percent complete after every file
                            main.progCurrentFile.Value = currFile * 100 / totalFiles;//Shows the progress on the form
                            main.lblFilesSkipped.Text = "Files Skipped: " + filesNotCopied;//Show if any files were skipped
                            
                        });
                    }
                    catch
                    {
                        //Error
                    }
                    #endregion
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
                            #region Copy SubDirectory
                            //Get a temp path of the destination name and the subdir name
                            temppath = Path.Combine(destDirName, subdir.Name);
                            //Recursively call the DirectCopy method with the temp name as the destination
                            DirectoryCopy(subdir.FullName, temppath, copySubDirs, overwriteFiles, main);
                            //dirNumber++;
                            #endregion

                        }//End if statement

                    }//End loop
                }//End if statement
                #endregion
            }
        }//End DirectoryCopy
        #endregion

        #region Get ParentDirectory Size
        /// <summary>
        /// This method is used to get the size of the selected directory and subDirectories if bool is true
        /// it shows how may files, folders are in the parent directory. 
        /// It also determines the size of the parent directory
        /// 
        /// Fills Global Variables
        /// -----
        /// totalDirectories
        /// totalFiles
        /// totalSize
        /// totalSizeToCopy
        /// </summary>
        /// <param name="sourceDirName"></param>
        /// <param name="copySubDirs"></param>
        public static void GetDirectorySize(string sourceDirName, bool copySubDirs)
        {
            
            #region Variables
            DirectoryInfo dir = new DirectoryInfo(sourceDirName); //Holds sourceDirName DirectoryInfo
            FileInfo[] files; //Holds an array of files
            DirectoryInfo[] dirs; //Holds an array of DirectoryInfo
            #endregion

            #region Check Directory Existance

            //Check if the created directory exists
            if (!dir.Exists)
            {
                //Throw error
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + sourceDirName);
            }

            //Directory Exists increase the dirNumber
            totalDirectories++;
            #endregion

            #region Files Query
            //Create an array of FileInfo vars called files and give it dir.GetFiles()
            files = dir.GetFiles();

            //For each loop to go through the array of files gathered from the given dir
            foreach (FileInfo file in files)
            {
                totalSize += (file.Length);
                totalFiles++;

            }//End loop
            #endregion

            #region SubDirectories Query
            //Check if the copySubDirectories is true
            if (copySubDirs)
            {
                //Create an array of DirectoryInfo vars called dirs and give it dir.GetDirectories()
                dirs = dir.GetDirectories();

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
                        //Recursively call the DirectCopy method with the subdir.FullName as the destination
                        GetDirectorySize(subdir.FullName, copySubDirs);
                    }//End if statement
                }
            }
            else
            {
                //Do nothing
            }
            #endregion

            #region TotalSize 
            //Check the size in bytes of the total copy size
            if (totalSize > 1000000000)
            {
                totalSizeToCopy = (totalSize / 1048576000).ToString("0.00") + " GB" ;

            }
            else
            {
                totalSizeToCopy = (totalSize / 1048576).ToString("0.00") + " MB";
            }
            #endregion
        }
        #endregion
    }
}
