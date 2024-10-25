using ManagementLogic;
using System;
using System.Windows.Forms;

namespace Managenment_Windows
{
    public partial class frmInfoEmployee : Form
    {
        private Employee _employee;
        public frmInfoEmployee(Employee employee)
        {
            InitializeComponent();
            _employee = employee;
            lblID.Text += $" {_employee.Id}";
        }

        private void btnXnhEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                Run.Instance.RemoveEmployee(_employee);
                MessageBox.Show($"Nhân viên {_employee.Name} đã bị xóa");
                this.Close();
            }
            catch( Exception ex )
            {
                MessageBox.Show(ex.Message, "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
