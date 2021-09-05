using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vault_Backup.Class
{
    public class DriveInfoClass
    {

        #region Variables

        #region Conversion
        //Constants for conveersions of different byt sizes
        const float FLOAT_GIG_CONVERSION = 1073741824f; //Holds the float conversion number of GB per bit
        const float FLOAT_TERA_CONVERSION = 0.0009765625F;//Holds the float conversion number for TB per bit
        #endregion

        #region Global
        //Global Variables to use DriveInfo and variable to hold all of the systems rive information.
        private static string driveInfo; //This is the variable that will hold all of the drive information
        //that goes into the UI

        private static bool isOSDrive; //This will hold the boolean whether the drive is the OS drive or not.
        #endregion

        //private static float fltPercent = 0; //Hold the percent of the drive that is filled.

        #region Data Structs
        //LogicalDisk
        public struct LogicalDisk 
        {
            public string driveName;
            public bool driveCompressed;
            public uint driveType;
            public string fileSystem;
        }
        
        //Calculate Space
        public struct Space
        {
            public float freeSpace;
            public float totalSpace;
            public float usedSpace;
        }
        
        //DiiskDrive
        public struct DiskDrive
        {
            public string driveStatus;
            public string physicalName;
            public int physicalDriveNumber;
            public string diskManufacturer;
            public string diskModel;
            public string diskInterface;
            public bool mediaLoaded;
            public string mediaType;
            public uint mediaSignature;
            public string mediaStatus;
            public uint driveMediaType;
            public string volumeName;
            public string volumeSerial;
        }

        public static LogicalDisk ldisk;
        public static Space currSpace;
        public static DiskDrive dDrive;
        #endregion

        #endregion

        #region Functions
        #region Conversion Functions
        //Convert bytes to Gigabytes used to display correct drive information
        public static float ConversionToGig(float conversionNum)
        {
            //Pre: Needs conversionNum to be initialized
            //Pose: Returns gigConversion number to the program
            //Purpose: To convert the bytes number that is incoming to gigabytes

            //Set the gigConversion to 0
            float gigConversion;
            //Grabs the conversionNum from the one passed into the function then 
            //divides by the Float_GIG_CONVERSION Constant
            gigConversion = conversionNum / FLOAT_GIG_CONVERSION;

            return gigConversion; //Returns the variable gigConversion
        }//End ConversionToGig

        //Convert bytes to TeraBytes used to display correct drive information
        public static float ConversionToTer(float ConversionNum)
        {
            //Pre: Needs conversionNum to be initialized
            //Pose: Returns teraConversion number to the program
            //Purpose: To convert the bytes number that is incoming to terabytes

            //Set the teraConversion to 0
            float teraConversion;
            //Grabs the conversionNum from the one passed into the function then 
            //divides by the Float_TERA_CONVERSION Constant
            teraConversion = ConversionNum / FLOAT_TERA_CONVERSION;

            return teraConversion;
        }//End ConversionToTer
        #endregion

        #endregion

        //Gets the drives attached to the computer
        public static List<string> GetDrives()
        {
            //Create a list to hold the drives
            List<string> driveList = new List<string>();

            //Go through each DriveInfo from the GetDrives method
            foreach (DriveInfo di in DriveInfo.GetDrives())
            {
                //Add the di.Name to the driveList
                driveList.Add(di.Name);
            }

            //Return the list
            return driveList;
        }

        //Loads up the drives information
        private static void LoadDriveInformation(string driveLetter)
        {
            //Clear out the structs
            ldisk = default(LogicalDisk);
            currSpace = default(Space);
            dDrive = default(DiskDrive);

            //Make sure drive letter is formatted as ex: "C:"
            driveLetter = driveLetter.Substring(0, 2);

            //New driveQuery to new ManagementObjectSearcher("Select * from Win32_DiskDrive")
            using (var driveQuery = new ManagementObjectSearcher("select * from Win32_LogicalDisk where DeviceID = '" + driveLetter + "'"))
            {
                //Foreach loop to go through the managementObjects in driveQuery
                try
                {
                    //Break on Load USB Detection Disconnected Context Error
                    //Need to get drive here

                    foreach (ManagementObject d in driveQuery.Get())
                    {
                        #region Load Data Structs
                        //Get the information from the LogicalDisk and DiskDrive classes on Windows
                        //LogicalDisk
                        ldisk.driveName = Convert.ToString(d.Properties["Name"].Value); // C:
                        ldisk.driveCompressed = Convert.ToBoolean(d.Properties["Compressed"].Value);
                        ldisk.driveType = Convert.ToUInt32(d.Properties["DriveType"].Value); // C: - 3
                        ldisk.fileSystem = Convert.ToString(d.Properties["FileSystem"].Value); // NTFS
                                                                                                      //Calculate Space
                        currSpace.freeSpace = ConversionToGig(Convert.ToUInt64(d.Properties["FreeSpace"].Value)); //converted to gigs
                        currSpace.totalSpace = ConversionToGig(Convert.ToUInt64(d.Properties["Size"].Value)); //converted to gigs
                        currSpace.usedSpace = currSpace.totalSpace - currSpace.freeSpace; //Calculate usedSpace
                                                                              //End Calculate space-----
                        dDrive.driveMediaType = Convert.ToUInt32(d.Properties["MediaType"].Value); // c: 12
                        dDrive.volumeName = Convert.ToString(d.Properties["VolumeName"].Value); // System
                        dDrive.volumeSerial = Convert.ToString(d.Properties["VolumeSerialNumber"].Value); // 12345678

                        //New Query to associate Win32_DiskDrive to DiskPartition
                        var partitionQueryText = string.Format("associators of {{{0}}} where AssocClass = Win32_LogicalDiskToPartition", d.Path.RelativePath);
                        //Create a new managementObjectSearcher giving it the query
                        var partitionQuery = new ManagementObjectSearcher(partitionQueryText);
                        //Loop to Search the ManagementObjects in the query
                        foreach (ManagementObject p in partitionQuery.Get())
                        {
                            string diskNum = p.Properties["Name"].Value.ToString().Substring(6,1);
                            string physicalName = string.Format("PHYSICALDRIVE" + diskNum);
                           
                            //Create a new managementObjectSearcher giving it the query
                            var diskDriveQuery = new ManagementObjectSearcher("Select * from Win32_DiskDrive where Name like'%" + physicalName + "'");
                            //Loop to Search the ManagementObjects in the query
                            foreach (ManagementObject dd in diskDriveQuery.Get())
                            {
                                //DiiskDrive
                                dDrive.driveStatus = Convert.ToString(dd.Properties["Status"].Value);//Disk Status
                                dDrive.physicalName = Convert.ToString(dd.Properties["Name"].Value); // \\.\PHYSICALDRIVE2
                                                                                                     //diskName = Convert.ToString(d.Properties["Caption"].Value); // WDC WD5001AALS-xxxxxx
                                dDrive.diskManufacturer = Convert.ToString(dd.Properties["Manufacturer"].Value);
                                dDrive.diskModel = Convert.ToString(dd.Properties["Model"].Value); // WDC WD5001AALS-xxxxxx
                                dDrive.diskInterface = Convert.ToString(dd.Properties["InterfaceType"].Value); // IDE
                                dDrive.mediaLoaded = Convert.ToBoolean(dd.Properties["MediaLoaded"].Value); // bool
                                dDrive.mediaType = Convert.ToString(dd.Properties["MediaType"].Value); // Fixed hard disk media
                                dDrive.mediaSignature = Convert.ToUInt32(dd.Properties["Signature"].Value); // int32
                                dDrive.mediaStatus = Convert.ToString(dd.Properties["Status"].Value); // OK
                                
                                
                            }//Logical Disk to Partition
                        }//DiskDrive to Partition
                        #endregion
                    }//Disk Drive
                }
                catch (Exception ex)
                {
                    //MessageBox.Show
                }
            }
        }


        public static string GetDriveInformation(string driveLetter)
        {
            driveInfo = "";

            LoadDriveInformation(driveLetter);

            if(dDrive.physicalName != null)
            {
                //Get the Physical Drive Number from the system EX: 0, 1, 2...
                //Can only be called once the drive name = the incoming selected drive Letter
                dDrive.physicalDriveNumber = Convert.ToInt32(dDrive.physicalName.Substring((dDrive.physicalName.Length - 1), 1));
            }
            
            //Write out the info to the string driveInfo
            driveInfo = Environment.NewLine;
            //Fill out the Information for the Drive
            //------------------------------------------
            //Check for if the drive has an OS
            isOSDrive = ISOSDrive(driveLetter);
            if (isOSDrive == true)
            {
                driveInfo += "OS Drive: True" + Environment.NewLine;
            }
            else
            {
                driveInfo += "OS Drive: False" + Environment.NewLine;
            }

            //Get Drive Type
            driveInfo += "DriveType: " + DriveType(dDrive.physicalDriveNumber) + Environment.NewLine;

            //Logical Disk
            driveInfo += "DriveName: " + ldisk.driveName + Environment.NewLine;
            driveInfo += "VolumeName: " + dDrive.volumeName + Environment.NewLine;
            driveInfo += "Status: " + dDrive.driveStatus + Environment.NewLine;
            driveInfo += "DriveCompressed: " + ldisk.driveCompressed + Environment.NewLine;
            //Get Device Type
            switch (ldisk.driveType)
            {
                case 0:
                    driveInfo += "DriveType: Unknown" + Environment.NewLine;
                    break;

                case 1:
                    driveInfo += "DriveType: No Root Directory" + Environment.NewLine;
                    break;

                case 2:
                    driveInfo += "DriveType: Removable Disk" + Environment.NewLine;
                    break;

                case 3:
                    driveInfo += "DriveType: Local Disk" + Environment.NewLine;
                    break;

                case 4:
                    driveInfo += "DriveType: Network Drive" + Environment.NewLine;
                    break;

                case 5:
                    driveInfo += "DriveType: Compact Disk" + Environment.NewLine;
                    break;

                case 6:
                    driveInfo += "DriveType: RAM Disk" + Environment.NewLine;
                    break;
            }
            driveInfo += "FileSystem: " + ldisk.fileSystem + Environment.NewLine;
            //Setup checking if any of the space is over 1000 GB
            //
            driveInfo += "Used Space: " + currSpace.usedSpace.ToString("0.00") + " GB" + Environment.NewLine;
            driveInfo += "Free Space: " + currSpace.freeSpace.ToString("0.00") + " GB" + Environment.NewLine;
            driveInfo += "Total Space: " + currSpace.totalSpace.ToString("0.00") + " GB" + Environment.NewLine;
            driveInfo += "DriveMediaType: " + dDrive.driveMediaType + Environment.NewLine;
            driveInfo += "VolumeSerial: " + dDrive.volumeSerial + Environment.NewLine;
            driveInfo += Environment.NewLine;

            //DiskDrive
            driveInfo += "PhysicalName: " + dDrive.physicalName + Environment.NewLine;
            driveInfo += "DiskManufacturer: " + dDrive.diskManufacturer + Environment.NewLine;
            driveInfo += "DiskModel: " + dDrive.diskModel + Environment.NewLine;
            driveInfo += "DiskInterface: " + dDrive.diskInterface + Environment.NewLine;
            driveInfo += "MediaLoaded: " + dDrive.mediaLoaded + Environment.NewLine;
            driveInfo += "MediaType: " + dDrive.mediaType + Environment.NewLine;
            driveInfo += "MediaSignature: " + dDrive.mediaSignature + Environment.NewLine;
            driveInfo += "MediaStatus: " + dDrive.mediaStatus + Environment.NewLine;
            driveInfo += Environment.NewLine;

            return driveInfo;
        }

        public static string GetDriveLabel(string driveLetter)
        {
            LoadDriveInformation(driveLetter);

            return dDrive.volumeName;
        }

        public static float GetDriveSize(string driveLetter)
        {
            LoadDriveInformation(driveLetter);

            return currSpace.totalSpace;
        }

        #region Detect OS Drive
        public static bool ISOSDrive(string driveLetter)
        {
            //Pre: requires driveLetter to be initialized
            //Post: returns true or false
            //Purpose: To see if the drive selected is contains an OS

            //Create string driveLetter/Windows
            driveLetter += @"\Windows";
            //Check if the drive has a folder called Windows 
            if (Directory.Exists(driveLetter))
            {
                //Return true if it exists
                return true;
            }
            else
            {
                //Else returns false
                return false;
            }
        }//End Detect OS Drive
        #endregion

        #region Drive Type
        //Some test code to get the drive type SSD HDD ect...
        private static string DriveType(int driveNumber)
        {
            ManagementScope scope = new ManagementScope(@"\\.\root\microsoft\windows\storage");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM MSFT_PhysicalDisk where DeviceId = " + driveNumber.ToString());
            string type = "";
            scope.Connect();
            searcher.Scope = scope;

            try
            {
                foreach (ManagementObject queryObj in searcher.Get())
                {
                    switch (Convert.ToInt16(queryObj["MediaType"]))
                    {
                        case 1:
                            type = "Unspecified";
                            return type;

                        case 3:
                            type = "HDD";
                            return type;

                        case 4:
                            type = "SSD";
                            return type;

                        case 5:
                            type = "SCM";
                            return type;

                        default:
                            type = "Unspecified";
                            return type;
                    }
                }
            }
            catch
            {

            }

            searcher.Dispose();

            return type;
        }
        #endregion
    }
}
