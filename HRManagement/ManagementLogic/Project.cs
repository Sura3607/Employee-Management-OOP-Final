using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ManagementLogic
{
    [Serializable]
    public class Project : ISerializable
    {
        private string id;
        private string projectName;
        private string description;
        private string leaderId;
        private List<string> employeesId;

        public string Id
        {
            get => id;
            set
            {
                if (string.IsNullOrWhiteSpace(value)) // Ktra xem Id co null ko
                    throw new ArgumentException("Id không được để trống");
                id = value;
            }
        }
        public string ProjectName 
        {
            get => projectName;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Tên project không được để trống");
                projectName = value;
            } 
        }
        public string Description 
        {
            get => description;
            set
            {
                if (value.Length > 250)
                    throw new ArgumentException("Không được quá 250 ký tự");
                description = value;
            }
        }
        
        public List<string> EmployeesId { get => employeesId; set => employeesId = value; }
        
        public string LeaderId { get => leaderId; set => leaderId = value; }

        public Project() { }
        public Project(string id, string projectName, Employee leader, List<Employee> employees = null,string description = "")
        {
            Id = id;
            ProjectName = projectName;
            Description = description;
            LeaderId = leader.Id;

            EmployeesId = new List<string>();
            if(employees != null)
            {
                foreach(Employee employee in employees)
                    EmployeesId.Add(employee.Id);
            }
        }
        public Project(SerializationInfo info, StreamingContext context)
        {
            Id = info.GetString("Id");
            ProjectName = info.GetString("ProjectName");
            Description = info.GetString("Description");
            leaderId = info.GetString("Leader");
            EmployeesId = (List<string>)info.GetValue("Employees", typeof(List<string>));
        }
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Id", Id);
            info.AddValue("ProjectName", ProjectName);
            info.AddValue("Description", Description);
            info.AddValue("Leader",leaderId);
            info.AddValue("Employees",EmployeesId);
        }
        public void AddEmployee(Employee e)
        {
            if (e == null)
                throw new ArgumentException("Thêm nhân viên thành công");
            if (EmployeesId.Contains(e.Id))
                throw new ArgumentException("Nhân viên đã tồn tại");
            EmployeesId.Add(e.Id);
            e.AddProject(this);

        }
        public void RemoveEmployee(Employee employee)
        {

            if (!EmployeesId.Contains(employee.Id))
                throw new ArgumentException("Không tìm thấy nhân viên này");

            if (leaderId == employee.Id)
                leaderId = null;

            EmployeesId.Remove(employee.Id);
            employee.Projects.Remove(this);
        }
        public bool Find(string keyword)
        {
            return Id.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0 ||
                   ProjectName.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0;
        }        
    }
}
