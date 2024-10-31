using System;
using System.Windows.Forms;

namespace Managenment_Windows
{
    public partial class frmAccount : Form
    {
        private frmMainMenu frmMainMenu;
        private frmLogin frmLogin;
        public frmAccount(frmMainMenu frmMainMenu, frmLogin frmLogin)
        {
            InitializeComponent();
            this.frmMainMenu = frmMainMenu;
            this.frmLogin = frmLogin;
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCreateAccount frmCreateAccount = new frmCreateAccount();
            frmCreateAccount.ShowDialog();
            this.Show();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmChangePassword frmChangePassword = new frmChangePassword();
            frmChangePassword.ShowDialog();
            this.Show();
        }
    }
}
