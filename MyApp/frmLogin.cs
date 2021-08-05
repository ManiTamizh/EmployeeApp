using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyApp
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string strUserId = txtUname.Text.Trim();
            string strPassword = txtPassword.Text.Trim();
            if ((strUserId == "admin") && (strPassword == "admin"))
            {
                this.Hide();
                
            }
        }
    }
}
