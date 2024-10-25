using ManagementLogic;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Managenment_Windows
{
    public partial class frmEmployee : Form
    {
        public frmEmployee()
        {
            InitializeComponent();
            LoadEmployees(Run.Instance.Management.EmployeesList);
        }
        private void dtgMain_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < Run.Instance.Management.EmployeesList.Count)
            {
                
                string selectedEmployeeId = dtgEmployees.Rows[e.RowIndex].Cells["ID"].Value.ToString();

                Employee selectedEmployee = null;
                foreach (Employee emp in Run.Instance.Management.EmployeesList)
                {
                    if (emp.Id == selectedEmployeeId)
                    {
                        selectedEmployee = emp;
                        break; 
                    }
                }
                if (selectedEmployee != null)
                {
                    this.Hide();
                    frmInfoEmployee frmInfoEmployee = new frmInfoEmployee(selectedEmployee);
                    frmInfoEmployee.ShowDialog();
                    this.Show();
                }
            }
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
        private void LoadEmployees(List<Employee> list)
        {
            dtgEmployees.Columns.Clear();  
            dtgEmployees.AutoGenerateColumns = false;

            dtgEmployees.Columns.Add(new DataGridViewTextBoxColumn { Name = "ID", DataPropertyName = "id" });
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

        private void dtgEmployees_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dtgEmployees.Columns[e.ColumnIndex].Name == "Gender" && e.Value is bool)
            {
                e.Value = (bool)e.Value ? "Nam" : "Nữ";
                e.FormattingApplied = true;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keywork = txtTuKhoa.Text;
            try
            {
                List<Employee> employees = Run.Instance.FindEmployee(keywork);
                LoadEmployees(employees);
                txtTuKhoa.Text = string.Empty;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
