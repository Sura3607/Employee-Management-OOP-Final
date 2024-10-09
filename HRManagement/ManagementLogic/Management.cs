using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ManagementLogic
{
    public class Management
    {
        private string password;
        List<Employee> employeesList= new List<Employee>();
        List<IDeparment> departmentList = new List<IDeparment>();
        Data data;
        public Management()
        {
            password = "@Admin123";          
        }

        private bool IsValidPasswordCreate(string password)
        {
            return !string.IsNullOrEmpty(password) &&
                   password.Any(char.IsUpper) &&
                   password.Any(ch => !char.IsLetterOrDigit(ch));
        }
        private bool IsValidPassword(string password)
        {
            return this.password == password;
        }

        public bool ChangePassword(string currentPassword, string newPassword)
        {
            if (IsValidPasswordCreate(newPassword) && IsValidPassword(currentPassword))
            {
                this.password = newPassword;
                return true;
            }
            return false;
        }

        public List<Employee> FindEmployee(string keyword,List<Employee> employlist)
        {
            List<Employee> l = new List<Employee>();
            foreach(Employee e in employlist)
            {
                if (e.Find(keyword))
                {
                    l.Add(e);
                }
            }
            return l;
        }
        public List<IDeparment> FindIDeparment(string keyword)
        {
            List<IDeparment> l = new List<IDeparment>();
            foreach (IDeparment d in departmentList)
            {
                if (d.Find(keyword))
                {
                    l.Add(d);
                }
            }
            return l;
        }

        public void Add(Employee e)
        {

        }
        public void Add(IDeparment d)
        {

        }
        public void Remove(Employee e)
        {

        }
        public void Remove(IDeparment d)
        {

        }
        public void UpdateSalary(Employee e)
        {

        }

        public bool AcceptOff(Employee e)
        {
            return false;
        }

    }
}