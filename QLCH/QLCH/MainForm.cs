using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLCH
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["Profile_User"] as Profile_User;
            if(form == null)
            {
                Profile_User profile = new Profile_User();
                profile.MdiParent = this;
                profile.Show();
            }
        }
    }
}
