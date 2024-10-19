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
    public partial class Login : Form
    {
        public Login()
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
                MessageBox.Show("Đăng nhập thành công");
                this.Hide();
                MainMenu mainMenu = new MainMenu();
                mainMenu.ShowDialog();
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
