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
        public string Id { get => id; set => id = value; }
        public string ProjectName { get => projectName; set => projectName = value; }
        public string Description { get => description; set => description = value; }


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
        //Thêm logic chỉ khi leader lf null mới được addd nếu ko sẽ trả về ngoại lệ 
        public void AddLeader(Employee leader)
        {
            this.leader = leader;
        }

        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }
        public void RemoveEmployee(Employee employee)
        {
        }
        //Xử lí việc tìm nếu có tồn tại keyword trong tên project
        public bool Find(string keyword)
        {
            return true;
        }
        public string GetInfo()
        {
            return "";
        }
    }
}
