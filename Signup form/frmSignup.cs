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
    public partial class frmSignup : Form
    {
        public frmSignup()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (tbxFirstName.Text.Trim().Equals(String.Empty) || tbxLastName.Text.Trim().Equals(String.Empty) || tbxCity.Text.Trim().Equals(String.Empty) || tbxState.Text.Trim().Equals(String.Empty) || tbxAddress.Text.Trim().Equals(String.Empty)
               || tbxUsername.Text.Trim().Equals(String.Empty) || tbxPassword.Text.Trim().Equals(String.Empty) || tbxConfirmPassword.Text.Trim().Equals(String.Empty) || tbxEmail.Text.Trim().Equals(String.Empty))
            {
                MessageBox.Show("One or more field are empty!", "Input Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (tbxPassword.Text.Trim() != tbxConfirmPassword.Text.Trim())
                {
                    MessageBox.Show("Passwords do not match!", "Password Input Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    //temp messagebox
                    MessageBox.Show("User created", "New User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }

                
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //Close the form
            this.Close();
        }
    }
}
