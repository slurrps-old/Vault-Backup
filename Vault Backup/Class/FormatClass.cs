using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vault_Backup.Class
{
    public class FormatClass
    {

        #region FormatDrives
        //Used to format drives attached to the computer
        public static bool FormatDrive(string driveLetter, string label, string fileSystem, bool quickFormat, 
            int clusterSize, bool enableCompression)
        {
            if (driveLetter.Length != 2 || driveLetter[1] != ':' || !char.IsLetter(driveLetter[0]))
                return false;

            //query and format given drive         
            ManagementObjectSearcher searcher = new ManagementObjectSearcher
             (@"select * from Win32_Volume WHERE DriveLetter = '" + driveLetter + "'");
            foreach (ManagementObject vi in searcher.Get())
            {
                vi.InvokeMethod("Format", new object[]
              { fileSystem, quickFormat,clusterSize, label, enableCompression });
            }

            return true;
        }
        #endregion
    }
}
