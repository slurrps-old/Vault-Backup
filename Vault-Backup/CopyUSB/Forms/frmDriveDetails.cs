using System;
using UDiagnose.Classes;
using ComponentFactory.Krypton.Toolkit;

namespace VaultBackup.Forms
{
    public partial class frmDriveDetails : KryptonForm
    {
        public string driveLetter;
        
        readonly DriveInfoClass drivesInfo = new DriveInfoClass();
        public frmDriveDetails()
        {
            InitializeComponent();
        }

        private void frmDriveDetails_Load(object sender, EventArgs e)
        {
            rtbDriveInfo.SelectionIndent = 10;
            rtbDriveInfo.Text = drivesInfo.LoadDrives(driveLetter);
        }
    }
}
