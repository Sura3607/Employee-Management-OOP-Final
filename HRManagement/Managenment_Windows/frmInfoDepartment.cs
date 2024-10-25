using ManagementLogic;
using System;
using System.Windows.Forms;

namespace Managenment_Windows
{
    public partial class frmInfoDepartment : Form
    {
        private Department _department;
        public frmInfoDepartment(Department department)
        {
            InitializeComponent();
            _department = department;
            lblID.Text += $" {_department.Id}";
        }

        private void btnXphDepartment_Click(object sender, EventArgs e)
        {
            try
            {
                Run.Instance.RemoveDepart(_department);
                MessageBox.Show($"Đã xóa phòng ban {_department.Name}");
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
