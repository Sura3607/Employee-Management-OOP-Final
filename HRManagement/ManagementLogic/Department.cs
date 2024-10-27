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
        private List<FulltimeEmployee> employees_FullTime = new List<FulltimeEmployee>();
        private List<ParttimeEmployee> employees_PartTime = new List<ParttimeEmployee>();
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
        public List<FulltimeEmployee> Employees_FullTime { get => employees_FullTime; set => employees_FullTime = value; }
        public List<ParttimeEmployee> Employees_PartTime { get => employees_PartTime; set => employees_PartTime = value; }
        public List<Employee> Employees
        {
            get
            {
                List<Employee> allEmployees = new List<Employee>();
                allEmployees.AddRange(Employees_FullTime);
                allEmployees.AddRange(Employees_PartTime);
                return allEmployees;
            }
        }
        public Department() { }

        public Department(string id, string name, Employee leader, List<FulltimeEmployee> employees_FullTime = null, List<ParttimeEmployee> employees_PartTime = null)
        {
            Id = id;
            Name = name;
            LeaderId = leader.Id;
            this.employees_FullTime = employees_FullTime ?? new List<FulltimeEmployee>();
            this.employees_PartTime = employees_PartTime ?? new List<ParttimeEmployee>();

            if(leader is FulltimeEmployee fulltime)
                employees_FullTime.Add(fulltime);
            else if(leader is ParttimeEmployee parttime)
                employees_PartTime.Add(parttime);
        }
        public Department(SerializationInfo info, StreamingContext context)
        {
            Id = info.GetString("Id");
            Name = info.GetString("Name");
            LeaderId = info.GetString("Leader");
            Employees_FullTime = (List<FulltimeEmployee>)info.GetValue("Employees_FullTime", typeof (List<FulltimeEmployee>));
            Employees_PartTime = (List<ParttimeEmployee>)info.GetValue("Employees_PartTime", typeof(List<ParttimeEmployee>));
        }
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Id", Id);
            info.AddValue("Name", Name);
            info.AddValue("Leader",LeaderId);
            info.AddValue("Employees_FullTime", Employees_FullTime);
            info.AddValue("Employees_PartTime", Employees_PartTime);
        }
        public void AddEmployee(Employee e)
        {
            if (e == null)
                throw new ArgumentException("Them nhan vien that bai");
            if (Employees.Contains(e))
                throw new ArgumentException("Nhan vien da ton tai");

            if (e is FulltimeEmployee fullTimeEmployee)
                Employees_FullTime.Add(fullTimeEmployee);
            else if (e is ParttimeEmployee parttime)
                Employees_PartTime.Add(parttime);
        }
        public void RemoveEmployee(Employee employee)
        {
            if (!Employees.Contains(employee))
                throw new ArgumentException("Khong tim thay nhan vien nay");

            //if (leader == employee)            
            //    leader = null;       .         

            if (employee is FulltimeEmployee fullTimeEmployee)
                Employees_FullTime.Remove(fullTimeEmployee);
            else if (employee is ParttimeEmployee parttime)
                Employees_PartTime.Remove(parttime);

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
            if (Employees.Count > 0)
            {
                employeeNames = "";
                foreach (Employee employee in Employees)
                {
                    employeeNames += employee.Name + ", ";
                }
                employeeNames = employeeNames.TrimEnd(',', ' ');
            }
            if (leaderId != null)
            {
                leaderName = leaderId;
            }
            return $"\n Ten phong bam: {Name} \n Id: {id} \n Leader: {leaderName} \n Thanh vien: {employeeNames} ";
        }

        public override string ToString()
        {
            return name;
        }
    }
}