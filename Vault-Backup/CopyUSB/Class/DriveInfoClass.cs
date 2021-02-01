using System;
using System.IO; //Used to list the drives
using CopyUSB;


namespace UDiagnose.Classes
{
    
    class DriveInfoClass
    {
        //String to hold the drive details
        private string driveInfo;
        //Constants for conversions of different byt sizes
        const float FLOAT_GIG_CONVERSION = 1073741824f; //Holds the float conversion number of GB per bit
        const float FLOAT_TERA_CONVERSION = 0.0009765625F;//Holds the float conversion number for TB per bit
        public DriveInfoClass()
        {

        }

        #region Methods
        //Convert bytes to Gigabytes used to display correct drive information
        public float ConversionToGig(float conversionNum)
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
        public float ConversionToTer(float ConversionNum)
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

        #region Refresh Drive list
        public void RefreshDrives(frmMain main)
        {
            //Refresh the list
            main.lstDrives.Items.Clear();
            //Here we will update the list of drives in the system in case one was removed 
            foreach (DriveInfo di in DriveInfo.GetDrives())
            {
                main.lstDrives.Items.Add(di.Name);
                main.lstDrives.SelectedIndex = 0;
            }
        }
        #endregion

        #region Load Drive Info
        public string LoadDrives(string drive_letter)
        {
            //Pre: Needs to have the string drive_letter initialized
            //Pose: Returns string driveInfo
            //Purpose: To get the drive information of the incomming drive_letter

            driveInfo = null;//Set the string to null
            //Here we will set a couple variables.
            DriveInfo di = new DriveInfo(drive_letter); //Set the drive information as a new instance di
            float fltPercent = 0;//Set the float to 0

            //Here we will start to fill in the variable driveInfo
            driveInfo += "Drive Letter: " + di.Name + Environment.NewLine;
            driveInfo += "Drive Type: " + di.DriveType.ToString() + Environment.NewLine;
            driveInfo += "Is Drive Ready: " + di.IsReady.ToString() + Environment.NewLine;          
            //driveInfo = driveInfo + "RootDirectory: " +di.RootDirectory.Name + Environment.NewLine; //Not sure if I need the root directory

            if (di.IsReady)
            {
                //Information to populate the rich text box
                driveInfo += "Drive Name: " + di.VolumeLabel + Environment.NewLine;
                driveInfo += "Drive Format: " + di.DriveFormat + Environment.NewLine;

                //--
                //Need to convert these to TB by setting up if statements.
                driveInfo += "Used Space: " + (ConversionToGig(di.TotalSize) - ConversionToGig(di.AvailableFreeSpace)).ToString("0.00") + " GB" + Environment.NewLine;
                driveInfo += "Available Free Space: " + ConversionToGig(di.AvailableFreeSpace).ToString("0.00") + " GB" + Environment.NewLine;
                driveInfo += "Total Size: " + ConversionToGig(di.TotalSize).ToString("0.00") + " GB" + Environment.NewLine;
                //Calculate the percentage of the drive that has been filled.
                fltPercent = (((float)ConversionToGig(di.TotalSize) - (float)ConversionToGig(di.AvailableFreeSpace)) / (float)ConversionToGig(di.TotalSize)) * 100.0f;

                driveInfo += "Percent used: " + fltPercent.ToString("0.00") + "%";

                return driveInfo;
            }
            else
            {
                //Fills in the rich text box letting the user know the drive is not ready
                driveInfo = "Is Drive Ready: " + di.IsReady.ToString() + Environment.NewLine; //If not found set the information to nothing

                return driveInfo;
            }

        }
        #endregion
    }
}
