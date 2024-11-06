using ManagementLogic;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Managenment_Windows
{
    public partial class frmTableSalary : Form
    {
        public frmTableSalary()
        {
            InitializeComponent();
            LoadEmployees(Run.Instance.Management.EmployeesList);
        }
        private void btnTroLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadEmployees(List<Employee> employees)
        {
            dataGridView1.Rows.Clear();

            foreach (Employee employee in employees)
            {

                if (employee is FulltimeEmployee fulltime)
                {
                    dataGridView1.Rows.Add(fulltime.Id, fulltime.Name, fulltime.Senority, "", fulltime.Salary, fulltime.CalculateSalary());
                }
                else if (employee is ParttimeEmployee parttime)
                {
                    dataGridView1.Rows.Add(parttime.Id, parttime.Name, "", parttime.Worktime, parttime.Salary, parttime.CalculateSalary());
                }
            }
            dataGridView1.Columns["EmployeeID"].Width = 75;
            dataGridView1.Columns["Senority"].Width = 95;
            dataGridView1.Columns["Worktime"].Width = 95;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }    
}
