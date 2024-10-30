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
    public partial class frmProject : Form
    {
        private bool isBack = false;
        private List<DataGridViewRow> selectedRows = new List<DataGridViewRow>();
        public frmProject()
        {
            InitializeComponent();
            LoadProjects(Run.Instance.Management.ProjectList);
        }

        private void LoadProjects(List<Project> projects)
        {
            dtgMain.Columns.Clear();
            dtgMain.AutoGenerateColumns = true;
            dtgMain.DataSource = projects;
        }

        private void frmProject_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!isBack)
                Application.Exit();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            isBack = true;
            this.Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keywork = txtTuKhoa.Text;
            try
            {
                List<Project> projects = Run.Instance.FindProject(keywork);
                LoadProjects(projects);
                txtTuKhoa.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnXoaProject_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in selectedRows)
            {

                Project project  = row.DataBoundItem as Project;
                if (project != null)
                {
                    try
                    {
                        Run.Instance.RemoveProject(project);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            selectedRows.Clear();
            LoadProjects(Run.Instance.Management.ProjectList);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPAdd frmPAdd = new frmPAdd();
            frmPAdd.ShowDialog();
            LoadProjects(Run.Instance.Management.ProjectList);
            this.Show();
        }

        private void dtgMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
    }
}
