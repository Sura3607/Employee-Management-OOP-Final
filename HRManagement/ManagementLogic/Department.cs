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
        private string leaderId;
        private List<string> employeesId;
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
        public string LeaderId
        {
            get => leaderId;
            set
            {
                //if (value is ParttimeEmployee)
                //    throw new ArgumentException("Leader khong duoc la nhan vien part time");
                leaderId = value;
            }
        }
        public List<string> EmployeesId { get => employeesId; set => employeesId = value; }
      
        public Department() { }

        public Department(string id, string name, Employee leader, List<Employee> employees = null) 
        { 
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
                throw new ArgumentException("Them nhan vien that bai");
            if (EmployeesId.Contains(e.Id))
                throw new ArgumentException("Nhan vien da ton tai");

            employeesId.Add(e.Id);
        }
        public void RemoveEmployee(Employee employee)
        {
            if (!EmployeesId.Contains(employee.Id))
                throw new ArgumentException("Khong tim thay nhan vien nay");

            if (leaderId == employee.Id)            
                leaderId = null;                

            EmployeesId.Remove(employee.Id);
        }
        public bool Find(string keyword)
        {
            if (Name.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0)
                return true;
            throw new ArgumentException($"Khong tim thay {keyword}");
        }
        //public string GetInfo()
        //{
        //    string employeeNames = "Không có nhân viên";
        //    string leaderName = "Không có leader";
        //    if (EmployeesId.Count > 0)
        //    {
        //        employeeNames = "";
        //        foreach (string Id in EmployeesId)
        //        {
        //            employeeNames += employee.Name + ", ";
        //        }
        //        employeeNames = employeeNames.TrimEnd(',', ' ');
        //    }
        //    if (leaderId != null)
        //    {
        //        leaderName = leaderId;
        //    }
        //    return $"\n Ten phong bam: {Name} \n Id: {id} \n Leader: {leaderName} \n Thanh vien: {employeeNames} ";
        //}

        public override string ToString()
        {
            return name;
        }
    }
}