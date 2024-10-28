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
    public partial class frmAddRemoveEmployee : Form
    {
        private Department _department;
        private List<Employee> list;
        private List<Employee> selectList;
        private List<Employee> initialSelectList;
        public frmAddRemoveEmployee(Department department,List<Employee>select)
        {
            InitializeComponent();
            _department = department;
            initialSelectList = new List<Employee>(select);
            selectList = select;
            LoadList();
        }
        private void LoadList()
        {
            chklstList.Items.Clear();
            chklstSelect.Items.Clear();
            list = new List<Employee>();

            foreach (Employee e in Run.Instance.Management.EmployeesList)
            {
                if (e.Department == null)
                {
                    list.Add(e);
                    chklstList.Items.Add(e);
                }
            }
            foreach (Employee e in selectList)
            {
                chklstSelect.Items.Add(e);
            }
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
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            List<Employee> addedEmployees = new List<Employee>();
            List<Employee> removedEmployees = new List<Employee>();
            foreach (Employee employee in selectList)
            {
                if (!initialSelectList.Contains(employee))
                {
                    addedEmployees.Add(employee);
                }
            }

            foreach (Employee initialEmployee in initialSelectList)
            {
                if (!selectList.Contains(initialEmployee))
                {
                    removedEmployees.Add(initialEmployee);
                }
            }
            try
            {
                Run.Instance.EditDepartment(_department,null,null, removedEmployees, addedEmployees);
                MessageBox.Show("Nhân viên trong phòng ban đã được chỉnh sửa");
                initialSelectList = new List<Employee>(selectList);
                LoadList();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
