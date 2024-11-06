using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ManagementLogic
{
    [Serializable]
    public class Management : ISerializable
    {
        private List<FulltimeEmployee> employeesList_FullTime = new List<FulltimeEmployee>();
        private List<ParttimeEmployee> employeesList_PartTime = new List<ParttimeEmployee>();
        private List<Department> departmentList = new List<Department>();
        private List<Project> projectList = new List<Project>();
        private Data data = new Data();
        private string filePath;
        private Account account;

        public List<Employee> EmployeesList
        {
            get
            {
                List<Employee> allEmployees = new List<Employee>();
                allEmployees.AddRange(EmployeesList_FullTime);
                allEmployees.AddRange(EmployeesList_PartTime);
                return allEmployees;
            }
        }
        public List<Department> DepartmentList { get => departmentList; set => departmentList = value; }
        public List<Project> ProjectList { get => projectList; set => projectList = value; }
        public List<FulltimeEmployee> EmployeesList_FullTime { get => employeesList_FullTime; set => employeesList_FullTime = value; }
        public List<ParttimeEmployee> EmployeesList_PartTime { get => employeesList_PartTime; set => employeesList_PartTime = value; }

        public Management() { }
        public Management(SerializationInfo info, StreamingContext context)
        {
            employeesList_FullTime = (List<FulltimeEmployee>)info.GetValue("Employees_FullTime", typeof(List<FulltimeEmployee>));
            employeesList_PartTime = (List<ParttimeEmployee>)info.GetValue("Employees_PartTime", typeof(List<ParttimeEmployee>));
            departmentList = (List<Department>)info.GetValue("Departments",typeof (List<Department>));
            projectList = (List<Project>)info.GetValue("Projects",typeof(List<Project>));
        }
        public Management(List<FulltimeEmployee> employeesList_FullTime, List<ParttimeEmployee> employeesList_PartTime, List<Department> departmentList, List<Project> projectList)
        {
            this.employeesList_FullTime = employeesList_FullTime;
            this.employeesList_PartTime = employeesList_PartTime;
            this.departmentList = departmentList;
            this.projectList = projectList;
        }
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Employees_FullTime", EmployeesList_FullTime);
            info.AddValue("Employees_PartTime", EmployeesList_PartTime);
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
        public void Add(Employee e)
        {
            if (EmployeesList.Contains(e))
                throw new Exception($"Nhân viên {e.Name} đã tồn tại"); 

            if (e is FulltimeEmployee fullTimeEmployee)
                EmployeesList_FullTime.Add(fullTimeEmployee);
            else if(e is ParttimeEmployee parttime)
                EmployeesList_PartTime.Add(parttime);

            SaveData();
        }
        public void Add(Department d,List<Employee> employees)
        {
            if (departmentList.Contains(d))
                throw new Exception($"Phòng ban {d.Name} đã tồn tại");

            if(employees!= null)
            {
                foreach (Employee e in employees)
                    e.Department = d;
            }
           
            departmentList.Add(d);
            SaveData();
        }
        public void Add(Project p, List<Employee> employees)
        {
            if (projectList.Contains(p))
                throw new Exception("Project đã tồn tại");

            foreach(Employee e in employees)
                e.AddProject(p);

            projectList.Add(p);
            SaveData();
        }
        public void Remove(Employee e)
        {
            if (!EmployeesList.Contains(e))
                throw new Exception("Không tồn tại nhân viên cần xóa");

            foreach (Project p in e.Projects)
            {
                p.RemoveEmployee(e);
            }
            if(e.Department != null)
            {
                Department d = e.Department;
                d.RemoveEmployee(e);
            }

            if (e is FulltimeEmployee fullTimeEmployee)
                EmployeesList_FullTime.Remove(fullTimeEmployee);
            else if (e is ParttimeEmployee parttime)
                EmployeesList_PartTime.Remove(parttime);

            SaveData();
        }
        public void Remove(Department d)
        {
            if (!departmentList.Contains(d))
            {
                throw new Exception("Không tồn tại phòng ban cần xóa");             
            }
            foreach (Employee employee in EmployeesList)
            {
                if (d.EmployeesId.Contains(employee.Id))
                {
                    employee.Department = null;
                }
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

            foreach (Employee e in EmployeesList)
            {
                if (p.EmployeesId.Contains(e.Id))
                {
                    e.Projects.Remove(p);
                }
            }
            projectList.Remove(p);
            SaveData();
        }

        public void EditEmployee(Employee employee, string name = null, string phone = null,
                                 string email = null, string address = null,
                                 bool? gender = null, DateTime? birthday = null,
                                 uint? salary = null, Department department = null)
        {
            if (EmployeesList.Contains(employee))
            {
                if (!string.IsNullOrWhiteSpace(name))
                {
                    employee.Name = name;
                }
                if (!string.IsNullOrWhiteSpace(phone))
                {
                    employee.Phone = phone;
                }
                if (!string.IsNullOrWhiteSpace(email))
                {
                    employee.Email = email;
                }
                if (!string.IsNullOrWhiteSpace(address))
                {
                    employee.Address = address;
                }
                if (gender.HasValue)
                {
                    employee.Gender = gender.Value;
                }
                if (birthday.HasValue)
                {
                    employee.Birthday = birthday.Value;
                }
                if (salary.HasValue)
                {
                    employee.Salary = salary.Value;
                }
                if (department != null)
                {
                    Department currentDepartment = employee.Department;
                    if (currentDepartment != null)
                    {
                        currentDepartment.RemoveEmployee(employee);
                    }
                    department.AddEmployee(employee);
                    employee.Department = department;
                }
                SaveData();
            }
            else
            {
                throw new Exception("Nhân viên không tồn tại.");
            }
        }
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
            bool exists = false;

            foreach (Account a in accounts)
            {
                if (a.IsValidUsername(username))
                {
                    exists = true;
                    break;
                }
            }

            if (exists)
            {
                throw new Exception("Tên tài khoản đã tồn tại.");
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
        public void EditInfoProject(Project project, string newProjectName = null, string newDescription = null, string newLeaderId = null,List < Employee > remove = null, List<Employee> add = null)
        {

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
                Employee newLeader = null;

                foreach (Employee e in EmployeesList)
                {
                    if (e.Id == newLeaderId)
                    {
                        newLeader = e;
                        break;
                    }
                }

                if (newLeader == null || newLeader is ParttimeEmployee)
                {
                    throw new ArgumentException("Leader không hợp lệ");
                }

                project.LeaderId = newLeader.Id;
            }
            if (remove != null)
            {
                foreach (Employee e in remove)
                {
                    project.RemoveEmployee(e);
                }
            }
            if (add != null)
            {
                foreach (Employee e in add)
                {
                    project.AddEmployee(e);
                }
            }
            SaveData();
        }
        public void EditInfoDepartment(Department department, string newName = null, string newLeaderId = null,List<Employee> remove = null, List<Employee> add = null)
        {
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
                Employee newLeader = null;

                foreach (Employee e in EmployeesList)
                {
                    if (e.Id == newLeaderId)
                    {
                        newLeader = e;
                        break;
                    }
                }

                if (newLeader == null || newLeader is ParttimeEmployee)
                {
                    throw new ArgumentException("Leader không hợp lệ hoặc là nhân viên part-time.");
                }

                department.LeaderId = newLeader.Id;
            }
            if (remove != null)
            {
                foreach (Employee e in remove)
                {
                    department.RemoveEmployee(e);
                }
            }
            if(add != null)
            {
                foreach(Employee e in add)
                {
                    department.AddEmployee(e);
                }
            }
            SaveData();
        }


    }
}