using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace ManagementLogic
{
    [Serializable]
    public class Department :ISerializable
    {
        private string id;
        private string name;
        private Employee leader ;
        private List<Employee> employees ;
        //Thêm điều kiện khi set cho các thuộc tính -Leader ko phải parttime-
        public string Id 
        {
            get => id;
            set
            {
                if (string.IsNullOrWhiteSpace(value)) // Ktra xem Id co null ko
                    throw new ArgumentException("Id khong duoc de trong");
                id = value;
            }
        }
        public string Name 
        {
            get => name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Ten phong ban khong duoc de trong");
                name = value;
            }
        }
        public Employee Leader
        {
            get => leader;
            set
            {
                if (value is ParttimeEmployee)
                    throw new ArgumentException("Leader khong duoc la nhan vien part time");
                leader = value;
            }
        }
        public List<Employee> Employees { get => employees; set => employees = value; }
        public Department() { }

        public Department(string id, string name, Employee leader, List<Employee> employees = null)
        {
            Id = id;
            Name = name;
            Leader = leader;
            this.employees = employees ?? new List<Employee>();
        }
        public Department(SerializationInfo info, StreamingContext context)
        {
            Id = info.GetString("Id");
            Name = info.GetString("Name");
            Leader = (Employee)info.GetValue("Leader",typeof(Employee));
            employees = (List<Employee>)info.GetValue("Employees",typeof (List<Employee>));
        }
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Id", Id);
            info.AddValue("Name", Name);
            info.AddValue("Leader",Leader);
            info.AddValue("Employees", Employees);
        }
        //Sử bắt ngoiaj lệ nếu ko thnhf cocng
        public void AddEmployee(Employee employee)
        {
            if (employees == null)
                throw new ArgumentException("Them nhan vien that bai");
            employees.Add(employee);
        }
        public void RemoveEmployee(Employee employee)
        {
            if (leader == employee) 
                leader = null;
            if (employees.Contains(employee))
                employees.Remove(employee);
            throw new ArgumentException("Khong tim thay nhan vien nay");
        }
        public bool Find(string keyword)
        {
            if (Name.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0)
                return true;
            throw new ArgumentException($"Khong tim thay {keyword}");
        }
        public string GetInfo()
        {
            string employeeNames = "Không có nhân viên";
            string leaderName = "Không có leader";
            if (employees.Count > 0)
            {
                employeeNames = "";
                foreach (Employee employee in employees)
                {
                    employeeNames += employee.Name + ", ";
                }
                employeeNames = employeeNames.TrimEnd(',', ' ');
            }
            if (leader != null)
            {
                leaderName = leader.Name;
            }
            return $"\n Ten phong bam: {Name} \n Id: {id} \n Leader: {leaderName} \n Thanh vien: {employeeNames} ";
        }

        public override string ToString()
        {
            return name;
        }
    }
}