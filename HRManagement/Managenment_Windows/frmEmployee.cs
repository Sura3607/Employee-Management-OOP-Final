using ManagementLogic;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Managenment_Windows
{
    public partial class frmEmployee : Form
    {
        private bool isBack = false;
        public frmEmployee()
        {
            InitializeComponent();
            LoadEmployees(Run.Instance.Management.EmployeesList);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEAdd frmEAdd = new frmEAdd();
            frmEAdd.ShowDialog();
            dtgEmployees.DataSource = null;
            LoadEmployees(Run.Instance.Management.EmployeesList);
            this.Show();
        }

        private void LoadEmployees(List<Employee> list)
        {
            dtgEmployees.Columns.Clear();
            dtgEmployees.AutoGenerateColumns = false;

            string[,] columns = {
                { "ID", "Id" },
                { "Tên", "Name" },
                { "Giới tính", "Gender" },
                { "Ngày vào làm", "Beginwork" },
                { "Lương", "Salary" }
            };

            for (int i = 0; i < columns.GetLength(0); i++)
            {
                dtgEmployees.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = columns[i, 0],
                    DataPropertyName = columns[i, 1]
                });
            }

            dtgEmployees.DataSource = list;
        }

        private void dtgEmployees_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dtgEmployees.Columns[e.ColumnIndex].Name == "Giới tính" && e.Value is bool)
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
        private void btnHuy_Click(object sender, EventArgs e)
        {
            isBack = true;
            this.Close();
        }
        private void frmEmployee_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!isBack)
                Application.Exit();
        }

        private void dtgEmployees_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
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
                    dtgEmployees.DataSource = null;
                    LoadEmployees(Run.Instance.Management.EmployeesList);
                    this.Show();
                }
            }
        }
    }
}
