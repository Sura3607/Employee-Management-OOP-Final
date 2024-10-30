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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmTableSalary_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            string keyword = txtboxSearch.Text.ToLower();
            try
            {
                List<Employee> employees = Run.Instance.FindEmployee(keyword);
                LoadEmployees(employees);
                txtboxSearch.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void txtboxSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbboxLoaiNv_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedType = cbboxLoaiNv.SelectedItem?.ToString();
            List<Employee> filteredEmployees = new List<Employee>();

            foreach (var employee in Run.Instance.Management.EmployeesList)
            {
                // Kiểm tra loại nhân viên và thêm vào danh sách đã lọc
                if (selectedType == "Full-time" && employee is FulltimeEmployee)
                {
                    filteredEmployees.Add(employee);
                }
                else if (selectedType == "Part-time" && employee is ParttimeEmployee)
                {
                    filteredEmployees.Add(employee);
                }
                else if (selectedType == "All")
                {
                    filteredEmployees.Add(employee); 
                }

                LoadEmployees(filteredEmployees);
            }
        }
        private void LoadEmployees(List<Employee> employees)
        {
            dataGridView1.Rows.Clear();

            foreach (var employee in employees)
            {
                double calculatedSalary = 0;

                if (employee is FulltimeEmployee fulltime)
                {
                    calculatedSalary = fulltime.CalculateSalary();
                    dataGridView1.Rows.Add(fulltime.Id, fulltime.Name, fulltime.Senority, "", fulltime.Salary, calculatedSalary);
                }
                else if (employee is ParttimeEmployee parttime)
                {
                    calculatedSalary = parttime.CalculateSalary();
                    dataGridView1.Rows.Add(parttime.Id, parttime.Name, "", parttime.Worktime, parttime.Salary, calculatedSalary);
                }
            }
        }
    }
        
}
