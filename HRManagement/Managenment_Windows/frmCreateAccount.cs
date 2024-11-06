using ManagementLogic;
using System;
using System.Windows.Forms;

namespace Managenment_Windows
{
    public partial class frmCreateAccount : Form
    {
        public frmCreateAccount()
        {
            InitializeComponent();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            string username = txtNameAccount.Text;
            string password = txtPassword.Text;

            try
            {
                Run.Instance.AddADMIN(username, password);
                MessageBox.Show($"Tài khoản: {username}\nMật khẩu: {password}\n Đã được tạo", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reset();
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message, "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void Reset()
        {
            txtNameAccount.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }

        private void btnTrolai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
