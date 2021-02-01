using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;


namespace UDiagnose.Forms
{
    public partial class frmFormatDetails : KryptonForm
    {
        //Set all of the public variables
        public string VolumeLabel = "";
        public bool quickFormat = true;
        public string fileSystem = "NFTS";
        public int allocationSize = 0;
        public bool compression = false;
        public bool canceled = false;

        public frmFormatDetails()
        {
            InitializeComponent();
        }

        private void frmPopup_Load(object sender, EventArgs e)
        {
            //Set the variables to the default values
            txtVolumeLabel.Text = "Untitled";
            cmbFileSystem.SelectedIndex = 0;
            cmbAllocationSize.SelectedIndex = 4;
        }//End frmPopup_Load

        private void btnAccept_Click(object sender, EventArgs e)
        {
            //Set variables
            int pos = 0;
            string temp;
            canceled = false;

            //Get Volume Label from user
            VolumeLabel = txtVolumeLabel.Text;

            //Check if quick format is checked
            if(chkQuickFormat.Checked == false)
            {
                quickFormat = false;
            }
            //Check to see if compression is selected.
            if(chkCompression.Checked == true)
            {
                compression = true;
            }

            //Get the file system that is selected by the user
            fileSystem = cmbFileSystem.SelectedItem.ToString();

            //Get Allocation size
            //Get the number from the text on the combo box
            temp = cmbAllocationSize.SelectedItem.ToString();
            pos = temp.IndexOf(" ");
            temp = temp.Substring(0, pos);
            //Check to see if the selected item is above the 4th item
            if(cmbAllocationSize.SelectedIndex > 4)
            {
                allocationSize = Convert.ToInt32(temp) * 1000;
            }
            else
            {
                allocationSize = Convert.ToInt32(temp);
            }
            //Close this form
            this.Close();
        }//End btnAccept_Click

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //Set canceled to true
            canceled = true;
            //Close this form
            this.Close();
        }//End btnCancel_Click

    }
}
