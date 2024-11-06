using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ManagementLogic
{
    [Serializable]
    public class Department :ISerializable
    {
        private string id;
        private string name;
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
        public string Name 
        {
            get => name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Tên phòng ban không được để trống");
                name = value;
            }
        }
        public string LeaderId { get => leaderId; set => leaderId = value; }
        
        public List<string> EmployeesId { get => employeesId; set => employeesId = value; }
      
        public Department() { }

        public Department(string id, string name, Employee leader, List<Employee> employees = null) 
        {
            if (leader is ParttimeEmployee)
                throw new Exception("Leader không được là nhân viên partime");
            Id = id;
            Name = name;
            LeaderId = leader.Id;

            EmployeesId = new List<string>();
            if(employees != null)
            {
                foreach (Employee e in employees)
                {
                    EmployeesId.Add(e.Id);
                }
            }              
        }
        public Department(SerializationInfo info, StreamingContext context)
        {
            Id = info.GetString("Id");
            Name = info.GetString("Name");
            LeaderId = info.GetString("Leader");
            EmployeesId = (List<string>)info.GetValue("Employees", typeof(List<string>));
            
        }
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Id", Id);
            info.AddValue("Name", Name);
            info.AddValue("Leader",LeaderId);
            info.AddValue("Employees",EmployeesId);
        }
        public void AddEmployee(Employee e)
        {
            if (e == null)
                throw new ArgumentException("Thêm nhân viên thất bại");
            if (EmployeesId.Contains(e.Id))
                throw new ArgumentException("Nhân viên đã tồn tại");

            employeesId.Add(e.Id);
            e.Department = this;
        }
        public void RemoveEmployee(Employee employee)
        {
            if (!EmployeesId.Contains(employee.Id))
                throw new ArgumentException("Không tìm thấy nhân viên này");

            if (leaderId == employee.Id)            
                leaderId = null;                

            EmployeesId.Remove(employee.Id);
            employee.Department = null;
        }
        public bool Find(string keyword)
        {
            return Id.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0 ||
                   Name.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0;
        }
        public override string ToString()
        {
            return name;
        }
    }
}