using ManagementLogic;
using System;
using System.Collections.Generic;
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
            LoadInfo();
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
        private void LoadInfo()
        {
            lblID.Text += $" {_employee.Id}";
            txtName.Text = _employee.Name;
            txtPhone.Text = _employee.Phone;
            txtAddress.Text = _employee.Address;
            txtEmail.Text = _employee.Email;
            txtSalary.Text = $"{_employee.Salary}" ;
            dtBirthday.Value = _employee.Birthday;

            //Load Depart
            if (Run.Instance.Management.DepartmentList != null && Run.Instance.Management.DepartmentList.Count > 0)
            {
                cbDepart.DataSource = Run.Instance.Management.DepartmentList;
                int pos = cbDepart.Items.IndexOf(_employee.Department);
                cbDepart.SelectedIndex = pos >= 0 ? pos : -1; 
            }

            // Load Gender
            cbGender.Items.Clear();
            cbGender.Items.Add("Nam");
            cbGender.Items.Add("Nữ");
            cbGender.SelectedIndex = _employee.Gender ? 0 : 1; // 0 là Nam, 1 là Nữ

            
            LoadProject();
        }

        private void LoadProject()
        {
            dtgProjects.Columns.Clear();
            dtgProjects.AutoGenerateColumns = false;

            dtgProjects.Columns.Add(new DataGridViewTextBoxColumn { Name = "ID", DataPropertyName = "Id" });
            dtgProjects.Columns.Add(new DataGridViewTextBoxColumn { Name = "Name", DataPropertyName = "ProjectName" });
            dtgProjects.Columns.Add(new DataGridViewTextBoxColumn { Name = "Description", DataPropertyName = "Description" });

            dtgProjects.DataSource = _employee.Projects ?? new List<Project>();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string newName = txtName.Text != _employee.Name ? txtName.Text : null;
            string newPhone = txtPhone.Text != _employee.Phone ? txtPhone.Text : null;
            string newEmail = txtEmail.Text != _employee.Email ? txtEmail.Text : null;
            string newAddress = txtAddress.Text != _employee.Address ? txtAddress.Text : null;
            Department newDepartment = (Department)cbDepart.SelectedItem != _employee.Department ? (Department)cbDepart.SelectedItem : null;
            bool selectedGender = cbGender.SelectedIndex == 0; 
            bool? newGender = selectedGender != _employee.Gender ? (bool?)selectedGender : null;
            uint newSalary = uint.Parse(txtSalary.Text) != _employee.Salary ? uint.Parse(txtSalary.Text) : uint.Parse(null);
            DateTime? newBirthday = dtBirthday.Value != _employee.Birthday ? dtBirthday.Value : (DateTime?)null;

            try
            {
                Run.Instance.EditEmployee(_employee, newName, newPhone, newEmail, 
                                        newAddress, newGender, newBirthday, newSalary, newDepartment);
                MessageBox.Show("Lưu thay đổi");
                LoadInfo();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
