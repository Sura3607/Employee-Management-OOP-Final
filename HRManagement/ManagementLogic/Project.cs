using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Linq;

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

        //Tạo các logic cho viêccj set của các property dưới đây , ví dụ description ko đuocwj quá 250 kí tự 
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
        public string ProjectName 
        {
            get => projectName;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Ten project khong duoc de trong");
                projectName = value;
            } 
        }
        public string Description 
        {
            get => description;
            set
            {
                if (value.Length > 250)
                    throw new ArgumentException("Khong duoc qua 250 ky tu");
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
                throw new ArgumentException("Them nhan vien that bai");
            if (EmployeesId.Contains(e.Id))
                throw new ArgumentException("Nhan vien da ton tai");
            EmployeesId.Add(e.Id);
            e.AddProject(this);

        }
        public void RemoveEmployee(Employee employee)
        {

            if (!EmployeesId.Contains(employee.Id))
                throw new ArgumentException("Khong tim thay nhan vien nay");

            if (leaderId == employee.Id)
                leaderId = null;

            EmployeesId.Remove(employee.Id);
            employee.Projects.Remove(this);
        }
        public bool Find(string keyword)
        {
            return Id.IndexOf(keyword) >= 0 ||
                   ProjectName.IndexOf(keyword) >= 0;
        }
        //public string GetInfo()
        //{
        //    string employeeNames = "Không có nhân viên";
        //    string leaderName = "";
        //    if (EmployeesId.Count > 0)
        //    {
        //        employeeNames = "";
        //        foreach (Employee employee in EmployeesId)
        //        {
        //            employeeNames += employee.Name + ", ";
        //        }
        //        // Xóa dấu phẩy và khoảng trắng cuối cùng
        //        employeeNames = employeeNames.TrimEnd(',', ' ');
        //    }
        //    if (leaderId != null)
        //    {
        //        leaderName = leaderId.Name;
        //    }

        //    return $"\n Ten project: {ProjectName} \n Id: {id} \n Leader: {leaderName} \n Thanh vien: {employeeNames} \n Description: {Description} ";
        //}
    }
}
