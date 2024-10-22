using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace ManagementLogic
{
    [Serializable]
    public class Management : ISerializable
    {
        private List<Employee> employeesList = new List<Employee>();
        private List<Department> departmentList = new List<Department>();
        private List<Project> projectList = new List<Project>();
        private Data data = new Data();
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

        [JsonConstructor] // Constructor này sẽ được gọi khi deserialization từ JSON
        public Management(List<Employee> employeesList, List<Department> departmentList, List<Project> projectList)
        {
            this.employeesList = employeesList;
            this.departmentList = departmentList;
            this.projectList = projectList;
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
        public List<Department> FindDepartment(string keyword)
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
        public List<Project> FindProject(string keyword)
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
            if (employeesList.Contains(e))
            {
                throw new Exception($"Nhân viên {e.Name} đã tồn tại");
            }
            employeesList.Add(e);
            SaveData();
            }
        public void Add(Department d, Employee leader = null, List<Employee> employees = default)
        {
            if (departmentList.Contains(d))
            {
                throw new Exception($"Phòng ban {d.Name} đã tồn tại");
            }
            if (leader != null)
            {
                leader.Department = d;
                d.Leader = leader;
            }
            if (employees.Count > 0)
            {
                foreach (Employee e in employees)
                {
                    e.Department = d;
                    d.AddEmployee(e);
                }
            }
            departmentList.Add(d);
            SaveData();
        }
        //Khi thêm một prọect mới thì cunngx phải thêm, leader và employees có thể bỏ trống
        //ếu có leaader hoặc một list emplyees thì phải đảm bảo Project đó đã được thêm cho các nhân viên đó .
        //Ví dụ bên duói 
        public void Add(Project p, Employee leader = null, List<Employee> employees = default)
        {
            if (projectList.Contains(p))
            {
                throw new Exception("Project đã tồn tại");
            }
            if (leader != null)
            {
                leader.AddProject(p);
                p.AddLeader(leader);
            }

            if (employees.Count > 0)
            {
                foreach (Employee e in employees)
                {
                    e.AddProject(p);
                    p.AddEmployee(e);
                }
            }
            projectList.Add(p);
            SaveData();
        }
        public void Remove(Employee e)
        {
            if (!employeesList.Contains(e))
            {
                throw new Exception("Không tồn tại nhân viên cần xóa");
            }
            foreach (Project p in e.Projects)
            {
                p.RemoveEmployee(e);
            }
            Department d = e.Department;
            d.RemoveEmployee(e);

            employeesList.Remove(e);
            SaveData();
        }
        public void Remove(Department d)
        {
            if (!departmentList.Contains(d))
            {
                throw new Exception("Không tồn tại phòng ban cần xóa");             
            }
            Employee leader = d.Leader;
            leader.Department = null;
            foreach (Employee e in d.Employees)
            {
                e.Department = null;
            }
            departmentList.Remove(d);
            SaveData();
        }
        public void Remove(Project p)
        {
            if (!projectList.Contains(p))
            {
                throw new Exception("Không tồn tại dự án cần xóa");
            }
            Employee leader = p.Leader;
            leader.Projects.Remove(p);
            foreach (Employee e in p.Employees)
            {
                e.Projects.Remove(p);
            }
            projectList.Remove(p);
            SaveData();
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
            if (e is FulltimeEmployee fulltimeEmployee)
            {
                if (fulltimeEmployee.Projects.Count >= 3)
                {
                    
                    uint baseSalary = e.Salary; 
                    uint newSalary = (uint)(e.Salary * 1.1); // tăng 10%

                    if (newSalary >= baseSalary)
                    {
                        fulltimeEmployee.Salary = newSalary;
                        SaveData();
                    }
                    else
                    {
                        throw new Exception("Lương không được thấp hơn lương cơ bản.");
                    }
                }
                else
                {
                    throw new Exception("Nhân viên fulltime phải tham gia ít nhất 3 dự án để được tăng lương.");
                }
            }
            else if (e is ParttimeEmployee parttimeEmployee)
            {
                if (parttimeEmployee.Worktime >= 100) 
                {
                    uint newSalary = (uint)(parttimeEmployee.Salary * 1.05); // Tăng 5% lương

                    if (newSalary >= 25000)
                    {
                        parttimeEmployee.Salary = newSalary;
                        SaveData();
                    }
                    else
                    {
                        throw new Exception("Lương parttime không được thấp hơn 25.000 đ");
                    }
                }
                else
                {
                    throw new Exception("Nhân viên parttime phải làm đủ số giờ yêu cầu để được tăng lương.");
                }
            }
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
            List<Account> accounts = Data.LoadAccounts();
            foreach (Account a in accounts)
            {
                if (a.IsValidUsername(account.UserName))
                {
                    a.ChangePassword(password, newPassword);
                }
            }
            Data.SaveAccounts(accounts);
        }
        public void ChangeInfoProject(string projectId, string newProjectName, string newDescription, string newLeaderId)
        {
            Project project = projectList.Find(p => p.Id == projectId);
            if (project == null)
            {
                throw new ArgumentException("Không tìm thấy dự án.");
            }

            if (!string.IsNullOrEmpty(newProjectName)) // trả về true nếu ko null 
            {
                project.ProjectName = newProjectName;
            }

            if (!string.IsNullOrEmpty(newDescription))
            {
                project.Description = newDescription;
            }

            if (!string.IsNullOrEmpty(newLeaderId))
            {
                Employee newLeader = employeesList.Find(e => e.Id == newLeaderId);
                if (newLeader == null || newLeader is ParttimeEmployee)
                {
                    throw new ArgumentException("Leader không hợp lệ ");
                }
                project.AddLeader(newLeader);
            }
        }
        public void ChangeInfoDepartment(string departmentId, string newName, string newLeaderId)
        {
            Department department = departmentList.Find(d => d.Id == departmentId);
            if (department == null)
            {
                throw new ArgumentException("Không tìm thấy phòng ban.");
            }

            if (!string.IsNullOrEmpty(newName)) // trả về true nếu ko null 
            {
                department.Name = newName; 
            }

            if (!string.IsNullOrEmpty(newLeaderId))
            {
                Employee newLeader = employeesList.Find(e => e.Id == newLeaderId);
                if (newLeader == null || newLeader is ParttimeEmployee)
                {
                    throw new ArgumentException("Leader không hợp lệ hoặc là nhân viên part-time.");
                }
                department.Leader = newLeader; 
            }

        }


    }
}