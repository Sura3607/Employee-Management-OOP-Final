using ManagementLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Managenment_Windows
{
    public partial class frmPayroll : Form
    {
        public frmPayroll()
        {
            InitializeComponent();
        }
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void btnLoadEmployData_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            List<Employee> employees = new List<Employee>();

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
        private void comboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedType = LoaiNhanVien.SelectedItem.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmPayroll_Load(object sender, EventArgs e)
        {

        }

        
    }
}
