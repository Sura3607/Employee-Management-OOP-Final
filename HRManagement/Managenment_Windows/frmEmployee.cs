using ManagementLogic;
using System;
using System.Windows.Forms;

namespace Managenment_Windows
{
    public partial class frmEmployee : Form
    {
        public frmEmployee()
        {
            InitializeComponent();
            LoadEmployees();
        }
        private void dtgMain_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEAdd frmEAdd = new frmEAdd();
            frmEAdd.ShowDialog();
            this.Show();
        }

        private void frmEmployee_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LoadEmployees()
        {
            dtgEmployees.DataSource = Run.Instance.Management.EmployeesList;
        }
    }
}
