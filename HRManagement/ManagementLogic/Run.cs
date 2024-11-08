﻿using System;
using System.Collections.Generic;

namespace ManagementLogic
{
    public class Run
    {
        private Management management = null;
        private static Run instance;
        private Run() { }
        public Management Management { get => management; }

        //singleton design patten
        public static Run Instance 
        {
            get
            {
                if(instance == null)
                    instance = new Run();
                return instance;
            }
        }
        public void Login(string username, string password)
        {
            List<Account> accounts = Data.LoadAccounts();

            Account account = null;
            foreach(Account a in accounts)
            {
                if(a.UserName == username)
                {
                    account = a;
                    break;
                }
            }
            if (account == null || !account.IsValidPassword(password))
            {
                throw new Exception("Tài khoản hoặc mật khẩu sai");
            }
            
            management = Data.LoadData(account.GetFilePath());
            management.SetFilePath(account.GetFilePath());
            management.SetCurrentAccount(account);

        }
        public string GenerateId(int who = 1)
        {
            char c;
            Random random = new Random();
            if (who == 1)
            {
                c = 'E';
                
            }
            else if (who == 0)
            {
                c = 'D';
            }
            else
            {
                c = 'P';
            }
            bool isUnique;
            string s;
            do
            {
                uint id = (uint)random.Next(0, 10000); // Giới hạn trong 4 chữ số
                s = $"{c}{id.ToString("D4")}";
                isUnique = true;

                if (who == 1)
                {
                    List<Employee> list = FindEmployee(s);
                    if(list.Count > 0)
                    {
                        isUnique = false;
                        break;
                    }

                }
                else if (who == 0)
                {
                    List<Department> list = FindIDeparment(s);
                    if (list.Count > 0)
                    {
                        isUnique = false;
                        break;
                    }
                }
                else
                {
                    List<Project> list = FindProject(s);
                    if (list.Count > 0)
                    {
                        isUnique = false;
                        break;
                    }
                }
            }
            while (!isUnique);
            return s;
        }
        public void CreateEmployee(string name, string phone, string email, 
                                   string address, bool gender, DateTime birthday, 
                                   DateTime beginWork, Department deparment, uint salary, 
                                   bool isFullTime = true)
        {
            if(isFullTime)
            {
                FulltimeEmployee fulltimeEmployee = new FulltimeEmployee(GenerateId(1),name,phone,email,address,gender,
                                                                 birthday,beginWork,deparment,salary);
                management.Add(fulltimeEmployee);
                return;
            }
            ParttimeEmployee parttimeEmployee = new ParttimeEmployee(GenerateId(1), name, phone, email, address, gender,
                                                                birthday, beginWork, deparment, salary);
            management.Add(parttimeEmployee);
        }
        public void CreateDepart(string name, Employee leader, List<Employee> employees = null)
        {
            if(string.IsNullOrEmpty(name))
                throw new Exception("Tên không được để trống");
            if (leader == null)
                throw new Exception("Leader không được để trống");


            Department department = new Department(GenerateId(0), name, leader,employees);
            management.Add(department,employees);
        }
        public void CreateProject(string name, Employee leader, List<Employee> employees = null, string description = "")
        {
            if (leader == null)
                throw new Exception("Leader không được để trống");

            Project project = new Project(GenerateId(-1), name, leader,employees, description);
            management.Add(project,employees);
        }
        public void RemoveEmployee(Employee employee)
        {
            management.Remove(employee);
        }
        public void RemoveDepart(Department department)
        {
            management.Remove(department);
        }
        public void RemoveProject(Project project)
        {
            management.Remove(project);
        }
        public void EditEmployee(Employee employee, string name = null, string phone = null,
                                 string email = null, string address = null,
                                 bool? gender = null, DateTime? birthday = null,
                                 uint? salary = null,Department department = null)
        {
            management.EditEmployee(employee, name, phone, email, address, gender, birthday, salary,department);
        }

        public void AddADMIN(string username, string password)
        {
            management.AddADMIN(username, password);
        }
        public void ChangePass(string password, string newPassword)
        {
            management.ChangePasssword(password, newPassword);
        }
        public void EditProject(Project project, string newName, string newDescription, string newLeader, List<Employee> remove, List<Employee> add)
        {
            management.EditInfoProject(project, newName, newDescription, newLeader, remove, add);
        }
        public void EditDepartment(Department department, string newName, string newLeader, List<Employee> remove, List<Employee> add)
        {
            management.EditInfoDepartment(department, newName, newLeader,remove,add);
        }
        public void IncreaseEmployeeSalary(Employee e)
        {
            management.SalaryIncrease(e);
        }
        public List<Employee> FindEmployee(string keyword = "")
        {
            return management.FindEmployee(keyword);
        }
        public List<Department> FindIDeparment(string keyword = "")
        {
            return management.FindDepartment(keyword);
        }
        public List<Project> FindProject(string keyword = "")
        {
            return management.FindProject(keyword);
        }
    }
}
