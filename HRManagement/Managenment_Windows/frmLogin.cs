using ManagementLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Managenment_Windows
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Login_click(object sender, EventArgs e)
        {
            string username = txtTenTaiKhoan.Text;
            string password = txtMatKhau.Text;

            try
            {
                Run.Instance.Login(username, password);
                MessageBox.Show("Đăng nhập thành công","Chú ý" ,MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                frmMainMenu mainMenu = new frmMainMenu();
                mainMenu.ShowDialog();
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private bool isPasswordHidden = true;

        private void btnShowHidePassword_Click(object sender, EventArgs e)
        {
            if (isPasswordHidden)
            {
                // Hiện mật khẩu
                txtMatKhau.UseSystemPasswordChar = false;
                btnShowHidePassword.Text = "Hide"; 
            }
            else
            {
                // Ẩn mật khẩu
                txtMatKhau.UseSystemPasswordChar = true;
                btnShowHidePassword.Text = "Show";
            }

            isPasswordHidden = !isPasswordHidden;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
