using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace complaintProgramInput
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLogin.PerformClick();
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtPassword.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            session sessionLogin = new session();
            sessionLogin.login(txtUsername.Text, txtPassword.Text);
            //MessageBox.Show(sessionLogin.ID);
            if (sessionLogin.passwordWrong == true)
            {
                MessageBox.Show("Wrong username/password!");
                wipeTxt(2);
                return;
            }
            else //its a true login
            {
                frmMain frm = new frmMain(Convert.ToInt32(sessionLogin.ID));
                frm.Show();
                this.Hide();
            }
            
        }

        private void wipeTxt(int num)
        {
            if (num == 2) //only wipe pass
                txtPassword.Text = "";
        }

    }
}
