using ManagementLogic;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Managenment_Windows
{
    public partial class frmDeparment : Form
    {
        private bool isBack = false;
        private List<DataGridViewRow> selectedRows = new List<DataGridViewRow>();
        public frmDeparment()
        {
            InitializeComponent();
            LoadDepartments(Run.Instance.Management.DepartmentList);
        }
        private void LoadDepartments(List<Department> departments)
        {
            dtgMain.Columns.Clear();
            dtgMain.AutoGenerateColumns = false;

            string[,] columns = {
                { "ID", "Id" },
                { "Tên", "Name" },
                {"ID trưởng phòng","leaderId" }
            };

            for (int i = 0; i < columns.GetLength(0); i++)
            {
                dtgMain.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = columns[i, 0],
                    DataPropertyName = columns[i, 1]
                });
            }
            dtgMain.Columns["Tên"].Width = 150;
            dtgMain.DataSource = departments;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTuKhoa.Text;
            try
            {
                List<Department> departments = Run.Instance.FindIDeparment(keyword);
                LoadDepartments(departments);
                txtTuKhoa.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnXphDepartment_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in selectedRows)
            {
                
                Department department = row.DataBoundItem as Department;
                if (department != null)
                {
                    try
                    {
                        Run.Instance.RemoveDepart(department);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            selectedRows.Clear(); 
            LoadDepartments(Run.Instance.Management.DepartmentList);
        }
        private void dtgMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dtgMain.Rows.Count)
            {
                DataGridViewRow row = dtgMain.Rows[e.RowIndex];
              
                if (selectedRows.Contains(row))
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                    selectedRows.Remove(row);
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.LightBlue;
                    selectedRows.Add(row);
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDAdd frmDAdd = new frmDAdd();
            frmDAdd.ShowDialog();
            dtgMain.DataSource = null;
            LoadDepartments(Run.Instance.Management.DepartmentList);
            this.Show();
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            isBack = true;
            this.Close();
        }

        private void frmDeparment_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!isBack) 
                Application.Exit();
        }

        private void dtgMain_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < Run.Instance.Management.DepartmentList.Count)
            {
                string selected = dtgMain.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                Department selectDepart = null;
                foreach (Department department in Run.Instance.Management.DepartmentList)
                {
                    if (department.Id == selected)
                    {
                        selectDepart = department;
                        break;
                    }
                }
                if (selectDepart != null)
                {
                    this.Hide();
                    frmInfoDepartment frmInfoDepartment = new frmInfoDepartment(selectDepart);
                    frmInfoDepartment.ShowDialog();
                    dtgMain.DataSource = null;
                    LoadDepartments(Run.Instance.Management.DepartmentList);
                    this.Show();
                }
            }
        }

        private void dtgMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
