using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Text;

namespace ManagementLogic
{
    [Serializable]
    public class Management : ISerializable
    {
        private List<Employee> employeesList= new List<Employee>();
        private List<Department> departmentList = new List<Department>();
        private List<Project> projectList = new List<Project>();
        Data data = new Data();
        private string filePath;
        private Account account;

        public List<Employee> EmployeesList { get => employeesList;}
        public List<Department> DepartmentList { get => departmentList;}
        public List<Project> ProjectList { get => projectList;}

        public Management() { }
        public Management(SerializationInfo info, StreamingContext context)
        {
            employeesList = (List<Employee>)info.GetValue("Employees",typeof(List<Employee>));
            departmentList = (List<Department>)info.GetValue("Departments",typeof (List<Department>));
            projectList = (List<Project>)info.GetValue("Projects",typeof(List<Project>));
        }
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Employees", EmployeesList);
            info.AddValue("Departmants", DepartmentList);
            info.AddValue("Projects",ProjectList);
        } 
        public void SetFilePath(string filePath)
        {
            this.filePath = filePath;
        }
        public void SetCurrentAccount(Account account)
        {
            this.account = account;
        }
        public void SaveData()
        {
            data.SaveData(this,this.filePath);
        }
        //Xử lí lại việc tìm Nhân viên vì bây giờ có 2 kiểu nhân viên, ko bk trước đối tượng đó là loại gì
        public List<Employee> FindEmployee(string keyword)
        {
            List<Employee> l = new List<Employee>();
            foreach(Employee e in EmployeesList)
            {
                if (e.Find(keyword))
                {
                    l.Add(e);
                }
            }
            return l;
        }
        public List<Department> FindDeparment(string keyword)
        {
            List<Department> l = new List<Department>();
            foreach (Department d in DepartmentList)
            {
                if (d.Find(keyword))
                {
                    l.Add(d);
                }
            }
            return l;
        }
        public List<Project> FindPoject(string keyword)
        {
            List<Project> l = new List<Project>();
            foreach (Project p in ProjectList)
            {
                if (p.Find(keyword))
                {
                    l.Add(p);
                }
            }
            return l;
        }
        //Sau khi add/remove sẽ gọi savedata ngay lập tức
        //Các phương thức sau sẽ gọi tới các đói tượng
        //Add cái gì thì thêm vào list đó.
        //Remove trong list 
        //Lưu ý nên kiểm tra đối tượng lại một nữa xem đã hợp lệ chưa và add. ví dụ 
        public void Add(Employee e)
        {
            if (!employeesList.Contains(e))
            {
                employeesList.Add(e);
                SaveData();
            }
        }
        public void Add(Department d)
        {
            if (!departmentList.Contains(d))
            {
                departmentList.Add(d);
                SaveData();
            }
        }
        //Khi thêm một prọect mới thì cunngx phải thêm, leader và employees có thể bỏ trống
        //ếu có leaader hoặc một list emplyees thì phải đảm bảo Project đó đã được thêm cho các nhân viên đó .
        //Ví dụ bên duói 
        public void Add(Project d, Employee leader = null, List<Employee> employees = default)
        {
            if (!projectList.Contains(d))
            {
                projectList.Add(d);

                if (leader != null)
                {
                    leader.AddProject(d); 
                }

                if (employees.Count > 0)
                {
                    foreach (Employee e in employees)
                    {
                        e.AddProject(d); 
                    }
                }

                SaveData(); 
            }
        }
        public void Remove(Employee e)
        {
            if (employeesList.Contains(e))
            {
                foreach (Project p in projectList)
                {
                    p.RemoveEmployee(e);
                }
                employeesList.Remove(e);
                SaveData();
            }
        }
        public void Remove(Department d)
        {
            if (departmentList.Contains(d))
            {
                
                foreach (Employee e in employeesList)
                {
                    if (e.Department == d)
                    {
                        e.Department = null; 
                    }
                }
                departmentList.Remove(d);
                SaveData(); 
            }
        }
        //Nếu xóa thì dodongf thời cũng phải xóa trong các employees như trên 
        public void Remove(Project p)
        {
            if (projectList.Contains(p))
            {
                
                foreach (Employee e in employeesList)
                {
                    e.Projects.Remove(p);
                }
                projectList.Remove(p);
                SaveData(); 
            }
        }
        public string GetInfo(Employee e)
        {
            return e.GetInfo();
        }
        public string GetInfo(Department d)
        {
            return d.GetInfo();
        }
        public string GetInfo(Project p)
        {
            return p.GetInfo();
        }
        //sau khi cập nhật lương cũng sẽ được save, cập nhật lương thì cũng phả kiểm tra điều kiện ,
        //Kt đầu tiên đó là nhân viên gì part hay full
        //kt việc tăng lương ddungs với đối tượng ko. Lương full ko thấp hơn lương cơ bản, lương parttime ko ít hơn 25k
        //Và parttime thì đủ giơpf làm mới được tính tăng lương, Nhân viên full time thì phải đủ 3 dự án trở lên.
        public void SalaryIncrease(Employee e)
        {
            
        }
        public void AddADMIN(string username, string password)
        {
            CreateAdmin(username, password);
        }
        private void CreateAdmin(string username, string password)
        {
            List<Account> accounts = Data.LoadAccounts();
            if (accounts.Exists(a => a.IsValidUsername(username)))
            {
                throw new Exception("Username already exists.");
            }
            accounts.Add(new Account(username, password));
            Data.SaveAccounts(accounts);
        }
        public void ChangePasssword(string password, string newPassword)
        {
            account.ChangePassword(password, newPassword);
        }
    }
}