using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ManagementLogic
{
    public class Deparment
    {
        private string id;
        private string name;
        private Employee leader ;
        private List<Employee> employees ;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public Employee Leader { get => leader; set => leader = value; }
        public List<Employee> Employees { 
            get => employees; 
            set
            {
                if(value == null)
                    throw new ArgumentNullException();
            }
        }

        public bool AddEmployee(Employee employee)
        {
            return true;
        }
        public bool RemoveEmployee(Employee employee)
        {
            return true;
        }
        public bool Find(string keywork)
        {
            return true;
        }
    }
}