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
        public frmProject()
        {
            InitializeComponent();
            LoadProjects(Run.Instance.Management.ProjectList);
        }

        private void LoadProjects(List<Project> projects)
        {
            dtgMain.Columns.Clear();
            dtgMain.AutoGenerateColumns = false;

            dtgMain.Columns.Add(new DataGridViewTextBoxColumn { Name = "ID" , DataPropertyName = "Id"});
            dtgMain.Columns.Add(new DataGridViewTextBoxColumn { Name = "Name", DataPropertyName = "Name" });
            dtgMain.Columns.Add(new DataGridViewTextBoxColumn { Name = "Description", DataPropertyName = "Description" });
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEAdd frmEAdd = new frmEAdd();
            frmEAdd.ShowDialog();
            LoadProjects(Run.Instance.Management.ProjectList);
            this.Show();
        }

        private void btnXoaProject_Click(object sender, EventArgs e)
        {

        }
    }
}
