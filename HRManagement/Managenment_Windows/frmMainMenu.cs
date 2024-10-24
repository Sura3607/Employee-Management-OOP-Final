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
    public partial class frmMainMenu : Form
    {
        private frmLogin loginForm;
        public frmMainMenu(frmLogin previousForm)
        {
            InitializeComponent();
            this.loginForm = previousForm;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            loginForm.Show();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEmployee frmEmployee = new frmEmployee();
            frmEmployee.ShowDialog();
            this.Show();
        }

        private void frmMainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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
    }
}
