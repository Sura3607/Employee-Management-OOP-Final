using ManagementLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Managenment_Windows
{
    public partial class frmPAdd : Form
    {
        private List<Employee> list;
        private List<Employee> selectList;
        public frmPAdd()
        {
            InitializeComponent();
            LoadList();
        }
        private void LoadList()
        {
            list = new List<Employee>();
            selectList = new List<Employee>();

            foreach (Employee e in Run.Instance.Management.EmployeesList)
            {
                if (e.Projects.Count == 0)
                {
                    list.Add(e);
                    chklstList.Items.Add(e);
                }

            }
            LoadLeader(selectList);
        }
        private void LoadLeader(List<Employee> list)
        {
            cbLeader.Items.Clear();
            foreach (Employee e in list)
                cbLeader.Items.Add(e);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            Employee leader = (Employee)cbLeader.SelectedItem;

            try
            {
                Run.Instance.CreateProject(name, leader, selectList);
                MessageBox.Show($"Dự án {name} được tạo thành công");
                Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Reset()
        {
            textBox1.Text = string.Empty;

            chklstSelect.Items.Clear();
            selectList.Clear();

            cbLeader.SelectedIndex = -1;

            chklstList.Items.Clear();
            list.Clear();

            foreach (Employee e in Run.Instance.Management.EmployeesList)
            {
                if (e.Projects == null)
                {
                    list.Add(e);
                    chklstList.Items.Add(e);
                }
            }

            LoadLeader(selectList);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddAll_Click(object sender, EventArgs e)
        {
            List<Employee> listSelected = chklstList.Items.OfType<Employee>().ToList();
            foreach (Employee employee in listSelected)
            {
                selectList.Add(employee);
                chklstSelect.Items.Add(employee);

                list.Remove(employee);
                chklstList.Items.Remove(employee);
            }
            LoadLeader(selectList);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            List<Employee> listSelected = chklstList.CheckedItems.OfType<Employee>().ToList();
            foreach (Employee employee in listSelected)
            {
                if (employee != null)
                {
                    selectList.Add(employee);
                    chklstSelect.Items.Add(employee);

                    list.Remove(employee);
                    chklstList.Items.Remove(employee);
                }
            }
            LoadLeader(selectList);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            List<Employee> listSelected = chklstSelect.CheckedItems.OfType<Employee>().ToList();
            foreach (Employee employee in listSelected)
            {
                if (employee != null)
                {
                    selectList.Remove(employee);
                    chklstSelect.Items.Remove(employee);

                    list.Add(employee);
                    chklstList.Items.Add(employee);
                }
            }
            LoadLeader(selectList);
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            List<Employee> listSelected = chklstSelect.Items.OfType<Employee>().ToList();
            foreach (Employee employee in listSelected)
            {
                selectList.Remove(employee);
                chklstSelect.Items.Remove(employee);

                list.Add(employee);
                chklstList.Items.Add(employee);
            }
            LoadLeader(selectList);
        }
    }
}
