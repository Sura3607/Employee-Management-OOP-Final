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

    public partial class frmInfoProject : Form
    {
        private Project _project;
        private List<Employee> _employees = new List<Employee>();
        private int posLeader;
        public frmInfoProject(Project project)
        {
            InitializeComponent();
            _project = project;
            LoadInfo();
        }
        private void LoadInfo()
        {
            lblID.Text += $"\t\t{_project.Id}";
            textBox2.Text = _project.ProjectName;
            textBox3.Text = _project.Description;
            posLeader = -1;
            _employees.Clear();

            foreach (Employee employee in Run.Instance.Management.EmployeesList)
            {
                if (_project.EmployeesId.Contains(employee.Id))
                {
                    _employees.Add(employee);
                    if (employee.Id == _project.LeaderId)
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
            dtgProjects.Columns.Clear();
            dtgProjects.AutoGenerateColumns = false;

            dtgProjects.Columns.Add(new DataGridViewTextBoxColumn { Name = "ID", DataPropertyName = "Id" });
            dtgProjects.Columns.Add(new DataGridViewTextBoxColumn { Name = "Name", DataPropertyName = "Name" });
            DataGridViewTextBoxColumn genderColumn = new DataGridViewTextBoxColumn();
            genderColumn.Name = "Gender";
            genderColumn.HeaderText = "Gender";
            genderColumn.DataPropertyName = "Gender";
            dtgProjects.Columns.Add(genderColumn);
            dtgProjects.Columns.Add(new DataGridViewTextBoxColumn { Name = "Beginwork", DataPropertyName = "Beginwork" });
            dtgProjects.Columns.Add(new DataGridViewTextBoxColumn { Name = "Salary", DataPropertyName = "Salary" });
            dtgProjects.DataSource = list;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string newName = textBox2.Text != _project.ProjectName ? textBox2.Text : null;
            Employee leader = (Employee)cbLeader.SelectedItem;
            string newLeader = leader.Id != _project.LeaderId ? leader.Id : null;
            string newDescription = textBox3.Text != _project.Description ? _project.Description : null;
            try
            {
                Run.Instance.EditProject(_project, newName,newDescription ,newLeader, null, null);
            }
            catch (Exception ex)
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
            //this.Hide();
            //frmAddRemoveEmployee frmAddRemoveEmployee = new frmAddRemoveEmployee(department, _employees);
            //frmAddRemoveEmployee.ShowDialog();
            //LoadInfo();
            //this.Show();
        }

        private void btnXoaProject_Click(object sender, EventArgs e)
        {
            try
            {
                Run.Instance.RemoveProject(_project);
                MessageBox.Show($"Đã xóa dự án {_project.ProjectName}");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
