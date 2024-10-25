using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ManagementLogic
{
    [Serializable]
    public class Project : ISerializable
    {
        private string id;
        private string projectName;
        private string description;
        Employee leader;
        private List<FulltimeEmployee> employees_FullTime = new List<FulltimeEmployee>();
        private List<ParttimeEmployee> employees_PartTime = new List<ParttimeEmployee>();

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
        public Employee Leader { get => leader; set => leader = value; }

        public Project() { }
        public Project(string id, string projectName, Employee leader = null, string description = "", List<FulltimeEmployee> employees_FullTime = null, List<ParttimeEmployee> employees_PartTime = null)
        {
            Id = id;
            ProjectName = projectName;
            Description = description;
            this.employees_FullTime = employees_FullTime ?? new List<FulltimeEmployee>();
            this.employees_PartTime = employees_PartTime ?? new List<ParttimeEmployee>();
            this.leader = leader;
        }
        public Project(SerializationInfo info, StreamingContext context)
        {
            Id = info.GetString("Id");
            ProjectName = info.GetString("ProjectName");
            Description = info.GetString("Description");
            Employees_FullTime = (List<FulltimeEmployee>)info.GetValue("Employees_FullTime", typeof(List<FulltimeEmployee>));
            Employees_PartTime = (List<ParttimeEmployee>)info.GetValue("Employees_PartTime", typeof(List<ParttimeEmployee>));
            leader = (Employee)info.GetValue("Leader", typeof(Employee));
        }
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Id", Id);
            info.AddValue("ProjectName", ProjectName);
            info.AddValue("Description", Description);
            info.AddValue("Employees_FullTime", Employees_FullTime);
            info.AddValue("Employees_PartTime", Employees_PartTime);
            info.AddValue("Leader",leader);
        }
        //Thêm logic chỉ khi leader la null mới được addd nếu ko sẽ trả về ngoại lệ 
        public void AddLeader(Employee leader)
        {
            if (this.leader != null)
                throw new InvalidOperationException("Da co leader cho project nay");
            this.leader = leader;
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
            if (leader == employee)
            {
                leader = null;
                return;
            }
            if (!Employees.Contains(employee))
                throw new ArgumentException("Khong tim thay nhan vien nay");

            if (employee is FulltimeEmployee fullTimeEmployee)
                Employees_FullTime.Remove(fullTimeEmployee);
            else if (employee is ParttimeEmployee parttime)
                Employees_PartTime.Remove(parttime);
        }
        public bool Find(string keyword)
        {
            if (ProjectName.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0) // keyword ko phan biet in hoa hay thuong
                return true;
            throw new ArgumentException($"Khong tim thay {keyword} trong project");
        }
        public string GetInfo()
        {
            string employeeNames = "Không có nhân viên";
            string leaderName = "";
            if (Employees.Count > 0)
            {
                employeeNames = "";
                foreach (Employee employee in Employees)
                {
                    employeeNames += employee.Name + ", ";
                }
                // Xóa dấu phẩy và khoảng trắng cuối cùng
                employeeNames = employeeNames.TrimEnd(',', ' ');
            }
            if (leader != null)
            {
                leaderName = leader.Name;
            }

            return $"\n Ten project: {ProjectName} \n Id: {id} \n Leader: {leaderName} \n Thanh vien: {employeeNames} \n Description: {Description} ";
        }
    }
}
