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


        //Khi khởi tạo ko bắt buộc phải có desciption 
        public Project(string id, string projectName, Employee leader = null, List<Employee> employees= default, string description = "")
        {
            Id = id;
            ProjectName = projectName;
            Description = description;
            this.employees = employees;
            this.leader = leader;
        }
        public Project(SerializationInfo info, StreamingContext context)
        {
            Id = info.GetString("Id");
            ProjectName = info.GetString("ProjectName");
            Description = info.GetString("Description");
            employees = (List<Employee>)info.GetValue("Employees",typeof(List<Employee>));
            leader = (Employee)info.GetValue("Leader", typeof(Employee));
        }
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Id", Id);
            info.AddValue("ProjectName", ProjectName);
            info.AddValue("Description", Description);
            info.AddValue("Employees", employees);
            info.AddValue("Leader",leader);
        }
        //Thêm logic chỉ khi leader la null mới được addd nếu ko sẽ trả về ngoại lệ 
        public void AddLeader(Employee leader)
        {
            if (this.leader != null)
                throw new InvalidOperationException("Da co leader cho project nay");
            this.leader = leader;
        }

        public void AddEmployee(Employee employee)
        {
            if (employees == null)
                employees = new List<Employee>();
            employees.Add(employee);
        }
        public void RemoveEmployee(Employee employee)
        {
            if (employees.Contains(employee))
                employees.Remove(employee);
            throw new ArgumentException("Project khong co nhan vien nay");
        }
        //Xử lí việc tìm nếu có tồn tại keyword trong tên project
        public bool Find(string keyword)
        {
            if (ProjectName.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0) // keyword ko phan biet in hoa hay thuong
                return true;
            throw new ArgumentException($"Khong tim thay {keyword} trong project");
        }
        public string GetInfo()
        {
            string employeeNames = employees.Count > 0 ? string.Join(", ", employees.Select(e => e.Name)) : "Khong co nv";
            //                                           nối chuỗi         chọn thuộc tính name trong danh sách 
            return $"\n Ten project: {ProjectName} \n Id: {id} \n Leader: {leader} \n Thanh vien: {employeeNames} \n Description: {Description} ";
        }
    }
}
