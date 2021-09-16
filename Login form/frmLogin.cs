using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gobblins_Ghouls_n_Ghosts
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbxUsername.Text.Trim().Equals("") && tbxUsername.Text.Trim().Equals(""))
            {
                DialogResult dialogResult = MessageBox.Show("Would you like to Proceed as a guest?", "Empty Fields", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    //MessageBox.Show("Welcome, " + UserInfo.firstName + "!", "Gobblin' Ghouls n Ghosts | Welcome!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
                
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmSignup frmSignup = new frmSignup();
            frmSignup.ShowDialog();
        }
    }
}
