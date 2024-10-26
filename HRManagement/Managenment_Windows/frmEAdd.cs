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
    public partial class frmEAdd : Form
    {
        
        public frmEAdd()
        {
            InitializeComponent();
            AddItemsToComboBox();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblBirthday_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();  
        }

        private void frmEAdd_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string name = textName.Text;
            string phone = textSDT.Text;
            string email = textEmail.Text;
            string address = textAddress.Text;
            bool gender = CheckGender(comboGender.SelectedItem?.ToString());
            DateTime birthday = dtBirthday.Value;
            DateTime beginWork = dtBeginWork.Value;
            Department deparment = (Department)comboDepart.SelectedItem;
            uint salary = uint.Parse(textSalary.Text);
            bool isFullTime = CheckFullTime(comboHinhthuc.SelectedItem?.ToString());

            try
            {
                Run.Instance.CreateEmployee(name, phone, email, address, 
                                            gender,birthday,beginWork, deparment,salary,gender);
                MessageBox.Show("Thêm nhân viên thành công");
                Reset();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void AddItemsToComboBox()
        {
            comboGender.Items.Add("Nam");
            comboGender.Items.Add("Nữ");

            comboDepart.DataSource = Run.Instance.Management.DepartmentList;

            comboHinhthuc.Items.Add("FullTime");
            comboHinhthuc.Items.Add("PartTime");


            comboGender.SelectedIndex = 0;
            comboDepart.SelectedIndex = -1;
            comboHinhthuc.SelectedIndex = -1;
        }
        private bool CheckGender(string gender)
        {
            if(gender == "Nam")
                return true;
            return false;
        }
        private bool CheckFullTime(string type)
        {
            if(type == "FullTime")
                return true;
            return false;
        }
        private void Reset()
        {
            textName.Text = string.Empty;
            textSDT.Text = string.Empty;
            textEmail.Text = string.Empty;
            textAddress.Text = string.Empty;
            dtBeginWork.Value = DateTime.Now;
            dtBirthday.Value = DateTime.Now;
            comboGender.SelectedIndex = 0;
            comboDepart.SelectedIndex = -1;
            comboHinhthuc.SelectedIndex = -1;
            textSalary.Text = string.Empty;
        }
    }
}
