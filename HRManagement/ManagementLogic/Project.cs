using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ManagementLogic
{
    [Serializable]
    public class Project : ISerializable
    {
        private string id;
        private string projectName;
        private string description;
        List<Employee> employees;
        Employee leader;

        public string Id { get => id; set => id = value; }
        public string ProjectName { get => projectName; set => projectName = value; }
        public string Description { get => description; set => description = value; }
        public List<Employee> Employees { get => employees; set => employees = value; }
        public Employee Leader { get => leader; set => leader = value; }
        public Project(string id, string projectName, Employee leader = null, string description = "")
        {
            Id = id;
            ProjectName = projectName;
            Description = description;
            Employees = employees;
            Leader = leader;
        }
        public Project(SerializationInfo info, StreamingContext context)
        {
            Id = info.GetString("Id");
            ProjectName = info.GetString("ProjectName");
            Description = info.GetString("Description");
            Employees = (List<Employee>)info.GetValue("Employees",typeof(List<Employee>));
            Leader = (Employee)info.GetValue("Leader", typeof(Employee));
        }
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Id", Id);
            info.AddValue("ProjectName", ProjectName);
            info.AddValue("Description", Description);
            info.AddValue("Employees", Employees);
            info.AddValue("Leader",Leader);
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
