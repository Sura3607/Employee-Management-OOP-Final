using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementLogic
{
    public class Project
    {
        private int id;
        private string projectName;
        private string description;
        List<Employee> employees;
        Employee leader;

        public int Id { get => id; set => id = value; }
        public string ProjectName { get => projectName; set => projectName = value; }
        public string Description { get => description; set => description = value; }
        public List<Employee> Employees { get => employees; set => employees = value; }
        public Employee Leader { get => leader; set => leader = value; }
        public Project(int id, string projectName, string description, Employee leader = null)
        {
            Id = id;
            ProjectName = projectName;
            Description = description;
            Employees = employees;
            Leader = leader;
        }
        public void AddLeader(Employee leader)
        {
            Leader = leader;
        }
        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
        }
    }
}
