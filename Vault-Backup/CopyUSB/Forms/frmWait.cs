using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace UDiagnose.Popups
{
    public partial class frmWait : KryptonForm
    {
        public frmWait()
        {
            InitializeComponent();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            //Close the form
            this.Close();
        }//End btnAccept_Click
    }
}
