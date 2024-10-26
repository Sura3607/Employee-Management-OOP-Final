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
    public partial class frmDAdd : Form
    {
        private List<Employee> list;
        private List<Employee> selectList;
        public frmDAdd()
        {
            InitializeComponent();
            LoadList();
        }
        private void LoadList()
        {
            list = new List<Employee>();
            selectList = new List<Employee>();

            foreach(Employee e in Run.Instance.Management.EmployeesList)
            {
                if(e.Department == null)
                    list.Add(e); 
            }
            foreach (Employee e in list)
            {
                chklstList.Items.Add(e);
            }
            LoadLeader(selectList);
        }
        private void LoadLeader(List<Employee> list)
        {
            cbLeader.Items.Clear();
            foreach (Employee e in list)
                cbLeader.Items.Add(e);
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            Employee leader = (Employee)cbLeader.SelectedItem;

            try
            {
                Run.Instance.CreateDepart(name, leader, selectList);
                MessageBox.Show($"Phòng ban {name} được tạo thành công");
                Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 

        }
        private void Reset()
        {
            txtName.Text = string.Empty;
            LoadList();
            cbLeader.SelectedIndex = -1;
        }
        private void btnAddAll_Click(object sender, EventArgs e)
        {
            foreach(Employee employee in chklstList.Items)
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
            foreach(Employee employee in chklstList.CheckedItems)
            {
                if(employee != null)
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
            foreach(Employee employee in chklstSelect.CheckedItems)
            {
                if(employee != null)
                {
                    selectList.Remove(employee);
                    chklstSelect.Items.Remove (employee);

                    list.Add(employee);
                    chklstList.Items.Add (employee);
                }
            }
            LoadLeader(selectList);
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            foreach(Employee employee in chklstSelect.Items)
            {
                selectList.Remove(employee);
                chklstSelect.Items.Remove(employee);

                list.Add(employee);
                chklstList.Items.Add(employee);
            }
            LoadLeader(selectList);
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
