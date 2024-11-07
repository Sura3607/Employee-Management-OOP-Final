using ManagementLogic;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Managenment_Windows
{
    public partial class frmInfoDepartment : Form
    {
        private Department _department;
        private List<Employee> _employees = new List<Employee>();
        private int posLeader;
        public frmInfoDepartment(Department department)
        {
            InitializeComponent();
            _department = department;
            LoadInfo();
        }
        private void LoadInfo()
        {
            lblID.Text = $"ID:\t\t{_department.Id}";
            txtDepartment.Text = _department.Name;
            posLeader = -1;
            _employees.Clear();

            foreach (Employee employee in Run.Instance.Management.EmployeesList)
            {
                if(_department.EmployeesId.Contains(employee.Id))
                {                  
                    _employees.Add(employee);
                    if (employee.Id == _department.LeaderId)
                    {
                        posLeader = _employees.Count - 1;
                    }
                }
            }
            LoadLeader(_employees);
            cbLeader.SelectedIndex = posLeader;
            LoadGrid(_employees);
        }
        private void LoadLeader(List<Employee> list)
        {
            cbLeader.Items.Clear();
            foreach (Employee e in list)
                cbLeader.Items.Add(e);
        }
        private void LoadGrid(List<Employee> list)
        {
            dtgEmployees.Columns.Clear();
            dtgEmployees.AutoGenerateColumns = false;

            dtgEmployees.Columns.Add(new DataGridViewTextBoxColumn { Name = "ID", DataPropertyName = "Id" });
            dtgEmployees.Columns.Add(new DataGridViewTextBoxColumn { Name = "Name", DataPropertyName = "Name" });
            DataGridViewTextBoxColumn genderColumn = new DataGridViewTextBoxColumn();
            genderColumn.Name = "Gender";
            genderColumn.HeaderText = "Gender";
            genderColumn.DataPropertyName = "Gender";
            dtgEmployees.Columns.Add(genderColumn);
            dtgEmployees.Columns.Add(new DataGridViewTextBoxColumn { Name = "Beginwork", DataPropertyName = "Beginwork" });
            dtgEmployees.Columns.Add(new DataGridViewTextBoxColumn { Name = "Salary", DataPropertyName = "Salary" });
            dtgEmployees.DataSource = list;
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddRemoveEmployee_Depart frmAddRemoveEmployee = new frmAddRemoveEmployee_Depart(_department,_employees);
            frmAddRemoveEmployee.ShowDialog();
            LoadInfo();
            this.Show();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string newName = txtDepartment.Text != _department.Name ? txtDepartment.Text : null;
            Employee leader = (Employee)cbLeader.SelectedItem;
            string newLeader = leader.Id != _department.LeaderId ? leader.Id : null;
            try
            {
                Run.Instance.EditDepartment(_department, newName, newLeader, null, null);
                MessageBox.Show("Đã chỉnh sửa thành công");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
