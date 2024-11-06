using System;
using System.Windows.Forms;

namespace Managenment_Windows
{
    public partial class frmMainMenu : Form
    {
        private frmLogin loginForm;
        private bool isLogOut =false;
        public frmMainMenu(frmLogin previousForm)
        {
            InitializeComponent();
            this.loginForm = previousForm;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            isLogOut = true;
            this.Close();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEmployee frmEmployee = new frmEmployee();
            frmEmployee.ShowDialog();
            this.Show();
        }


        private void btnPhongBan_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDeparment frmDeparment = new frmDeparment();
            frmDeparment.ShowDialog();
            this.Show();
        }

        private void btnDuAn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmProject frmProject = new frmProject();
            frmProject.ShowDialog();
            this.Show();
        }

        private void btnTableSalary_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTableSalary frmTableSalary = new frmTableSalary();
            frmTableSalary.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAccount frmAccount = new frmAccount(this,loginForm);
            frmAccount.ShowDialog();
            this.Show();
        }

        private void frmMainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(isLogOut)
            {
                loginForm.Show();
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
