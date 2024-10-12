using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

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
        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public Employee Leader { get => leader; set => leader = value; }
        public List<Employee> Employees
        {
            get => employees;
            set
            {
                if (value == null)
                    throw new ArgumentNullException();
            }
        }
        public Department(string id, string name, Employee leader, List<Employee> employees = default)
        {
            Id = id;
            Name = name;
            Leader = leader;
            Employees = employees;
        }
        public Department(SerializationInfo info, StreamingContext context)
        {
            Id = info.GetString("id");
            Name = info.GetString("name");
            Leader = (Employee)info.GetValue("Leader",typeof(Employee));
            Employees = (List<Employee>)info.GetValue("Employees",typeof (List<Employee>));
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
        
        }
        public void RemoveEmployee(Employee employee)
        {
            
        }
        public bool Find(string keywork)
        {
            return true;
        }
        public string GetInfo()
        {
            return "";
        }

    }
}