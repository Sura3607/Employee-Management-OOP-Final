using ManagementLogic;
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
    public partial class frmDeparment : Form
    {
        private bool isBack = false;
        public frmDeparment()
        {
            InitializeComponent();
            LoadDepartments(Run.Instance.Management.DepartmentList);
        }
        private void LoadDepartments(List<Department> departments)
        {
            dtgMain.Columns.Clear();
            dtgMain.AutoGenerateColumns = true;
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

        }

        private void dtgMain_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < Run.Instance.Management.DepartmentList.Count)
            {
                string selected = dtgMain.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                Department selectDepart = null;
                foreach(Department department in Run.Instance.Management.DepartmentList)
                {
                    if(department.Id == selected)
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
                    this.Show();
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDAdd frmDAdd = new frmDAdd();
            frmDAdd.ShowDialog();
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
    }
}
